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
        public Room_lecture2()
        {
            InitializeComponent();

            PC_2.BackColor = Color.Transparent;
            PC_2.Parent = lecture2;
            pictureBox1.Visible= false; 

            this.KeyDown += Inventory_KeyDown; // 이벤트 핸들러 등록
        }

        public void Papper3_Click(object sender, EventArgs e)
        {
            // 단서 Papper3 함수 _ 클릭 이벤트 발생시
            mPapper3 = true;
            inventory_set();
            Papper_3.Visible = false;
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

        private void PC_2_Click(object sender, EventArgs e)
        {
            //클릭시 비밀번호가 적힌 컴퓨터 화면과 입력 창이 뜨도록
            //정답을 맞출경우 코드가 적힌 화면이 등장함
            pictureBox1.Visible = true;
            DoorLockUDC DoorLockUDC = new DoorLockUDC();
            DoorLockUDC.Show();
        }
    }
}
