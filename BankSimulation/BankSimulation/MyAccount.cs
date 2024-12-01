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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }
        public string account;
        public string full_name;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=BankSimulation;Integrated Security=True");
        private void back_bttn_Click(object sender, EventArgs e)
        {
            HomePage fr = new HomePage();
            this.Hide();
            fr.account = account;
            fr.full_name = name_txtbox.Text + " " + surname_txtbox.Text;
            fr.Show();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Customer where AccountNumber = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", account);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name_txtbox.Text = dr[1].ToString();
                surname_txtbox.Text = dr[2].ToString();
                id_txtbox.Text = dr[3].ToString();
                phone_txtbox.Text = dr[4].ToString();
                account_txtbox.Text = account.ToString();
                password_txtbox.Text = dr[6].ToString();
            }
            conn.Close();

            list_balance();
        }
        void list_customer()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Customer", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            if(password_txtbox.Text.Length > 10)
            {
                MessageBox.Show("Check your information.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_Customer set Name=@p1,Surname=@p2,ID=@p3,PhoneNumber=@p4,Password=@p5 where AccountNumber = @p6", conn);
                cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
                cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text);
                cmd.Parameters.AddWithValue("@p3", id_txtbox.Text);
                cmd.Parameters.AddWithValue("@p4", phone_txtbox.Text);
                cmd.Parameters.AddWithValue("@p5", password_txtbox.Text);
                cmd.Parameters.AddWithValue("@p6", account);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your information is updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list_customer();
            }

        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete your account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Tbl_Customer where AccountNumber = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", account_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                list_customer();

                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Delete from Tbl_Account where AccountNumber=" + account_txtbox.Text, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Your account is deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignIn fr = new SignIn();
                this.Hide();
                fr.Show();
            }
            else
            {
                ;
            }
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void update_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void update_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Transparent;
        }

        private void delete_bttn_MouseEnter(object sender, EventArgs e)
        {
            delete_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void delete_bttn_MouseLeave(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void list_balance()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Balance from Tbl_Account where AccountNumber = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", account);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                balance_txtbox.Text = dr[0].ToString();
            }
            conn.Close();
        }
        private void add_money_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Account set Balance = @p1 from Tbl_Account inner join Tbl_Customer on Tbl_Account.AccountNumber = Tbl_Customer.AccountNumber where Tbl_Account.AccountNumber = @p2", conn);
            cmd.Parameters.AddWithValue("@p1", balance_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", account_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your balance amount is updated.", "", MessageBoxButtons.OK);
            list_balance();
        }

        private void add_money_bttn_MouseEnter(object sender, EventArgs e)
        {
            add_money_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void add_money_bttn_MouseLeave(object sender, EventArgs e)
        {
            add_money_bttn.BackColor = Color.Transparent;
        }
    }
}
