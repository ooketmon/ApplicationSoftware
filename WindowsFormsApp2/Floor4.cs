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
    public partial class Floor4 : Form
    {
        private PlayerControl playerMove;
        public bool playerisOnStair = false;
        public bool playerisOnElevator = false;
        public Floor4()
        {
            InitializeComponent();
            this.CenterToScreen();

            playerMove = new PlayerControl(player);
        }
        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Floor4_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
        }
        private void Play_KeyDown(object sender, KeyEventArgs e) { playerMove.PlayerKeyDown(sender, e); }
        private void Play_KeyUp(object sender, KeyEventArgs e) { playerMove.PlayerKeyUp(sender, e); }
        private void timerFloor4_Tick(object sender, EventArgs e) //게임 메인 타이머
        {
            playerMove.MovePlayer();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stairs2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        Floor3 floor3 = new Floor3();
                        floor3.Show();
                        this.Hide();
                        return;
                    }
                }
            }
        }
    }
}
