using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WindowsFormsApp2.StaticItem;

namespace WindowsFormsApp2.UDC
{
    public partial class Room_lab3 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_lab3(ControlConversationUDC controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        public void Test3_Click(object sender, EventArgs e)
        {
            // 단서 Printer1 함수 _ 클릭 이벤트 발생시
            if (!mTest3)
            {
                mTest3 = true;
                inventory_set();
                (this.Parent.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
                controller.Test3Get1();
            }
        }
    }
}
