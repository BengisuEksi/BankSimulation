using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSimulation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public string full_name;
        public string account;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=BankSimulation;Integrated Security=True");
        private void HomePage_Load(object sender, EventArgs e)
        {
            fullname_lbl.Text = full_name;
            date_lbl.Text = DateTime.Now.ToString("d");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Balance from Tbl_Account where AccountNumber = @p1", conn);
            cmd.Parameters.AddWithValue("@p1",account);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bank_balance_lbl.Text = dr[0].ToString();
            }
            conn.Close();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit the application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { ; }
        }

        private void new_transfer_bttn_MouseEnter(object sender, EventArgs e)
        {
            new_transfer_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void new_transfer_bttn_MouseLeave(object sender, EventArgs e)
        {
            new_transfer_bttn.BackColor = Color.Transparent;
        }

        private void view_transfers_bttn_MouseEnter(object sender, EventArgs e)
        {
            view_transfers_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void view_transfers_bttn_MouseLeave(object sender, EventArgs e)
        {
            view_transfers_bttn.BackColor = Color.Transparent;
        }

        private void myaccount_bttn_MouseEnter(object sender, EventArgs e)
        {
            myaccount_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void myaccount_bttn_MouseLeave(object sender, EventArgs e)
        {
            myaccount_bttn.BackColor = Color.Transparent;
        }

        private void sign_out_bttn_MouseEnter(object sender, EventArgs e)
        {
            sign_out_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void sign_out_bttn_MouseLeave(object sender, EventArgs e)
        {
            sign_out_bttn.BackColor = Color.Transparent;
        }

        private void myaccount_bttn_Click(object sender, EventArgs e)
        {
            MyAccount fr = new MyAccount();
            this.Hide();
            fr.account = account;
            fr.full_name = full_name;
            fr.Show();
        }

        private void sign_out_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to sign out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SignIn fr = new SignIn();
                this.Hide();
                fr.Show();
            }
        }

        private void new_transfer_bttn_Click(object sender, EventArgs e)
        {
            NewTransfer fr = new NewTransfer();
            this.Hide();
            fr.money_sender = account;
            fr.Show();
        }

        void list_transfer()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Tbl_Transaction.ID, (SenderPeople.Name + ' ' + SenderPeople.Surname) as Sender,(ReceiverPeople.Name + ' ' + ReceiverPeople.Surname) as Receiver,Amount from Tbl_Transaction \r\ninner join Tbl_Customer as SenderPeople\r\non Tbl_Transaction.Sender = SenderPeople.AccountNumber\r\ninner join Tbl_Customer as ReceiverPeople\r\non Tbl_Transaction.Receiver = ReceiverPeople.AccountNumber where Sender =" + account + "OR Receiver =" + account,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void view_transfers_bttn_Click(object sender, EventArgs e)
        {
            list_transfer();
        }
    }
}
