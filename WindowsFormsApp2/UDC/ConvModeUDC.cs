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

        System.Threading.Timer timer = null;
        public delegate void timer_delegate();

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
            /*
            if (!timerLetter.Enabled)
            {
                timerLetter.Start();
            }
            */

            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("./resources/Mabinogi_Classic_TTF.ttf"); // 마비노기 옛체 
            privateFonts.AddFontFile("./resources/NeoDunggeunmoPro-Regular.ttf"); // 둥근모
            Font name = new Font(privateFonts.Families[0], 20f);
            Font content = new Font(privateFonts.Families[0], 26f);
            nameCharacter.Font = name;
            contentConv.Font = content;
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
                if ((this.Parent as InitMenu).inventory.Visible)
                {
                    (this.Parent as InitMenu).inventory.Hide();
                }
                else
                {
                    (this.Parent as InitMenu).inventory.Show();
                }
            }
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
                this.btnSkip.Text = "나가기";
            } else if (where_event_occur == "prologue")
            {
                controller.Prologue();
            } else if (where_event_occur.StartsWith("board"))
            {
                controller.BoardInit(where_event_occur);
                this.btnSkip.Text = "나가기";
            } else if (where_event_occur == "guardroom" && !(this.Parent as InitMenu).havetoGoGuardRoom)
            {
                controller.GuardRoom_JustEnter_Init(where_event_occur);

            } else if (where_event_occur == "guardroom" && (this.Parent as InitMenu).havetoGoGuardRoom && !StaticItem.mSafekey4)
            {
                controller.GuardRoom_GetPracticeRoomKey_Init(where_event_occur);
            } else if (where_event_occur=="guardroom"&&StaticItem.mSafekey4) {
                controller.GuardRoom_Do_Nothing(where_event_occur);
            }
            else if (where_event_occur == "hintNPC_1")
            {
                controller.firstFloorNPC_Init(where_event_occur);
            }else if (where_event_occur == "meetingplace")
            {
                controller.MeetingPlaceInit(where_event_occur);
            }else if (where_event_occur.StartsWith("practice"))
            {
                controller.Practice_Init(where_event_occur);
            }else if (where_event_occur == "department")
            {
                controller.Department_Init(where_event_occur);
            }else if (where_event_occur.StartsWith("lab"))
            {
                controller.LabInit(where_event_occur);
            }


            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile("./resources/Mabinogi_Classic_TTF.ttf"); // 마비노기 옛체 
            privateFonts.AddFontFile("./resources/NeoDunggeunmoPro-Regular.ttf"); // 둥근모

            // 폰트 설정
            Font name = new Font(privateFonts.Families[0], 20f);
            Font content = new Font(privateFonts.Families[0], 26f);
            Font button_text = new Font(privateFonts.Families[1], 15f);


            nameCharacter.Font = name;
            contentConv.Font = content;
            btnSkip.Font = button_text;


            // 텍스트 한글자씩 뜨도록
            text = contentConv.Text;
            len = text.Length;

            contentConv.Text = "";
            //timerLetter.Start();
            timer = new System.Threading.Timer(TimerCallBack);
            timer.Change(0, 30);

            //nameCharacter.Parent = imgConvWindowBack;
            //nameCharacter.BackColor = Color.Transparent;

            //contentConv.Parent = imgConvWindowBack;
            //contentConv.BackColor = Color.Transparent;
        }

        private void TimerCallBack(object status)
        {
            BeginInvoke(new timer_delegate(() =>
            {
                counter++;
                if(!(String.IsNullOrEmpty(text))&&text.Length >= counter)
                {
                    contentConv.Text = text.Substring(0, counter);
                }else if (counter > text.Length)
                {
                    counter--;
                }
            }));
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
