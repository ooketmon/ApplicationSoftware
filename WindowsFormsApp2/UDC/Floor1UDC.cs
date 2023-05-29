using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Floor1UDC : UserControl
    {
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {


                switch (msg.Msg)
                {
                    case 0x100:
                    case 0x104:
                        UserControl1_KeyDown(new object[] {},new KeyEventArgs(keyData)); break;
                    case 0x101:
                    case 0x105:
                        UserControl1_KeyUp(new object[] {},new KeyEventArgs(keyData));  break;
                }
     
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        public Floor1UDC()
        {
            InitializeComponent();
            //this.KeyPreview = true; // KeyPreview 속성을 true로 설정
            this.KeyDown += Inventory_KeyDown; // 이벤트 핸들러 등록
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
        }

        private void UserControl1_KeyUp(object sender, KeyEventArgs e) { playerMove.PlayerKeyUp(sender, e); }
        private void UserControl1_KeyDown(object sender, KeyEventArgs e) { playerMove.PlayerKeyDown(sender, e); }

        private void timerFloor1_Tick(object sender, EventArgs e)
        {
            playerMove.MovePlayer();
               
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stair")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        ((InitMenu)this.Parent).StairCall(1);
                        return;
                    }
                }
                if (x is PictureBox && (string)x.Name == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ((InitMenu)this.Parent).ElevatorCall(1);
                        return;
                    }
                }

                if (x is PictureBox && (x.Name as string).StartsWith("room"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                    }
                }
            }
        }

        private void convWindowUDC1_Load(object sender, EventArgs e)
        {

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

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}
