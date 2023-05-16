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
    public partial class Floor3 : Form
    {
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        public Floor3()
        {
            InitializeComponent();
            this.CenterToScreen();

            playerMove = new PlayerControl(player);
        }
        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Floor3_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
        }
        private void Play_KeyDown(object sender, KeyEventArgs e) { playerMove.PlayerKeyDown(sender, e); }
        private void Play_KeyUp(object sender, KeyEventArgs e) { playerMove.PlayerKeyUp(sender, e); }
        private void timerFloor3_Tick(object sender, EventArgs e) //게임 메인 타이머
        {
            playerMove.MovePlayer();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stairs2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        Floor4 floor4 = new Floor4();
                        floor4.Show();
                        this.Hide();
                        return;
                    }
                }
            }
        }
    }
}
