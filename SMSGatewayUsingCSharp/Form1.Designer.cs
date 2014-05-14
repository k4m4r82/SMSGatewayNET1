namespace SMSGatewayUsingCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTesKoneksi = new System.Windows.Forms.Button();
            this.btnBacaSMS = new System.Windows.Forms.Button();
            this.btnKirimSMS = new System.Windows.Forms.Button();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDaftarSMS = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTesKoneksi
            // 
            this.btnTesKoneksi.Location = new System.Drawing.Point(12, 12);
            this.btnTesKoneksi.Name = "btnTesKoneksi";
            this.btnTesKoneksi.Size = new System.Drawing.Size(75, 23);
            this.btnTesKoneksi.TabIndex = 0;
            this.btnTesKoneksi.Text = "Tes Koneksi";
            this.btnTesKoneksi.UseVisualStyleBackColor = true;
            this.btnTesKoneksi.Click += new System.EventHandler(this.btnTesKoneksi_Click);
            // 
            // btnBacaSMS
            // 
            this.btnBacaSMS.Location = new System.Drawing.Point(6, 178);
            this.btnBacaSMS.Name = "btnBacaSMS";
            this.btnBacaSMS.Size = new System.Drawing.Size(75, 23);
            this.btnBacaSMS.TabIndex = 2;
            this.btnBacaSMS.Text = "Baca";
            this.btnBacaSMS.UseVisualStyleBackColor = true;
            this.btnBacaSMS.Click += new System.EventHandler(this.btnBacaSMS_Click);
            // 
            // btnKirimSMS
            // 
            this.btnKirimSMS.Location = new System.Drawing.Point(183, 19);
            this.btnKirimSMS.Name = "btnKirimSMS";
            this.btnKirimSMS.Size = new System.Drawing.Size(75, 23);
            this.btnKirimSMS.TabIndex = 3;
            this.btnKirimSMS.Text = "Kirim";
            this.btnKirimSMS.UseVisualStyleBackColor = true;
            this.btnKirimSMS.Click += new System.EventHandler(this.btnKirimSMS_Click);
            // 
            // txtNoHp
            // 
            this.txtNoHp.Location = new System.Drawing.Point(52, 21);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(125, 20);
            this.txtNoHp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tujuan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDaftarSMS);
            this.groupBox1.Controls.Add(this.btnBacaSMS);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " [ Baca SMS ]";
            // 
            // lstDaftarSMS
            // 
            this.lstDaftarSMS.FormattingEnabled = true;
            this.lstDaftarSMS.Location = new System.Drawing.Point(6, 19);
            this.lstDaftarSMS.Name = "lstDaftarSMS";
            this.lstDaftarSMS.Size = new System.Drawing.Size(252, 147);
            this.lstDaftarSMS.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesan);
            this.groupBox2.Controls.Add(this.btnKirimSMS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNoHp);
            this.groupBox2.Location = new System.Drawing.Point(284, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 207);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Kirim SMS ] ";
            // 
            // txtPesan
            // 
            this.txtPesan.Location = new System.Drawing.Point(9, 65);
            this.txtPesan.Multiline = true;
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.Size = new System.Drawing.Size(249, 136);
            this.txtPesan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Isi Pesan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 267);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTesKoneksi);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Gateway Edisi .NET";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesKoneksi;
        private System.Windows.Forms.Button btnBacaSMS;
        private System.Windows.Forms.Button btnKirimSMS;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDaftarSMS;
    }
}

