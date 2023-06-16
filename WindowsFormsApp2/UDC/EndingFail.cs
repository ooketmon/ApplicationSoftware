using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2.UDC
{
    public partial class EndingFail : UserControl
    {
        public EndingFail()
        {
            //System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            //privateFonts.AddFontFile("./resources/NeoDunggeunmoPro-Regular.ttf"); // 둥근모

            //// 폰트 설정
            //Font label = new Font(privateFonts.Families[0], 26f);

            InitializeComponent();
            //lblEndingFail.Font= label;
      

        }
        public EndingFail(string whoCatchMe)
        {
            InitializeComponent();
            this.whoCatchMe = whoCatchMe;
        }
        int counter = 0;
        int len = 0;
        string txt;
        string whoCatchMe = "";
        int stopcounter = 0;
        bool timingtoGoMain = false;

        System.Threading.Timer timer;
        public delegate void controller();


        private void EndingFail_Load(object sender, EventArgs e)
        {
            if (whoCatchMe == "guardman")
            {
                txt = "\"학생! 지금 뭐하는 건가!\" \n\n 경비아저씨의 목소리와 함께 뒤에서 누가 날 잡았다.\n\n " +
                    "\'아뿔싸.. 망했다.\' \n\n" +
                    "그 순간 왜이렇게 무모한 도전을 시작했을까부터 지난 밤의 모든 기억들이 주마등 처럼 스쳐지나갔다. \n\n" +
                    "\"손에 든 이거.. 시험지 아니야?\" \n\n" +
                    "\"아....\"\n\n" +
                    "내가 이런 일을 벌였지만서도, 그 순간 부끄러움이 한번에 몰려와 감당할 수 없었다." + "\n\n" +
                    "손에 쥐고 있는 몇 장의 종이쪼가리가 비참하게 느껴졌다. \n\n" +
                    "황급히 손을 등 뒤로 숨겼지만 이미 상황이 명백한 바, 역부족이었다. " + "\n\n" +
                    "\"안되겠어 학생. 이건 내 선에서 해결할 수 있는 문제가 아니야. 이건 범죄야. 일단 이건 학교에 보고가 될거야." + "\n\n" +
                    "학번이랑 이름, 핸드폰 번호 여기 적고, 오늘 중으로 학교에서 연락이 갈거에요.\" " + "\n\n" +
                    "\"나 원 참 살다살다 이런 학생은 처음보네! \" ";
            }
            else
            {
                txt = "\"학생! 그거 뭡니까!\" \n\n 행정조교님의 목소리와 함께 뒤에서 누가 날 잡았다.\n\n " +
                    "\'아뿔싸.. 망했다.\' \n\n" +
                    "그 순간 왜이렇게 무모한 도전을 시작했을까부터 지난 밤의 모든 기억들이 주마등 처럼 스쳐지나갔다. \n\n" +
                    "\"손에 든 이거.. 시험지 아닙니까?\" \n\n" +
                    "\"아....\"\n\n" +
                    "내가 이런 일을 벌였지만서도, 그 순간 부끄러움이 한번에 몰려와 감당할 수 없었다." + "\n\n" +
                    "손에 쥐고 있는 몇 장의 종이쪼가리가 비참하게 느껴졌다. \n\n" +
                    "황급히 손을 등 뒤로 숨겼지만 이미 상황이 명백한 바, 역부족이었다. " + "\n\n" +
                    "\"이건 제 선에서 해결할 수 있는 문제가 아닙니다. 이건 중대한 범죄행위에요.\n\n일단 이 일은 학교에도 보고하겠습니다." + "\n\n" +
                    "학번이랑 이름, 핸드폰 번호 여기 적으시고, 오늘 중으로 학교에서 연락이 갈거에요.\" " + "\n\n" +
                    "\"세상에..연구실까지 와서 시험지를 훔치다니! \"\n\n " +
                    "그 이후, 학교 뿐만 아니라 에브리타임에서도 이 일은 구전되며 우리 학교 사건사에 한 획을 그었다. \n\n";
            }
            len = txt.Length;
            lblEndingFail.Text = "";
            timer1.Start();
            timer = new System.Threading.Timer(controllerCallBack);
            timer.Change(0, 180);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter>=len)
            {
                timer1.Enabled = false;
            }

            lblEndingFail.Text = txt.Substring(0, counter);
            
        }

        public void controllerCallBack(object status)
        {
            BeginInvoke(new controller(() =>
            {
                if (lblEndingFail.Text.Length != txt.Length)
                {
                    lblEndingFail.Top -= 7;
                }
                else
                {
                    stopcounter+=180;
                    if (stopcounter >= 5000 && !timingtoGoMain)
                    {
                        timingtoGoMain = true;
                        (this.Parent as InitMenu).CallMainMenu();
                    }
                }
            }));
        }

        private void lblEndingFail_Click(object sender, EventArgs e)
        {

        }
    }
}
