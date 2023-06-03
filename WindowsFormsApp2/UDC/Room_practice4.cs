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
    public partial class Room_practice4 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_practice4(ControlConversationUDC controller)
        {
            InitializeComponent();

            key_4.BackColor = Color.Transparent;
            key_4.Parent = room_practice_4;
            this.controller = controller;
        }

        public void Key4_Click(object sender, EventArgs e)
        {
            // 단서 Papper3 함수 _ 클릭 이벤트 발생시
            mKey4 = true;
            inventory_set();
            key_4.Visible = false;
            (this.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
        }

    }
}
