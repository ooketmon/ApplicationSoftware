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
    public partial class Room_lab1 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_lab1(ControlConversationUDC controller)
        {
            InitializeComponent();

            Printer_1.BackColor = Color.Transparent;
            Printer_1.Parent = lab1;
            this.controller = controller;
        }

        public void Printer1_Click(object sender, EventArgs e) 
        {
            if (!mTest1) {
                // 단서 Printer1 함수 _ 클릭 이벤트 발생시
                mTest1 = true;
                inventory_set();
                (this.Parent.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
                (this.Parent.Parent as InitMenu).CheckTestComplete();
                controller.Test1Get1();
            }
        }

    }
}
