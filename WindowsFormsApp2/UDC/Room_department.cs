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
    public partial class Room_department : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_department()
        {
            InitializeComponent();
            papper_4.BackColor = Color.Transparent;
            papper_4.Parent = room_office;
        }

        public Room_department(ControlConversationUDC controller)
        {
            InitializeComponent();
            papper_4.BackColor = Color.Transparent;
            papper_4.Parent = room_office;
            this.controller = controller;
        }

        public void Key4_Click(object sender, EventArgs e)
        {
            // 단서 Papper3 함수 _ 클릭 이벤트 발생시
            mPapper4 = true;
            inventory_set();
            papper_4.Visible = false;
            (this.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
        }

    }
}
