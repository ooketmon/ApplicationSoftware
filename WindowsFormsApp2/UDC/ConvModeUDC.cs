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
        public string text;
        string where_event_occur;
        ControlConversationUDC controller = null;
        public ConvModeUDC()
        {
            InitializeComponent();
            imgCharacter.Controls.Add(imgCharBack);
            imgCharBack.Location = new Point(0, 0);
            imgCharBack.BackColor = Color.Transparent;
            nameCharacter.TextAlign = ContentAlignment.MiddleCenter;

        }

        public ConvModeUDC(string place)
        {
            InitializeComponent();
            imgCharacter.Controls.Add(imgCharBack);
            imgCharBack.Location = new Point(0, 0);
            imgCharBack.BackColor = Color.Transparent;
            nameCharacter.TextAlign = ContentAlignment.MiddleCenter;
            where_event_occur = place;
        }
        public void timerReset()
        {
            try
            {
                contentConv.Text = "";
            }
            catch (Exception)
            {

            }
            counter = 0;
            if (!timerLetter.Enabled)
            {
                timerLetter.Start();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.I && where_event_occur!="prologue")
            {
                Inventory_KeyDown(new object[] { }, new KeyEventArgs(keyData));
                return true;
            }else if (keyData == Keys.Space || keyData==Keys.Enter)
            {
                controller.SkipConversation();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(Inventory))
                    {
                        f.Close();
                        return;
                    }
                }

                ShowInventory();
                System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
                privateFonts.AddFontFile("./resources/Mabinogi_Classic_TTF.ttf"); // 마비노기 옛체 
                privateFonts.AddFontFile("./resources/NeoDunggeunmoPro-Regular.ttf"); // 둥근모

                // 폰트 설정
                Font name = new Font(privateFonts.Families[0], 20f);
                Font content = new Font(privateFonts.Families[0], 26f);


                nameCharacter.Font = name;
                contentConv.Font = content;
            }
        }

        private void ShowInventory()
        {
            // 호출할 폼의 인스턴스 생성
            Inventory inventory = new Inventory();
            // 폼을 보여줌
            inventory.Show();

        }
        private void ConvModeUDC_Load(object sender, EventArgs e)
        {
            this.KeyDown += Inventory_KeyDown;
            nameCharacter.Text = "캐릭터 이름";
            contentConv.Text = "대화 내용";

            controller = new ControlConversationUDC(this);
            if (where_event_occur.StartsWith("room"))
            {
                controller.RoomInit(where_event_occur);
            }else if (where_event_occur == "prologue")
            {
                controller.Prologue();
            }else if (where_event_occur.StartsWith("board"))
            {
                controller.BoardInit(where_event_occur);
            }

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



            if (!(String.IsNullOrEmpty(text))&&counter > text.Length)
            {
                counter = 0;
                contentConv.Text = "";
            }
            else if (counter == text.Length)
            {
                timerLetter.Stop();
            }
            if (!String.IsNullOrEmpty(text))
            {
                contentConv.Text = text.Substring(0, counter);
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            controller.SkipConversation();
        }
    }
}
