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
    public partial class Billing : Form
    {
        public Billing()
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
        int key = 0, stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookName.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            //QtyTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            // BCatCb.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            //QtyTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtUBP.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (txtBookName.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void updateBook()
        {
            int newQty = stock - Convert.ToInt32(txtUBQ.Text);

            try
            {

                DataAccess dataAccess = new DataAccess();
                string query = "update BookTbl set BQty='" + newQty + "' where BId='" + key + "';";
                dataAccess.ExecuteDMLQuery(query);
                //MessageBox.Show("Data Updated!");
                populate();
                Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ex.message");
            }
        }

        int n = 0, Grdtotal = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (txtUBQ.Text == "" || Convert.ToInt32(txtUBQ.Text) > stock)
            {
                MessageBox.Show("Out of Stock");
            }
            else
            {

                int total = Convert.ToInt32(txtUBQ.Text) * Convert.ToInt32(txtUBP.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtBookName.Text;
                newRow.Cells[2].Value = txtUBQ.Text;
                newRow.Cells[3].Value = txtUBP.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                updateBook();
                Grdtotal = Grdtotal + total;
                Totalbil.Text = "Taka. " + Grdtotal;
            }
        }

        private void btnUBReseT_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Reset()
        {

            txtBookName.Text = "";
            txtUBQ.Text = "";
            txtUBP.Text = "";


        }
        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            LogIn obj = new LogIn();
            obj.Show();
            this.Hide();
        }
    }
}
