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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {

            DataAccess da = new DataAccess();
            string query = "select * from BookTbl";
            DataSet ds = da.ExecuteQuery(query);
            BookDGV.DataSource = ds.Tables[0];

        }
        private void filter()
        {

            DataAccess dataAccess = new DataAccess();
            string query = "select * from BookTbl where BCat='" + cmbUS.SelectedItem.ToString() + "'";
            DataSet ds = dataAccess.ExecuteQuery(query);
            BookDGV.DataSource = ds.Tables[0];

        }
        public void Reset()
        {

            txtBookTitle.Text = "";
            txtAuthor.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            cmbCat.SelectedIndex = -1;

        }

        private void btnUSave_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text == "" || txtAuthor.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || cmbCat.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information !");
            }
            else
            {
                try
                {

                    DataAccess dataAccess = new DataAccess();
                    string query = "insert into BookTbl values('" + txtBookTitle.Text + "','" + txtAuthor.Text + "','" + cmbCat.SelectedItem.ToString() + "','" + txtQuantity.Text + "','" + txtPrice.Text + "')";
                    int result = dataAccess.ExecuteDMLQuery(query);
                    if (result > 0)
                    {
                        MessageBox.Show("Data Inserted !");
                        populate();
                        Reset();
                    }

                        dataAccess.Sqlcon.Close();
                        populate();
                        Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.message");
                }

            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void btnBL_Click(object sender, EventArgs e)
        {
            LogIn obj = new LogIn();
            obj.Show();
            this.Hide();
        }

        private void btnUDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information !");
            }
            else
            {
               
                try
                {

                    DataAccess da = new DataAccess();
                    da.ExecuteDMLQuery("delete from BookTbl where BId=" + key + ";");
                    MessageBox.Show("Data Deleted !");
                    populate();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.message");
                }
            }
        }

        private void btnUEdit_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text == "" || txtAuthor.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || cmbCat.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information !");
            }
            else
            {

                try
                {

                    DataAccess da = new DataAccess();
                    string query = "update BookTbl set BTitle='" + txtBookTitle.Text + "',BAuthor='" + txtAuthor.Text + "',BCat='" + cmbCat.SelectedItem.ToString() + "',BQty='" + txtQuantity.Text + "',BPrice='" + txtPrice.Text + "' where BId='" + key + "';";
                    da.ExecuteDMLQuery(query);
                    MessageBox.Show("Data Updated!");
                    populate();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.message");
                }
            }
        }

        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBookTitle.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtAuthor.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            cmbCat.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtQuantity.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtPrice.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();


            if (txtBookTitle.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void cmbUS_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void btnUReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
            cmbUS.SelectedItem = -1;
        }
    }
}
