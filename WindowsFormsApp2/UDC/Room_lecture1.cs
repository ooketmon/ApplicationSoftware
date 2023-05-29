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

namespace WindowsFormsApp2
{
    public partial class Room_lecture1 : UserControl
    {
        public Room_lecture1()
        {
            InitializeComponent();

            Papper_1.BackColor = Color.Transparent;
            Papper_1.Parent = lecture1;

            this.KeyDown += Inventory_KeyDown; // 이벤트 핸들러 등록
        }

        private void Papper1_Click(object sender, EventArgs e)
        {
            // 단서 papper1 함수 _ 클릭 이벤트 발생시
            mPapper1 = true;
            inventory_set();
            Papper_1.Visible = false;
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
