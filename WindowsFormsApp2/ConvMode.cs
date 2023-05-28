using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Reflection.Emit;

namespace WindowsFormsApp2
{
    public partial class ConvMode : Form
    {
        public ConvMode()
        {
            InitializeComponent();
        }


        private void ConvMode_Load(object sender, EventArgs e)
        {


            ConvMode cm = new ConvMode();

            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("./resources/Mabinogi_Classic_TTF.ttf");
            Font font = new Font(privateFonts.Families[0], 20f);
            nameCharacter.Parent = imgConvWindowBack;
            nameCharacter.BackColor = Color.Transparent;
            nameCharacter.Text = "캐릭터 이름";
            nameCharacter.Font = font;
            

  
            //nameCharacter.Text = "My new font";


            //contentConv.Parent = imgConvWindowBack;
            //contentConv.BackColor = Color.Transparent;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
            //InitMenu InitMenu = new InitMenu();
            //InitMenu.FloorChange(1);
        }
    }
}
