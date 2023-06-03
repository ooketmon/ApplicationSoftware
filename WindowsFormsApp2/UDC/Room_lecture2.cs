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
            (this.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
        }

        public void PC2_Click(object sender, EventArgs e)
        {
            //클릭시 비밀번호가 적힌 컴퓨터 화면과 입력 창이 뜨도록
            //정답을 맞출경우 코드가 적힌 화면이 등장함
        }






    }
}
