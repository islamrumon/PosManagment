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
    public partial class frmLogin : Form
    {
        string ConnStr = Posmanagement.dbClass.Getconnection();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form reg = new Registration();
            reg.ShowDialog();
        }

        private void CheckLogin()
        {
            if (isFillAllLog())
            {
                SqlConnection conn = new SqlConnection(ConnStr);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Registration where empName='"+txtemail.Text+"' and password='"+txtpassword.Text+"'", conn);
                DataTable dt = new DataTable();
                
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    //string user = dt.Rows[0].ItemArray[1].ToString();
                    //string pass = dt.Rows[0].ItemArray[2].ToString();
                    //string typ = dt.Rows[0].ItemArray[3].ToString();
                    //if (user == txtemail.Text && pass == txtpassword.Text)
                    //{
                        this.Hide();
                        Form dash = new Dashboard(/*dt.Rows[0]["empID"].ToString(), dt.Rows[0]["empName"].ToString(), dt.Rows[0]["type"].ToString()*/);
                        dash.Show();
                    //}
                    //else
                    //{
                        //MessageBox.Show("Check user & password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    MessageBox.Show("Check user & password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
        }

        private bool isFillAllLog()
        {
            if (txtemail.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please Fill The All Fields", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnlogn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CBshowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CBshowPass.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }
    }
}
