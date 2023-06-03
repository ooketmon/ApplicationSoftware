using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class inventory_item : UserControl
    {
        public inventory_item()
        {
            InitializeComponent();
        }

        private void btn_iclose_Click(object sender, EventArgs e)
        {
            (this.Parent as Inventory).CancelMaximize();
        }

        public void setMainItem(Image resourceName)
        {
           
            pic_Item.BackgroundImage = resourceName;
        }

    }
}
