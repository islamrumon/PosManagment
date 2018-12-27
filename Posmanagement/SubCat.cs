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
    public partial class SubCat : Form
    {
        public SubCat()
        {
            InitializeComponent();
        }

        private void btnSubCatCrNew_Click(object sender, EventArgs e)
        {
            Form SubCatCreateNewobj = new SubcatCreates();
            SubCatCreateNewobj.Show();
        }
    }
}
