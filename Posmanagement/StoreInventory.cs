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
    public partial class StoreInventory : Form
    {
        public StoreInventory()
        {
            InitializeComponent();
        }

        private void btnStrinvnSupInfo_Click(object sender, EventArgs e)
        {
            Form supInfo = new SupplierInfo();
            supInfo.Show();
        }

        private void btnStrinvnSalesOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnStrinvnSubCat_Click(object sender, EventArgs e)
        {
            Form Subcatobj = new SubCat();
            Subcatobj.Show();
        }

        private void btnStrinvnitmInfo_Click(object sender, EventArgs e)
        {
            Form ItemInfPage = new ItemInfo();
            ItemInfPage.Show();
        }

        private void btnStrinvnPurchaseOrdr_Click(object sender, EventArgs e)
        {
            Form Purchaseobj = new PurchaseOrder();
            Purchaseobj.Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Form objItem = new Item();
            objItem.Show();
        }
    }
}
