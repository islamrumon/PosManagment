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

namespace Posmanagement
{
    public partial class Item : Form
    {
        string ConnStr = Posmanagement.dbClass.Getconnection();
        public Item()
        {
            InitializeComponent();
        }

        private void btnItemSubmit_Click(object sender, EventArgs e)
        {
            if (isFillAl())
            {
                try
                {
                    string sql_insert = "insert into Item values('" + txtItemID.Text + "','" + txtItemName.Text + "')";

                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool isFillAl()
        {
            if (txtItemID.Text == "" || txtItemName.Text == "")
            {
                MessageBox.Show("Required Fields", "Required", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            if (isFillAl())
            {
                try
                {
                    string sql_insert = "update Item set ItemName='" + txtItemName.Text + "' where ItemID='" + txtItemID.Text + "'";

                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text == "")
            {
                MessageBox.Show("Enter ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string sql_insert = "delete from Item where ItemID='" + txtItemID.Text + "'";

                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch
                {
                    MessageBox.Show("Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            showGrid();
        }
        public void showGrid()
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            DataTable dt = new DataTable();

            string strCmd = "select * from Item";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(strCmd, conn);
            //sda.Fill(dt);
            DGBitem.DataSource = dt;
            sda.Fill(dt);
            DGBitem.DataSource = dt;
            conn.Close();
        }
    }
    
}
