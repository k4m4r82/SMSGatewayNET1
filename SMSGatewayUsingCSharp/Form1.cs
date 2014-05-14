using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;

namespace SMSGatewayUsingCSharp
{
    public partial class Form1 : Form
    {
        private GsmCommMain comm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            var port = "COM1"; // port yang digunakan menyesuaikan
            var baudRate = 9600;
            var timeout = 150;

            comm = new GsmCommMain(port, baudRate, timeout);
            comm.MessageReceived += new MessageReceivedEventHandler(comm_MessageReceived);

            try
            {
                comm.Open();

                while (!comm.IsConnected())
                {
                    var msgResult = MessageBox.Show(this, "No phone connected.", "Connection setup",
                                                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                    if (msgResult == DialogResult.Cancel)
                    {
                        comm.Close();
                        return;
                    }
                    else
                    {
                        comm.Close();
                        comm.Open();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Connection error: " + ex.Message, "Connection setup", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
        }

        private void comm_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var obj = e.IndicationObject;

            if (obj is MemoryLocation)
            {
                var loc = (MemoryLocation)obj;

                var msg = string.Format("New message received in storage \"{0}\", index {1}.",
                                        loc.Storage, loc.Index);
                MessageBox.Show(msg);

                return;
            }

            if (obj is ShortMessage)
            {
                var msg = (ShortMessage)obj;
                var pdu = comm.DecodeReceivedMessage(msg);

                MessageBox.Show("New message received");
            }
        }

        private void btnBacaSMS_Click(object sender, EventArgs e)
        {
            var messages = comm.ReadMessages(PhoneMessageStatus.All, PhoneStorageType.Sim);
            foreach (var message in messages)
            {
                var data = (SmsDeliverPdu)message.Data;

                var phoneNumber = data.OriginatingAddress;
                var msg = data.UserDataText;
                var tanggal = string.Format("{0:yyyy/MM/dd}", data.SCTimestamp.ToDateTime());
                var jam = string.Format("{0:HH:mm:ss}", data.SCTimestamp.ToDateTime());


                lstDaftarSMS.Items.Add(string.Format("{0}, {1}, {2}, {3}", tanggal, jam, phoneNumber, msg));
            }
        }

        private OutgoingSmsPdu[] CreateConcatMessage(string message, string number)
        {
            OutgoingSmsPdu[] pdus = null;

            try
            {
                pdus = SmartMessageFactory.CreateConcatTextMessage(message, number);
            }
            catch
            {
                return null;
            }

            return pdus;
        }

        private void SendMultiple(OutgoingSmsPdu[] pdus)
        {
            var num = pdus.Length;

            try
            {
                // Send the created messages
                comm.EnableTemporarySmsBatchMode();

                foreach (OutgoingSmsPdu pdu in pdus)
                {
                    comm.SendMessage(pdu);
                }
            }
            catch
            {
            }
        }

        private void btnKirimSMS_Click(object sender, EventArgs e)
        {
            var msg = txtPesan.Text;
            var phoneNumber = txtNoHp.Text;

            if (msg.Length > 160)
            {
                var pdus = CreateConcatMessage(msg, phoneNumber);
                if (pdus != null) SendMultiple(pdus);
            }
            else
            {
                var pdu = new SmsSubmitPdu(msg, phoneNumber, string.Empty);
                comm.SendMessage(pdu);
            }
        }
    }
}
