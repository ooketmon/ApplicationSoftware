using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.UDC
{
    public partial class Room_Board : UserControl
    {
        public Room_Board()
        {
            InitializeComponent();
            zoomPoster.Visible = false;
            backPanel.Visible= false;
            backPanel.BackColor = Color.FromArgb(200, Color.Black);


        }

        private void Poster_1_Click(object sender, EventArgs e)
        {

            //showBack();
            posterClicked = true;
            Room_Board rb = new Room_Board();

            zoomPoster.Visible = true;
            zoomPoster.Image = Properties.Resources._2F_Poster1; 

            zoomPoster.Width = Poster_1.Width  *3 ;
            zoomPoster.Height = Poster_1.Height *3 ;

            zoomPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            zoomPoster.Location = new Point(rb.Width / 2 - zoomPoster.Width / 2, rb.Height/2 - zoomPoster.Height / 2);
            zoomPoster.BringToFront() ; 
        }

        private void Poster_4_Click(object sender, EventArgs e)
        {
            posterClicked = true; 
            Room_Board rb = new Room_Board();

            zoomPoster.Visible = true;
            zoomPoster.Image = Properties.Resources._2F_Poster4;

            zoomPoster.Width = Poster_4.Width * 3;
            zoomPoster.Height = Poster_4.Height * 3;

            zoomPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            zoomPoster.Location = new Point(rb.Width / 2 - zoomPoster.Width / 2, rb.Height / 2 - zoomPoster.Height / 2);
            zoomPoster.BringToFront();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(posterClicked = true)
            {
                zoomPoster.Visible = false; 
            }

        }

    }

    
            zoomPoster.Image = Properties.Resources._2F_Poster1; 

            zoomPoster.Width = Poster_1.Width  *3 ;
            zoomPoster.Height = Poster_1.Height *3 ;

            zoomPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            zoomPoster.Location = new Point(rb.Width / 2 - zoomPoster.Width / 2, rb.Height/2 - zoomPoster.Height / 2);
            zoomPoster.BringToFront() ; 
        }

        private void Poster_4_Click(object sender, EventArgs e)
        {
            posterClicked = true; 
            Room_Board rb = new Room_Board();

            zoomPoster.Visible = true;
            zoomPoster.Image = Properties.Resources._2F_Poster4;

            zoomPoster.Width = Poster_4.Width * 3;
            zoomPoster.Height = Poster_4.Height * 3;

            zoomPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            zoomPoster.Location = new Point(rb.Width / 2 - zoomPoster.Width / 2, rb.Height / 2 - zoomPoster.Height / 2);
            zoomPoster.BringToFront();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(posterClicked = true)
            {
                zoomPoster.Visible = false; 
            }

        }

    }

    
}
