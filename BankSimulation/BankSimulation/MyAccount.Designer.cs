namespace BankSimulation
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.back_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.surname_txtbox = new System.Windows.Forms.TextBox();
            this.account_txtbox = new System.Windows.Forms.TextBox();
            this.id_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.phone_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.password_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.update_bttn = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.balance_txtbox = new System.Windows.Forms.TextBox();
            this.add_money_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.ForeColor = System.Drawing.Color.Navy;
            this.exit_bttn.Location = new System.Drawing.Point(663, 0);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 18;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // back_bttn
            // 
            this.back_bttn.BackColor = System.Drawing.Color.Transparent;
            this.back_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_bttn.BackgroundImage")));
            this.back_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bttn.ForeColor = System.Drawing.Color.Navy;
            this.back_bttn.Location = new System.Drawing.Point(627, 0);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(30, 30);
            this.back_bttn.TabIndex = 17;
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            this.back_bttn.MouseEnter += new System.EventHandler(this.back_bttn_MouseEnter);
            this.back_bttn.MouseLeave += new System.EventHandler(this.back_bttn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "My Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(94, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(72, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Surname: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(120, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(92, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(75, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Account: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(62, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password: ";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(167, 87);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(208, 30);
            this.name_txtbox.TabIndex = 10;
            // 
            // surname_txtbox
            // 
            this.surname_txtbox.Location = new System.Drawing.Point(167, 123);
            this.surname_txtbox.Name = "surname_txtbox";
            this.surname_txtbox.Size = new System.Drawing.Size(208, 30);
            this.surname_txtbox.TabIndex = 11;
            // 
            // account_txtbox
            // 
            this.account_txtbox.Enabled = false;
            this.account_txtbox.Location = new System.Drawing.Point(167, 231);
            this.account_txtbox.Name = "account_txtbox";
            this.account_txtbox.Size = new System.Drawing.Size(208, 30);
            this.account_txtbox.TabIndex = 5;
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(167, 159);
            this.id_txtbox.Mask = "00000000000";
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(208, 30);
            this.id_txtbox.TabIndex = 12;
            this.id_txtbox.ValidatingType = typeof(int);
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Location = new System.Drawing.Point(167, 195);
            this.phone_txtbox.Mask = "(999) 000-0000";
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(208, 30);
            this.phone_txtbox.TabIndex = 13;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(167, 267);
            this.password_txtbox.Mask = "0000000000";
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(208, 30);
            this.password_txtbox.TabIndex = 14;
            // 
            // update_bttn
            // 
            this.update_bttn.BackColor = System.Drawing.Color.Transparent;
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_bttn.Location = new System.Drawing.Point(430, 192);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(211, 32);
            this.update_bttn.TabIndex = 16;
            this.update_bttn.Text = "Update Account";
            this.update_bttn.UseVisualStyleBackColor = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            this.update_bttn.MouseEnter += new System.EventHandler(this.update_bttn_MouseEnter);
            this.update_bttn.MouseLeave += new System.EventHandler(this.update_bttn_MouseLeave);
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.Transparent;
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.Location = new System.Drawing.Point(430, 233);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(211, 32);
            this.delete_bttn.TabIndex = 17;
            this.delete_bttn.Text = "Delete Account";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            this.delete_bttn.MouseEnter += new System.EventHandler(this.delete_bttn_MouseEnter);
            this.delete_bttn.MouseLeave += new System.EventHandler(this.delete_bttn_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(76, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Balance: ";
            // 
            // balance_txtbox
            // 
            this.balance_txtbox.Location = new System.Drawing.Point(167, 303);
            this.balance_txtbox.Name = "balance_txtbox";
            this.balance_txtbox.Size = new System.Drawing.Size(208, 30);
            this.balance_txtbox.TabIndex = 22;
            // 
            // add_money_bttn
            // 
            this.add_money_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add_money_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_money_bttn.Location = new System.Drawing.Point(430, 152);
            this.add_money_bttn.Name = "add_money_bttn";
            this.add_money_bttn.Size = new System.Drawing.Size(211, 32);
            this.add_money_bttn.TabIndex = 15;
            this.add_money_bttn.Text = "Update Balance Amount\r\n";
            this.add_money_bttn.UseVisualStyleBackColor = false;
            this.add_money_bttn.Click += new System.EventHandler(this.add_money_bttn_Click);
            this.add_money_bttn.MouseEnter += new System.EventHandler(this.add_money_bttn_MouseEnter);
            this.add_money_bttn.MouseLeave += new System.EventHandler(this.add_money_bttn_MouseLeave);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 370);
            this.Controls.Add(this.add_money_bttn);
            this.Controls.Add(this.balance_txtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.update_bttn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.phone_txtbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.account_txtbox);
            this.Controls.Add(this.surname_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.exit_bttn);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox surname_txtbox;
        private System.Windows.Forms.TextBox account_txtbox;
        private System.Windows.Forms.MaskedTextBox id_txtbox;
        private System.Windows.Forms.MaskedTextBox phone_txtbox;
        private System.Windows.Forms.MaskedTextBox password_txtbox;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox balance_txtbox;
        private System.Windows.Forms.Button add_money_bttn;
    }
}