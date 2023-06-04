using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Floor4UDC : UserControl
    {
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        bool convHitTest = false;

        public Floor4UDC()
        {
            InitializeComponent();
        }
        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.ForceToStop();
            if (e.KeyCode == Keys.I)
            {
                if ((this.Parent as InitMenu).inventory.Visible)
                {
                    (this.Parent as InitMenu).inventory.Hide();
                }
                else
                {
                    (this.Parent as InitMenu).inventory.Show();
                }
            }

        }

        private void ShowInventory()
        {
            // 호출할 폼의 인스턴스 생성
            Inventory inventory = new Inventory();
            // 폼을 보여줌
            inventory.Show();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {

                Floor4_KeyDown(new object[] { }, new KeyEventArgs(keyData));

                return true;
            }else if (keyData == Keys.I)
            {
                Inventory_KeyDown(new object[] {},new KeyEventArgs(keyData));
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void Floor4_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
        }
        private void Floor4_KeyUp(object sender, KeyEventArgs e)
        {
            playerMove.PlayerKeyUp(sender, e);
        }

        private void Floor4_KeyDown(object sender, KeyEventArgs e)
        {
            //playerMove.PlayerKeyDown(sender, e);
            playerMove.MovePlayerWithoutBool(e);
        }

        private void timerFloor4_Tick(object sender, EventArgs e)
        {
           // playerMove.MovePlayer();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stair")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        ((InitMenu)this.Parent).StairCall(4);
                        return;
                    }
                }
                if (x is PictureBox && (string)x.Name == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ((InitMenu)this.Parent).ElevatorCall(4);
                        return;
                    }
                }
                if (x is PictureBox && ((x.Name as string)=="department" || (x.Name as string).StartsWith("board")))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest)
                    {
                        convHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "lock1")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        MessageBox.Show("이쪽 입구는 잠겨있다.");
                        convHitTest = false;
                        break;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "lock2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest)
                    {
                        convHitTest = true;
                        player.Left -= 50;
                        MessageBox.Show("이 문은 잠겨있다.");
                        convHitTest = false;
                        break;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "lock3")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest)
                    {
                        convHitTest = true;
                        player.Left += 50;
                        MessageBox.Show("이 문은 잠겨있다.");
                        convHitTest = false;
                        break;
                    }
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void stairs2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }
    }
}
