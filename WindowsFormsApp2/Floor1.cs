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
    public partial class Floor1 : Form
    {
        private PlayerControl playerMove;
        public bool playerisOnStair = false;
        public bool playerisOnElevator = false;
        public Floor1()
        {
            InitializeComponent();
            this.CenterToScreen();

            playerMove = new PlayerControl(player);


            //show a window for text-conversation under the this window
            ConvWindow ConvWindow = new ConvWindow();
            ConvWindow.StartPosition = FormStartPosition.Manual;
            ConvWindow.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            ConvWindow.Show();
        }
        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Floor1_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
        }
        private void Play_KeyDown(object sender, KeyEventArgs e) { playerMove.PlayerKeyDown(sender, e); }
        private void Play_KeyUp(object sender, KeyEventArgs e) { playerMove.PlayerKeyUp(sender, e); }
        private void timerFloor1_Tick(object sender, EventArgs e) //게임 메인 타이머
        {
            playerMove.MovePlayer();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stairs1")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        Floor2 floor2 = new Floor2();
                        floor2.Show();
                        this.Hide();
                        return;
                    }
                }
                if (x is PictureBox && (string)x.Name == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ElevatorChoice choice = new ElevatorChoice(1);

                        choice.ControlBox = false;
                        choice.Show();
                        choice.Left = player.Left;
                        choice.Top = player.Top;
                        choice.FormClosed += (choiceSender, choiceEvent) => {
                            this.Hide();
                        };
                      
                    }
                }
            }
        }
    }
}
