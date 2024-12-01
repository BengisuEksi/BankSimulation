using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSimulation
{
    public partial class NewTransfer : Form
    {
        public NewTransfer()
        {
            InitializeComponent();
        }
        public string money_sender;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=BankSimulation;Integrated Security=True");
        private void NewTransfer_Load(object sender, EventArgs e)
        {
            sender_txtbox.Text = money_sender;
        }

        private void transfer_bttn_Click(object sender, EventArgs e)
        {
            decimal money = 0;
            conn.Open();
            SqlCommand cmd0 = new SqlCommand("Select Balance from Tbl_Account where AccountNumber = @p1", conn);
            cmd0.Parameters.AddWithValue("@p1", money_sender);
            SqlDataReader dr = cmd0.ExecuteReader();
            if (dr.Read())
            {
                money = decimal.Parse(dr[0].ToString());
            }
            conn.Close();

            decimal amount = decimal.Parse(amount_txtbox.Text);
            if(money > amount)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Transaction (Sender,Receiver,Amount) values (@p1,@p2,@p3)", conn);
                cmd.Parameters.AddWithValue("@p1", money_sender);
                cmd.Parameters.AddWithValue("@p2", receiver_txtbox.Text);
                cmd.Parameters.AddWithValue("@p3", amount);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Transfer is completed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Receiver's money
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Update Tbl_Account set Balance = Balance + @p1 where AccountNumber = @p2", conn);
                cmd1.Parameters.AddWithValue("@p1", amount);
                cmd1.Parameters.AddWithValue("@p2", receiver_txtbox.Text);
                cmd1.ExecuteNonQuery();
                conn.Close();

                // Sender's money
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("Update Tbl_Account set Balance = Balance - @p1 where AccountNumber = @p2", conn);
                cmd2.Parameters.AddWithValue("@p1", amount);
                cmd2.Parameters.AddWithValue("@p2", sender_txtbox.Text);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("You do not have enough balance for the transfer.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                amount_txtbox.Text = "";
                amount_txtbox.Focus();
            }

        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void transfer_bttn_MouseEnter(object sender, EventArgs e)
        {
            transfer_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void transfer_bttn_MouseLeave(object sender, EventArgs e)
        {
            transfer_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Customer where AccountNumber =" + money_sender,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                HomePage fr = new HomePage();
                this.Hide();
                fr.account = money_sender;
                fr.full_name = dr[1].ToString() + " " + dr[2].ToString();
                fr.Show();
            }
            conn.Close();
        }
    }
}
