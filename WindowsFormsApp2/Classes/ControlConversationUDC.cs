using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.UDC;

namespace WindowsFormsApp2
{
    internal class ControlConversationUDC
    {
        ConvModeUDC target=null;
        public ControlConversationUDC(ConvModeUDC conv) {
            target = conv;
        }
        public void  Prologue()
        {
            target.nameCharacter.Text = "'나'";
            target.contentConv.Text ="아..시험기간이 또 다가왔네";
            target.BackgroundImage = Properties.Resources.s_1;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void GameStart1()
        {
            target.nameCharacter.Text = "'나'";
            target.contentConv.Text = "어디 ";
            target.BackgroundImage = Properties.Resources.s_1;
            target.imgCharacter.Image = Properties.Resources.IMG_0809;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
