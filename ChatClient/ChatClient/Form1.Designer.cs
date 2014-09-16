namespace ChatClient
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
            this.serverStatus = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.clientTxt = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.chatName = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Location = new System.Drawing.Point(12, 9);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(66, 13);
            this.serverStatus.TabIndex = 0;
            this.serverStatus.Text = "serverStatus";
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(12, 51);
            this.serverTxt.Multiline = true;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serverTxt.Size = new System.Drawing.Size(260, 105);
            this.serverTxt.TabIndex = 1;
            this.serverTxt.TextChanged += new System.EventHandler(this.serverTxt_TextChanged);
            // 
            // clientTxt
            // 
            this.clientTxt.Location = new System.Drawing.Point(15, 162);
            this.clientTxt.Multiline = true;
            this.clientTxt.Name = "clientTxt";
            this.clientTxt.Size = new System.Drawing.Size(257, 57);
            this.clientTxt.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(15, 225);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(117, 24);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(155, 25);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(117, 20);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // chatName
            // 
            this.chatName.Location = new System.Drawing.Point(12, 25);
            this.chatName.Name = "chatName";
            this.chatName.Size = new System.Drawing.Size(137, 20);
            this.chatName.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(294, 25);
            this.maskedTextBox1.Mask = "###,###,###,###";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.Text = "127  0  0  1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 261);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.chatName);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.clientTxt);
            this.Controls.Add(this.serverTxt);
            this.Controls.Add(this.serverStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox clientTxt;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox chatName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

