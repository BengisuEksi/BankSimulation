namespace BankSimulation
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accountno_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.signup_lbl = new System.Windows.Forms.LinkLabel();
            this.signint_bttn = new System.Windows.Forms.Button();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(386, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUMOS BANK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(308, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(359, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // accountno_txtbox
            // 
            this.accountno_txtbox.Location = new System.Drawing.Point(448, 132);
            this.accountno_txtbox.Mask = "000000";
            this.accountno_txtbox.Name = "accountno_txtbox";
            this.accountno_txtbox.Size = new System.Drawing.Size(169, 27);
            this.accountno_txtbox.TabIndex = 1;
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.ForeColor = System.Drawing.Color.Navy;
            this.exit_bttn.Location = new System.Drawing.Point(665, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 5;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // signup_lbl
            // 
            this.signup_lbl.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_lbl.AutoSize = true;
            this.signup_lbl.BackColor = System.Drawing.Color.Transparent;
            this.signup_lbl.LinkColor = System.Drawing.Color.Navy;
            this.signup_lbl.Location = new System.Drawing.Point(374, 248);
            this.signup_lbl.Name = "signup_lbl";
            this.signup_lbl.Size = new System.Drawing.Size(222, 19);
            this.signup_lbl.TabIndex = 4;
            this.signup_lbl.TabStop = true;
            this.signup_lbl.Text = "Don\'t have an account? Sign up!";
            this.signup_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_lbl_LinkClicked);
            this.signup_lbl.MouseEnter += new System.EventHandler(this.signup_lbl_MouseEnter);
            this.signup_lbl.MouseLeave += new System.EventHandler(this.signup_lbl_MouseLeave);
            // 
            // signint_bttn
            // 
            this.signint_bttn.BackColor = System.Drawing.Color.Transparent;
            this.signint_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signint_bttn.ForeColor = System.Drawing.Color.Navy;
            this.signint_bttn.Location = new System.Drawing.Point(448, 204);
            this.signint_bttn.Name = "signint_bttn";
            this.signint_bttn.Size = new System.Drawing.Size(169, 30);
            this.signint_bttn.TabIndex = 3;
            this.signint_bttn.Text = "Sign In";
            this.signint_bttn.UseVisualStyleBackColor = false;
            this.signint_bttn.Click += new System.EventHandler(this.signint_bttn_Click);
            this.signint_bttn.MouseEnter += new System.EventHandler(this.signint_bttn_MouseEnter);
            this.signint_bttn.MouseLeave += new System.EventHandler(this.signint_bttn_MouseLeave);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(448, 168);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(169, 27);
            this.password_txtbox.TabIndex = 2;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 305);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.signint_bttn);
            this.Controls.Add(this.signup_lbl);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.accountno_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox accountno_txtbox;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.LinkLabel signup_lbl;
        private System.Windows.Forms.Button signint_bttn;
        private System.Windows.Forms.TextBox password_txtbox;
    }
}