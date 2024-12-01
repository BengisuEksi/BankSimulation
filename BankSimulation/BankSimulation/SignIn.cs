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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=BankSimulation;Integrated Security=True");
        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.LightBlue;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void signint_bttn_MouseEnter(object sender, EventArgs e)
        {
            signint_bttn.BackColor = Color.LightBlue;
        }

        private void signint_bttn_MouseLeave(object sender, EventArgs e)
        {
            signint_bttn.BackColor = Color.Transparent;
        }

        private void signup_lbl_MouseEnter(object sender, EventArgs e)
        {
            signup_lbl.BackColor = Color.LightBlue;
        }

        private void signup_lbl_MouseLeave(object sender, EventArgs e)
        {
            signup_lbl.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void signint_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Customer where AccountNumber = @p1 and Password = @p2", conn);
            cmd.Parameters.AddWithValue("@p1", accountno_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", password_txtbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                HomePage fr = new HomePage();
                this.Hide();
                fr.full_name = dr[1].ToString() + " " + dr[2].ToString();
                fr.account = dr[5].ToString();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Invalid account number or password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accountno_txtbox.Text = "";
                password_txtbox.Text = "";
                accountno_txtbox.Focus();
            }
            conn.Close();
        }

        private void signup_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount fr = new NewAccount();
            this.Hide();
            fr.Show();
        }
    }
}
