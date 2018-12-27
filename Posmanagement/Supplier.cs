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
    public partial class Supplier : Form
    {
        string ConnStr = Posmanagement.dbClass.Getconnection();
        public Supplier()
        {
            InitializeComponent();
        }

        private void btnSupplierSubmit_Click(object sender, EventArgs e)
        {
            if (isFillAl())
            {
                try
                {
                    string sql_insert = "insert into Supplier(SupplierID,SupplierName,SupplierMail,SupplierPhone,SupplierAddress,SupplierCily) values('" + txtSupplierID.Text + "','" + txtSupplierName.Text + "','" + txtSupplierMail.Text + "','" + txtSupplierPhone.Text + "','" + txtSupplieraddress.Text + "','" + CMBSupplierCity.Text + "')";
                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isFillAl()
        {
            if (txtSupplierID.Text == "" || txtSupplierMail.Text == "" || txtSupplierPhone.Text == "")
            {
                MessageBox.Show("Required Fields", "Required", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSupplierUpdate_Click(object sender, EventArgs e)
        {
            if (isFillAl())
            {
                try
                {
                    string sql_insert = "update Supplier set SupplierName='"+txtSupplierName.Text+"',SupplierMail='"+txtSupplierMail.Text+"',SupplierPhone='"+txtSupplierPhone.Text+"',SupplierAddress='"+txtSupplieraddress.Text+"',SupplierCily='"+CMBSupplierCity.Text+ "' where SupplierID='" + txtSupplierID.Text + "')";
                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupplierDel_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text == "")
            {
                MessageBox.Show("Enter ID", "Required", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string sql_insert = "delete from Supplier where SupplierID='" + txtSupplierID.Text + "' ";

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

        private void clearAll()
        {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtSupplierMail.Text = "";
            txtSupplieraddress.Text = "";
            txtSupplierPhone.Text = "";
            CMBSupplierCity.Text = "";
        }

        private void btnSuplierNew_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSupplierShow_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void ShowGrid()
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            DataTable dt = new DataTable();

            string strCmd = "select * from Supplier";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(strCmd, conn);
            DGBSupplier.DataSource = dt;
            sda.Fill(dt);
            conn.Close();
        }
    }
}
