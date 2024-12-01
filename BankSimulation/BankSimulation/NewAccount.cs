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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=BankSimulation;Integrated Security=True");

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            SignIn fr = new SignIn();
            this.Hide();
            fr.Show();
        }
        public int GenerateUniqueNumber(SqlConnection conn)
        {
            Random rnd = new Random();
            int randomNumber;
            bool isUnique = false;

            do
            {
                randomNumber = rnd.Next(100000, 1000000);

                string query = "SELECT COUNT(*) FROM Tbl_Customer WHERE AccountNumber = @p1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", randomNumber);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        isUnique = true;
                    }
                }
            } while (!isUnique);
            return randomNumber;
        }
        void list()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Customer", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Tbl_Account (AccountNumber) values (@p1)", conn);
            cmd1.Parameters.AddWithValue("@p1", account_lbl.Text);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
        private void save_bttn_Click(object sender, EventArgs e)
        {
            if (password_txtbox.Text.Length > 10)
            {
                MessageBox.Show("Password cannot be longer than 10 letters.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_txtbox.Text = "";
                password_txtbox.Focus();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Customer (Name,Surname,ID,PhoneNumber,AccountNumber,Password) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
                int no = GenerateUniqueNumber(conn);
                cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
                cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text);
                cmd.Parameters.AddWithValue("@p3", id_txtbox.Text);
                cmd.Parameters.AddWithValue("@p4", phone_txtbox.Text);
                cmd.Parameters.AddWithValue("@p5", no);
                cmd.Parameters.AddWithValue("@p6", password_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Account created successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                account_lbl.Text = no.ToString();
                list();
            }
        }

        private void save_bttn_MouseEnter(object sender, EventArgs e)
        {
            save_bttn.BackColor = Color.LightBlue;
        }

        private void save_bttn_MouseLeave(object sender, EventArgs e)
        {
            save_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.LightBlue;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void save_bttn_MouseClick(object sender, MouseEventArgs e)
        {
            save_bttn.Enabled = false;
        }
    }
}
