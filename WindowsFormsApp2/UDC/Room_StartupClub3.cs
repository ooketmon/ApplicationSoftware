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
    public partial class Room_StartupClub3 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_StartupClub3(ControlConversationUDC controller)
        {
            InitializeComponent();

            cardkey_3.BackColor = Color.Transparent;
            cardkey_3.Parent = room_sofa;

            npc_sleep.Parent = room_sofa;
            npc_sleep.BackColor = Color.Transparent;
            this.controller = controller;

        }

        public void Cardkey3_Click(object sender, EventArgs e)
        {
            // 단서 Papper3 함수 _ 클릭 이벤트 발생시
            mCardkey3 = true;
            inventory_set();
            cardkey_3.Visible = false;
            (this.Parent.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
            (this.Parent.Parent as InitMenu).CheckTestComplete();
            controller.SecondFloorCardKeyGet1();
        }

        public void Npc_Click(object sender, EventArgs e)
        {
            // npc 클릭할 경우 대사가 나오도록
            controller.SecondFloorNPC1();
        }

        private void Room_StartupClub3_Load(object sender, EventArgs e)
        {
            if (mCardkey3 || !StaticItem.mPapper3)
            {
                cardkey_3.Visible = false;
            }

        }
    }
}