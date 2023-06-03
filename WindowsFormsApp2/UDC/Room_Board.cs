using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.UDC
{
    public partial class Room_Board : UserControl
    {
        bool posterClicked = false;
        ControlConversationUDC controller = null;

        public Room_Board()
        {
            InitializeComponent();
            zoomPoster.Visible = false;
            blackBack.Visible = false;
            //black_back.Visible = false; 


        }
        public Room_Board(ControlConversationUDC controller)
        {
            InitializeComponent();
            zoomPoster.Visible = false;
            blackBack.Visible= false;
            this.controller=controller;
            //black_back.Visible = false; 


        }

        public void Poster_Press(object sender, EventArgs e)
        {
            string posterName = (sender as Control).Name;
            PosterZoomUDC maximizedPoster = new PosterZoomUDC();

            Bitmap resourceName = null;

            if (posterName == "Poster_1")
            {
                resourceName = Properties.Resources._2F_Poster1;
            }
            else if (posterName == "Poster_2")
            {
                resourceName = Properties.Resources._2F_Poster4;
            }
            else
            {
                return;
            }

            maximizedPoster.setMainItem(resourceName);
            Controls.Add(maximizedPoster);

            maximizedPoster.Dock = DockStyle.Fill;

            //maximizedPoster.BringToFront();

        }

        public void showBack()
        {
    
            Panel blackBack = new Panel();
            blackBack.Visible = true;
            blackBack.BackColor = Color.FromArgb(128, Color.Black); // 투명도를 위해 Alpha 값 128 사용
            blackBack.Dock = DockStyle.Fill; // 패널을 폼에 꽉 채우도록 설정
            this.Controls.Add(blackBack);
            blackBack.BringToFront();

        }

        private void Poster_1_Click(object sender, EventArgs e)
        {

            //showBack();
            posterClicked = true;
            //Room_Board rb = new Room_Board(controller);

            zoomPoster.Visible = true;
            zoomPoster.Image = Properties.Resources._2F_Poster1; 

            zoomPoster.Width = Poster_1.Width  *3 ;
            zoomPoster.Height = Poster_1.Height *3 ;

            zoomPoster.SizeMode = PictureBoxSizeMode.StretchImage;

          //  zoomPoster.Location = new Point(this.Width / 2 - zoomPoster.Width / 2, this.Height/2 - zoomPoster.Height / 2);
            zoomPoster.Top = zoomPoster.Height / 8;
            zoomPoster.Left=this.Width / 2 - zoomPoster.Width/2;
            controller.SecondFloorBoard1();
        }

        private void Poster_4_Click(object sender, EventArgs e)
        {
            posterClicked = true; 
           // Room_Board rb = new Room_Board(controller);

            zoomPoster.Visible = true;
            zoomPoster.Image = Properties.Resources._2F_Poster4;

            zoomPoster.Width = Poster_4.Width * 3;
            zoomPoster.Height = Poster_4.Height * 3;

            zoomPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            zoomPoster.Location = new Point(this.Width / 2 - zoomPoster.Width / 2, this.Height / 2 - zoomPoster.Height / 2);
            //zoomPoster.Top = zoomPoster.Height / 8;
            //zoomPoster.Left = this.Width / 2 - zoomPoster.Width / 2;
            controller.FourthFloorBoard1();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(posterClicked)
            {
                zoomPoster.Visible = false;
                controller.SayNothing();
            }

        }

    }

    
}
