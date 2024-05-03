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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDBooks_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void btnDUsers_Click(object sender, EventArgs e)
        {

            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void btnDLogout_Click(object sender, EventArgs e)
        {
            LogIn obj = new LogIn();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            string sql = "select sum(BQTy) from BookTbl";
            DataTable dt = dataAccess.ExecuteQueryTable(sql);
            TotalBooks.Text = dt.Rows[0][0].ToString();




            DataAccess da = new DataAccess();
            DataTable dt2 = da.ExecuteQueryTable("select count(*) from UserTbl");
            Totaluser.Text = dt2.Rows[0][0].ToString();
            da.Sqlcon.Close();
        }
    }
}
