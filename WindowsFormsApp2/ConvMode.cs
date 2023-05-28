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
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class ConvMode : Form
    {
        public ConvMode()
        {
            InitializeComponent();

            imgCharacter.Controls.Add(imgCharBack);
            imgCharBack.Location = new Point(0, 0);
            imgCharBack.BackColor = Color.Transparent;

        }

        int counter = 0;
        int len = 0;
        string text;


        private void ConvMode_Load(object sender, EventArgs e)
        {

            ConvMode cm = new ConvMode();

            // 디폴트 ~~
            nameCharacter.Text = "캐릭터 이름";
            contentConv.Text = "대화 내용";


            ControlConversation.GameStart();

            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("./resources/Mabinogi_Classic_TTF.ttf"); // 마비노기 옛체 
            privateFonts.AddFontFile("./resources/NeoDunggeunmoPro-Regular.ttf"); // 둥근모

            // 폰트 설정
            Font name = new Font(privateFonts.Families[0], 20f);
            Font content = new Font(privateFonts.Families[0], 26f);

            
            nameCharacter.Font = name;
            contentConv.Font = content;


            // 텍스트 한글자씩 뜨도록
            text = contentConv.Text;
            len = text.Length;
            
            contentConv.Text = "";
            timerLetter.Start();

            //nameCharacter.Parent = imgConvWindowBack;
            //nameCharacter.BackColor = Color.Transparent;

            //contentConv.Parent = imgConvWindowBack;
            //contentConv.BackColor = Color.Transparent;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
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
