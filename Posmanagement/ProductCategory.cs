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
    public partial class ProductCategory : Form
    {
        string ConnStr = Posmanagement.dbClass.Getconnection();
        public ProductCategory()
        {
            InitializeComponent();
        }

        private void btnCatSubmit_Click(object sender, EventArgs e)
        {
            if (isFillAll())
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand("insert into ProCategory(CateID,CateName) values('" + txtCatID.Text+"','"+txtCatName.Text+"')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearAll()
        {
            txtCatID.Text = "";
            txtCatName.Text = "";
        }
        private bool isFillAll()
        {
            if (txtCatID.Text==""||txtCatName.Text=="")
            {
                MessageBox.Show("Please Fill up all fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCatDel_Click(object sender, EventArgs e)
        {
            if(txtCatID.Text=="")
            {
                MessageBox.Show("Please Enter ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand("delete from ProCategory where CateID='"+txtCatID.Text+"'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowGrid()
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            DataTable dt = new DataTable();

            try
            {
                string strCmd = "select * from ProCategory";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(strCmd, conn);
                sda.Fill(dt);
                DGBCat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCatShow_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void btnCatSearch_Click(object sender, EventArgs e)
        {
            if (txtCatsrc.Text == "")
            {
                MessageBox.Show("Enter Keyword", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConnStr);
                DataTable dt = new DataTable();

                try
                {
                    string strCmd = "SELECT * FROM ProCategory WHERE CateID='" + txtCatsrc.Text+ "' or CateName='"+txtCatsrc.Text+"' ";
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(strCmd, conn);
                    sda.Fill(dt);
                    DGBCat.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
