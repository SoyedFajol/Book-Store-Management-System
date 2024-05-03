﻿using System;
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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {

            DataAccess da = new DataAccess();
            string query = "select * from UserTbl";
            DataSet ds = da.ExecuteQuery(query);
            UserDGV.DataSource = ds.Tables[0];

        }
        public void Reset()
        {

            username.Text = "";
            phone.Text = "";
            address.Text = "";
            password.Text = "";

        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || phone.Text == "" || address.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing Information !");
            }
            else
            {

                try
                {
                    DataAccess dataAccess = new DataAccess();
                    string query = "insert into UserTbl values('" + username.Text + "','" + phone.Text + "','" + address.Text + "','" + password.Text + "')";
                    int rowsAffected = dataAccess.ExecuteDMLQuery(query);
                    MessageBox.Show("Data Inserted !");
                    populate();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.message");
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    da.Sqlcon.Open();
                    string query = "delete from UserTbl where UId=" + key + ";";
                    int rowsAffected = da.ExecuteDMLQuery(query);
                    da.Sqlcon.Close();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || phone.Text == "" || address.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing Information !");
            }
            else
            {

                try
                {
                    DataAccess da = new DataAccess();
                    string query = "update UserTbl set UName='" + username.Text + "',UPhone='" + phone.Text + "',UAdd='" + address.Text + "',UPass='" + password.Text + "' where UId='" + key + "';";
                    da.ExecuteDMLQuery(query);
                    MessageBox.Show("Data Updated!");
                    da.Sqlcon.Close();
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
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            username.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            phone.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            address.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            password.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();


            if (username.Text == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn obj = new LogIn();
            obj.Show();
            this.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
