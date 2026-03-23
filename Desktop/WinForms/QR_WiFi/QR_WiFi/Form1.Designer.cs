namespace QR_WiFi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblSsid = new Label();
            lblPass = new Label();
            tbSsid = new TextBox();
            tbPass = new TextBox();
            btnGenerate = new Button();
            pbQrCode = new PictureBox();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQrCode).BeginInit();
            SuspendLayout();
            // 
            // lblSsid
            // 
            lblSsid.AutoSize = true;
            lblSsid.Location = new Point(59, 92);
            lblSsid.Name = "lblSsid";
            lblSsid.Size = new Size(33, 15);
            lblSsid.TabIndex = 0;
            lblSsid.Text = "SSID:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(50, 148);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(60, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password:";
            // 
            // tbSsid
            // 
            tbSsid.Location = new Point(119, 92);
            tbSsid.Name = "tbSsid";
            tbSsid.Size = new Size(100, 23);
            tbSsid.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(119, 140);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(100, 23);
            tbPass.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(175, 269);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // pbQrCode
            // 
            pbQrCode.Location = new Point(280, 25);
            pbQrCode.Name = "pbQrCode";
            pbQrCode.Size = new Size(310, 267);
            pbQrCode.TabIndex = 5;
            pbQrCode.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(50, 273);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 316);
            Controls.Add(lblStatus);
            Controls.Add(pbQrCode);
            Controls.Add(btnGenerate);
            Controls.Add(tbPass);
            Controls.Add(tbSsid);
            Controls.Add(lblPass);
            Controls.Add(lblSsid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QR Generator";
            ((System.ComponentModel.ISupportInitialize)pbQrCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSsid;
        private Label lblPass;
        private TextBox tbSsid;
        private TextBox tbPass;
        private Button btnGenerate;
        private PictureBox pbQrCode;
        private Label lblStatus;
    }
}
