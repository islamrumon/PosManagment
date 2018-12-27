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
using System.Configuration;
using System.IO;

namespace Posmanagement
{
    public partial class Registration : Form
    {
        string ConnStr = Posmanagement.dbClass.Getconnection();
        string Gender;
        char checkstore='N',checksale = 'N', checkreport = 'N', checkcrm = 'N';
        string imagefile;
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (isFillAll())
            {
                if (ChkBStore.Checked == true)
                {
                    checkstore = 'Y';
                }
                
                if (ChkBSale.Checked == true)
                {
                    checksale = 'Y';
                }
                
                if (ChkBReport.Checked == true)
                {
                    checkreport = 'Y';
                }
                
                if (ChkBCrm.Checked == true)
                {
                    checkcrm = 'Y';
                }


                //start checkbox
                /*string str = "";
                if (chkBListAccess.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < chkBListAccess.CheckedItems.Count; i++)
                    {
                        if (str == "")
                        {
                            str = chkBListAccess.CheckedItems[i].ToString();
                        }
                        else
                        {
                            str += "," + chkBListAccess.CheckedItems[i].ToString();
                        }
                    }
                }*/
                //end checkbox
                try
                {
                    FileStream fs = new FileStream(@imagefile, FileMode.Open, FileAccess.Read);
                    byte[] img = new byte[Convert.ToInt32(fs.Length)]; //a byte array to read the image
                    fs.Read(img, 0, Convert.ToInt32(fs.Length));

                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand("insert into Registration (empID,empName,password,type,Gender,store,sale,report,crm,companyName,empImage) Values('" + txtempID.Text + "', '" + txtempName.Text + "','" + txtpass.Text + "','" + CMBType.Text + "','" + Gender + "','" + checkstore + "','" + checksale + "','" + checkreport + "','" + checkcrm + "','" + CMBComName.Text + "'," + " @photo)", conn);

                    conn.Open();

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "photo";
                    param.Value = img;

                    cmd.Parameters.AddWithValue("@photo", img);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added","Seccess",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Not Added","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private bool isFillAll()
        {
            if (txtempName.Text == "" || txtempID.Text == "" || txtpass.Text=="" || CMBType.Text == "" || CMBComName.Text=="")
            {
                MessageBox.Show("Please Fill up all fields.","Required",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearField();
        }
        public void ClearField()
        {
            txtempName.Text = "";
            txtempID.Text = "";
            txtpass.Text = "";
            CMBType.Text = "";
            CMBComName.Text = "";
            ChkBStore.Checked = false;
            ChkBSale.Checked = false;
            ChkBReport.Checked = false;
            ChkBCrm.Checked = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtempID.Text == "")
            {
                MessageBox.Show("Enter ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConnStr);
                SqlCommand cmd = new SqlCommand("delete from Registration where empID='"+txtempID.Text+"' ", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnRegBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose an image....";
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "JPEG (.jpeg;.jpg)|*.jpg;*.jpeg|Bitmap Files (.bmp)|.bmp|GIF Files(.gif)|.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagefile = openFileDialog1.FileName;
                PBemp.ImageLocation = imagefile;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand("select ComName from Company",conn);

            CMBComName.Items.Clear();
            conn.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CMBComName.Items.Add(dr["ComName"].ToString());
            }
            conn.Close();
        }

        private void RadioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void RadioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }
    }
}
