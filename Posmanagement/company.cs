using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Posmanagement
{
    public partial class company : Form
    {
        string ConnStr = Posmanagement.dbClass.Getconnection();
        public company()
        {
            InitializeComponent();
        }

        string imagefile;
        OpenFileDialog opn = new OpenFileDialog();
        private void btnComBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose an image....";
            openFileDialog1.InitialDirectory= @"c:\";
            openFileDialog1.Filter = "JPEG (.jpeg;.jpg)|*.jpg;*.jpeg|Bitmap Files (.bmp)|.bmp|GIF Files(.gif)|.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagefile = openFileDialog1.FileName;
                PBcom.ImageLocation = imagefile;
            }

            /*OpenFileDialog opn = new OpenFileDialog();
            opn.InitialDirectory = "C:\\";
            opn.Filter = "JPEG (.jpeg;.jpg)|*.jpg;*.jpeg|Bitmap Files (.bmp)|.bmp|GIF Files(.gif)|.gif";
            opn.FilterIndex = 1;

            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (opn.CheckFileExists)
                {
                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(opn.FileName, paths + "\\image\\aaa.jpg");

                }
            }*/
        }

        private void photoInsert()
        {// coding for inserting picture into database
            try
            {
                FileStream fs = new FileStream(@imagefile, FileMode.Open, FileAccess.Read);
                byte[] img = new byte[Convert.ToInt32(fs.Length)]; //a byte array to read the image
                fs.Read(img, 0, Convert.ToInt32(fs.Length));
                string sql_insert = "insert into Company(ComID,ComName,ComEmail,ComPhone,ComAddress,ComContry,ComImage) values('" + txtComID.Text + "','" + txtComName.Text + "','" + txtComMail.Text + "','" + txtComPhone.Text + "','" + txtComaddress.Text + "','" + CMBcomCountry.Text + "'," + " @photo)";

                SqlConnection conn = new SqlConnection(ConnStr);
                SqlCommand cmd = new SqlCommand(sql_insert, conn);

                conn.Open();

                SqlParameter param = new SqlParameter();
                param.ParameterName = "photo";
                param.Value = img;

                cmd.Parameters.AddWithValue("@photo", img);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted Successfully");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /*private void photoInsert()
        {// coding for inserting picture into database
            try
            {
                string imgPath = "image\\" + imagefile;
                string sql_insert = "insert into Company(ComID, ComName, ComEmail, ComPhone, ComAddress, ComContry, ComImage) values('" + txtComID.Text + "','" + txtComName.Text + "','" + txtComMail.Text + "','" + txtComPhone.Text + "','" + txtComaddress.Text + "','" + CMBcomCountry.Text + "'," + " imagepath)";

                SqlConnection conn = new SqlConnection(ConnStr);
                SqlCommand cmd = new SqlCommand(sql_insert, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void btnComSubmit_Click(object sender, EventArgs e)
        {
            if (isFillAl())
            {
                photoInsert();
            }
        }

        private bool isFillAl()
        {
            if (txtComID.Text == "" || txtComMail.Text == "" || txtComName.Text == "")
            {
                MessageBox.Show("Required Fields","Required",MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtComID.Text = "";
            txtComName.Text = "";
            txtComaddress.Text = "";
            txtComMail.Text = "";
            txtComPhone.Text = "";
            CMBcomCountry.Text = "";
        }

        private void btnComDel_Click(object sender, EventArgs e)
        {
            if (txtComID.Text == "")
            {
                MessageBox.Show("Enter ID", "Required", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string sql_insert = "delete from Company where ComID='"+txtComID.Text+"' ";

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

        private void btnComUpdate_Click(object sender, EventArgs e)
        {
            if (isFillAl())
            {
                try
                {
                    FileStream fs = new FileStream(@imagefile, FileMode.Open, FileAccess.Read);
                    byte[] img = new byte[Convert.ToInt32(fs.Length)]; //a byte array to read the image
                    fs.Read(img, 0, Convert.ToInt32(fs.Length));

                    string sql_insert = "update Company set ComID = '"+txtComID.Text+"', ComName = '"+txtComName.Text+"', ComEmail = '"+txtComMail.Text+"', ComPhone = '"+txtComPhone.Text+"', ComAddress = '"+txtComaddress.Text+"', ComContry = '"+CMBcomCountry.Text+ "', ComImage = '" + " @photo' where ComID = '" + txtComID.Text + "'";

                    SqlConnection conn = new SqlConnection(ConnStr);
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);

                    conn.Open();

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "photo";
                    param.Value = img;

                    cmd.Parameters.AddWithValue("@photo", img);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Not Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCatShow_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void ShowGrid()
        {
            //int i=0;
            SqlConnection conn = new SqlConnection(ConnStr);
            DataTable dt = new DataTable();

                string strCmd = "select * from Company";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(strCmd, conn);
                //sda.Fill(dt);
                DGBProCat.DataSource = dt;
            
            //DataTable table = new DataTable();
            DGBProCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGBProCat.RowTemplate.Height = 100;
            DGBProCat.AllowUserToAddRows = false;
            sda.Fill(dt);
            DGBProCat.DataSource = dt;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DGBProCat.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            sda.Dispose();

            /*Bitmap img;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol.HeaderText = "Image";
            imgcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgcol.Width = 100;
            DGBProCat.Columns.Add(imgcol);
            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["Image"].ToString());
                DGBProCat.Rows[i].Cells[5].Value = img;
                DGBProCat.Rows[i].Height = 100;
                i = i + 1;
            }*/
            conn.Close();
        }
    }
}
