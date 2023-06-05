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
    public partial class Room_lecture2 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_lecture2(ControlConversationUDC controller)
        {
            InitializeComponent();

            PC_2.BackColor = Color.Transparent;
            PC_2.Parent = lecture2;

            this.controller = controller;

        }

        public void Papper3_Click(object sender, EventArgs e)
        {
            // 단서 Papper3 함수 _ 클릭 이벤트 발생시
            mPapper3 = true;
            inventory_set();
            Papper_3.Visible = false;
            (this.Parent.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
            (this.Parent.Parent as InitMenu).CheckTestComplete();
            controller.Papper3Get1();
        }

        public void PC2_Click(object sender, EventArgs e)
        {
            if(!(this.Parent.Parent as InitMenu).knowLab2PW){//풀지 않은 경우
                controller.Room2_2Puzzle();
            }
            else//한 번 푼 경우
            {
                controller.Room2_2PuzzleSolved();
            }
            //클릭시 비밀번호가 적힌 컴퓨터 화면과 입력 창이 뜨도록
            //정답을 맞출경우 코드가 적힌 화면이 등장함
        }

        private void lecture2_Click(object sender, EventArgs e)
        {

        }

        private void Room_lecture2_Load(object sender, EventArgs e)
        {
            if (mPapper3)
            {
                Papper_3.Visible=false;
            }
        }
    }
}
