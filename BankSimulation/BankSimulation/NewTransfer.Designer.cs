namespace BankSimulation
{
    partial class NewTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTransfer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.transfer_bttn = new System.Windows.Forms.Button();
            this.sender_txtbox = new System.Windows.Forms.TextBox();
            this.receiver_txtbox = new System.Windows.Forms.TextBox();
            this.amount_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(89, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(72, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiver: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(83, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount: ";
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.ForeColor = System.Drawing.Color.Navy;
            this.exit_bttn.Location = new System.Drawing.Point(458, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 5;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // transfer_bttn
            // 
            this.transfer_bttn.BackColor = System.Drawing.Color.Transparent;
            this.transfer_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfer_bttn.Location = new System.Drawing.Point(189, 188);
            this.transfer_bttn.Name = "transfer_bttn";
            this.transfer_bttn.Size = new System.Drawing.Size(235, 33);
            this.transfer_bttn.TabIndex = 4;
            this.transfer_bttn.Text = "Transfer";
            this.transfer_bttn.UseVisualStyleBackColor = false;
            this.transfer_bttn.Click += new System.EventHandler(this.transfer_bttn_Click);
            this.transfer_bttn.MouseEnter += new System.EventHandler(this.transfer_bttn_MouseEnter);
            this.transfer_bttn.MouseLeave += new System.EventHandler(this.transfer_bttn_MouseLeave);
            // 
            // sender_txtbox
            // 
            this.sender_txtbox.Enabled = false;
            this.sender_txtbox.Location = new System.Drawing.Point(189, 65);
            this.sender_txtbox.Name = "sender_txtbox";
            this.sender_txtbox.Size = new System.Drawing.Size(235, 30);
            this.sender_txtbox.TabIndex = 10;
            // 
            // receiver_txtbox
            // 
            this.receiver_txtbox.Location = new System.Drawing.Point(189, 105);
            this.receiver_txtbox.Name = "receiver_txtbox";
            this.receiver_txtbox.Size = new System.Drawing.Size(235, 30);
            this.receiver_txtbox.TabIndex = 2;
            // 
            // amount_txtbox
            // 
            this.amount_txtbox.Location = new System.Drawing.Point(189, 145);
            this.amount_txtbox.Name = "amount_txtbox";
            this.amount_txtbox.Size = new System.Drawing.Size(235, 30);
            this.amount_txtbox.TabIndex = 3;
            // 
            // NewTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 267);
            this.Controls.Add(this.amount_txtbox);
            this.Controls.Add(this.receiver_txtbox);
            this.Controls.Add(this.sender_txtbox);
            this.Controls.Add(this.transfer_bttn);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTransfer";
            this.Load += new System.EventHandler(this.NewTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button transfer_bttn;
        private System.Windows.Forms.TextBox sender_txtbox;
        private System.Windows.Forms.TextBox receiver_txtbox;
        private System.Windows.Forms.TextBox amount_txtbox;
    }
}