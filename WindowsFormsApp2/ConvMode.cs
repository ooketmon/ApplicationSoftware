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

        int counter = 0;
        int len = 0;
        string text;


        private void ConvMode_Load(object sender, EventArgs e)
        {

            


            ConvMode cm = new ConvMode();

            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("./resources/Mabinogi_Classic_TTF.ttf");

            Font name = new Font(privateFonts.Families[0], 20f);
            Font content = new Font(privateFonts.Families[0], 26f);

            //nameCharacter.Parent = imgConvWindowBack;
            //nameCharacter.BackColor = Color.Transparent;

            nameCharacter.Text = "캐릭터 이름";
            nameCharacter.Font = name;

            contentConv.Text = "대화 내용";
            contentConv.Font = content;

            text = contentConv.Text;
            len = text.Length;

            contentConv.Text = "";
            timerLetter.Start();


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

        private void contentConv_Click(object sender, EventArgs e)
        {

        }

        private void timerLetter_Tick(object sender, EventArgs e)
        {
            counter++;
            
   

            if (counter > len)
            {
                counter = 0;
                contentConv.Text = "";
            }
            else if (counter == len)
            {
                timerLetter.Stop();
            }

            contentConv.Text = text.Substring(0, counter);


                



        }
    }
}
