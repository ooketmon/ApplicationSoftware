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
    public partial class ConvModeUDC : UserControl
    {

        int counter = 0;
        int len = 0;
        string text;
        ControlConversationUDC controller = null;
        public ConvModeUDC()
        {
            InitializeComponent();
            imgCharacter.Controls.Add(imgCharBack);
            imgCharBack.Location = new Point(0, 0);
            imgCharBack.BackColor = Color.Transparent;
            nameCharacter.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void ConvModeUDC_Load(object sender, EventArgs e)
        {
            nameCharacter.Text = "캐릭터 이름";
            contentConv.Text = "대화 내용";

            controller = new ControlConversationUDC(this);
            controller.Prologue();

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

        private void timerLetter_Tick_1(object sender, EventArgs e)
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

        private void btnSkip_Click(object sender, EventArgs e)
        {
            (this.Parent as InitMenu).FloorChange(1);
        }
    }
}
