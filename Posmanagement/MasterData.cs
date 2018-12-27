using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posmanagement
{
    public partial class MasterData : Form
    {
        public MasterData()
        {
            InitializeComponent();
        }

        private void btnMasterCom_Click(object sender, EventArgs e)
        {
            Form objCompany = new company();
            objCompany.Show();
        }

        private void btnMasterProCate_Click(object sender, EventArgs e)
        {
            Form objCategory = new ProductCategory();
            objCategory.Show();
        }

        private void btnMasterPro_Click(object sender, EventArgs e)
        {
            Form objitem = new ItemInfo();
            objitem.Show();
        }

        private void btnMasterVendor_Click(object sender, EventArgs e)
        {
            Form objVendor = new AddNewVendor();
            objVendor.Show();
        }

        private void btnMasterItem_Click(object sender, EventArgs e)
        {
            Form objitem = new Item();
            objitem.Show();
        }

        private void btnMasterSupplier_Click(object sender, EventArgs e)
        {
            Form objSupplier = new Supplier();
            objSupplier.Show();
        }
    }
}
