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
    public partial class Room_lecture3 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_lecture3(ControlConversationUDC controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        public void Poster3_Click(object sender, EventArgs e)
        {
            // 단서 Papper3 함수 _ 클릭 이벤트 발생시
            mPoster3 = true;
            inventory_set();
            poster_3.Visible = false;
            (this.Parent.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
            controller.Poster3Get1();
        }

        private void Room_lecture3_Load(object sender, EventArgs e)
        {
            if (mPoster3)
            {
                poster_3.Visible = false;
            }
        }
    }
}
