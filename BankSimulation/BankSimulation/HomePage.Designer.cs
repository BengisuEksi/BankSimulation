namespace BankSimulation
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullname_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date_lbl = new System.Windows.Forms.Label();
            this.new_transfer_bttn = new System.Windows.Forms.Button();
            this.myaccount_bttn = new System.Windows.Forms.Button();
            this.sign_out_bttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.view_transfers_bttn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bank_balance_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.ForeColor = System.Drawing.Color.Navy;
            this.exit_bttn.Location = new System.Drawing.Point(872, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 6;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(518, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome, ";
            // 
            // fullname_lbl
            // 
            this.fullname_lbl.AutoSize = true;
            this.fullname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fullname_lbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullname_lbl.Location = new System.Drawing.Point(625, 41);
            this.fullname_lbl.Name = "fullname_lbl";
            this.fullname_lbl.Size = new System.Drawing.Size(104, 25);
            this.fullname_lbl.TabIndex = 8;
            this.fullname_lbl.Text = "full name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(359, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 362);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.Transparent;
            this.date_lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_lbl.Location = new System.Drawing.Point(12, 28);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(39, 19);
            this.date_lbl.TabIndex = 10;
            this.date_lbl.Text = "null";
            // 
            // new_transfer_bttn
            // 
            this.new_transfer_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_transfer_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.new_transfer_bttn.Location = new System.Drawing.Point(58, 57);
            this.new_transfer_bttn.Name = "new_transfer_bttn";
            this.new_transfer_bttn.Size = new System.Drawing.Size(219, 38);
            this.new_transfer_bttn.TabIndex = 11;
            this.new_transfer_bttn.Text = "Make a New Transfer";
            this.new_transfer_bttn.UseVisualStyleBackColor = true;
            this.new_transfer_bttn.Click += new System.EventHandler(this.new_transfer_bttn_Click);
            this.new_transfer_bttn.MouseEnter += new System.EventHandler(this.new_transfer_bttn_MouseEnter);
            this.new_transfer_bttn.MouseLeave += new System.EventHandler(this.new_transfer_bttn_MouseLeave);
            // 
            // myaccount_bttn
            // 
            this.myaccount_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myaccount_bttn.Location = new System.Drawing.Point(51, 80);
            this.myaccount_bttn.Name = "myaccount_bttn";
            this.myaccount_bttn.Size = new System.Drawing.Size(219, 38);
            this.myaccount_bttn.TabIndex = 12;
            this.myaccount_bttn.Text = "My Account";
            this.myaccount_bttn.UseVisualStyleBackColor = true;
            this.myaccount_bttn.Click += new System.EventHandler(this.myaccount_bttn_Click);
            this.myaccount_bttn.MouseEnter += new System.EventHandler(this.myaccount_bttn_MouseEnter);
            this.myaccount_bttn.MouseLeave += new System.EventHandler(this.myaccount_bttn_MouseLeave);
            // 
            // sign_out_bttn
            // 
            this.sign_out_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_out_bttn.Location = new System.Drawing.Point(51, 131);
            this.sign_out_bttn.Name = "sign_out_bttn";
            this.sign_out_bttn.Size = new System.Drawing.Size(219, 38);
            this.sign_out_bttn.TabIndex = 13;
            this.sign_out_bttn.Text = "Sign Out";
            this.sign_out_bttn.UseVisualStyleBackColor = true;
            this.sign_out_bttn.Click += new System.EventHandler(this.sign_out_bttn_Click);
            this.sign_out_bttn.MouseEnter += new System.EventHandler(this.sign_out_bttn_MouseEnter);
            this.sign_out_bttn.MouseLeave += new System.EventHandler(this.sign_out_bttn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "My Bank Balance: ";
            // 
            // view_transfers_bttn
            // 
            this.view_transfers_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_transfers_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view_transfers_bttn.Location = new System.Drawing.Point(58, 111);
            this.view_transfers_bttn.Name = "view_transfers_bttn";
            this.view_transfers_bttn.Size = new System.Drawing.Size(219, 38);
            this.view_transfers_bttn.TabIndex = 16;
            this.view_transfers_bttn.Text = "View Transfer History";
            this.view_transfers_bttn.UseVisualStyleBackColor = true;
            this.view_transfers_bttn.Click += new System.EventHandler(this.view_transfers_bttn_Click);
            this.view_transfers_bttn.MouseEnter += new System.EventHandler(this.view_transfers_bttn_MouseEnter);
            this.view_transfers_bttn.MouseLeave += new System.EventHandler(this.view_transfers_bttn_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.new_transfer_bttn);
            this.groupBox2.Controls.Add(this.view_transfers_bttn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 197);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.bank_balance_lbl);
            this.groupBox3.Controls.Add(this.myaccount_bttn);
            this.groupBox3.Controls.Add(this.sign_out_bttn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 197);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account";
            // 
            // bank_balance_lbl
            // 
            this.bank_balance_lbl.AutoSize = true;
            this.bank_balance_lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bank_balance_lbl.Location = new System.Drawing.Point(194, 41);
            this.bank_balance_lbl.Name = "bank_balance_lbl";
            this.bank_balance_lbl.Size = new System.Drawing.Size(45, 19);
            this.bank_balance_lbl.TabIndex = 16;
            this.bank_balance_lbl.Text = "0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(423, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 56);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fullname_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_bttn);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fullname_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Button new_transfer_bttn;
        private System.Windows.Forms.Button myaccount_bttn;
        private System.Windows.Forms.Button sign_out_bttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button view_transfers_bttn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label bank_balance_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}