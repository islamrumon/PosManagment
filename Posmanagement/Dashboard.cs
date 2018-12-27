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
    public partial class Dashboard : Form
    {
        string ConnStr = Posmanagement.dbClass.Getconnection();
        string tp;
        public Dashboard(/*string uID,string uname,string utype*/)
        {
            InitializeComponent();
            //tp = utype;
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCRM_Click(object sender, EventArgs e)
        {
            Form crm = new CRM();
            crm.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnstrinventory_Click(object sender, EventArgs e)
        {
            Form storInven = new StoreInventory();
            storInven.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form objReg = new Registration();
            objReg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form objMaster = new MasterData();
            objMaster.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();
            string access = "select * from Registration ";
            SqlDataAdapter cmd = new SqlDataAdapter(access, conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            
            if (tp==dt.Rows[0]["type"].ToString())
            {
                btnAdmin.Visible = true;
                btnstrinventory.Visible = true;
                btnSale.Visible = true;
                btnReport.Visible = true;
                btnCRM.Visible = true;
                btnmaster.Visible = true;
            }
            conn.Close();

        }
    }
}
