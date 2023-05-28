using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class ControlConversation
    {

        static ConvMode ConvMode = Application.OpenForms.OfType<ConvMode>().FirstOrDefault();   

        public static void  GameStart()
        {
            ConvMode.nameCharacter.Text = "'나'";
            ConvMode.contentConv.Text ="아..시험기간이 또 다가왔네";
            ConvMode.BackgroundImage = Properties.Resources.s_1;
            ConvMode.imgCharacter.Image = Properties.Resources.IMG_0809;
            ConvMode.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
