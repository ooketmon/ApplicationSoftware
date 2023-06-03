using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            black_back.Visible = false; 
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
            //maximizedPoster.BringToFront;

        }

        private void Poster_1_Click(object sender, EventArgs e)
        {
            Room_Board room_board = new Room_Board();
            zoomPoster.Visible = true;
            zoomPoster.Image = Properties.Resources._2F_Poster1; 

            zoomPoster.Width = Poster_1.Width  *3 ;
            zoomPoster.Height = Poster_1.Height *3 ;

            zoomPoster.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }

    
}
