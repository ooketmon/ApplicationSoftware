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
        public Room_StartupClub3()
        {
            InitializeComponent();

            cardkey_3.BackColor = Color.Transparent;
            cardkey_3.Parent = room_sofa;

            this.KeyDown += Inventory_KeyDown; // 이벤트 핸들러 등록
        }

        public void Cardkey3_Click(object sender, EventArgs e)
        {
            // 단서 Papper3 함수 _ 클릭 이벤트 발생시
            mCardkey3 = true;
            inventory_set();
            cardkey_3.Visible = false;
        }

        public void Npc_Click(object sender, EventArgs e)
        { 
            // npc 클릭할 경우 대사가 나오도록
        }

        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                ShowInventory();
            }
        }

        private void ShowInventory()
        {
            // 호출할 폼의 인스턴스 생성
            Inventory inventory = new Inventory();

            // 폼을 보여줌
            inventory.ShowDialog();
        }

    }
}