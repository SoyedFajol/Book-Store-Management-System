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

namespace Book_Shop_Management_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        public static string User = "";
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" || txtPassword.Text == "admin555")
            {
                Books obj = new Books();
                obj.Show();
                this.Hide();
            }


            else if (txtUsername.Text == "" || txtPassword.Text == "admin")
            {
                MessageBox.Show("Invalid User or Password !");
            }
            else
            {

                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable("select count(*) From UserTbl where UName='" + txtUsername.Text + "' and UPass='" + txtPassword.Text + "'");
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = txtUsername.Text;
                    Billing obj = new Billing();
                    obj.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid User or Password !");
                }

            }
        }

    }
}

