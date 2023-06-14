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
    public partial class EndingSucceed : UserControl
    {
        int x = 20, y = 100;
        public EndingSucceed()
        {
            InitializeComponent();
            lblEndingSucceed.Text =
                "\'오!! 성공했다!\' \n\n 시작만해도 성공할 줄 몰랐으나, 성공했다. \n\n " +
                "그럼에도 누가 알게되면 꽤나 골칫거리가 될 문제인 것을 알기에 입 밖으로 말하진 못했다. \n\n" +
                "\'여기 나온것만 빠르게 공부하고 가면,,,  \n\n" +
                "7시까지 chatGPT에 돌려서 답 얻고,, 8시반까지 외우고,,, \'\n\n" +
                "성공해서 그런걸까. 조금 찔리기는 했으나 시험지가 내 손에 있는데 뭐가 대수랴\n\n" +
                "시험까지 계획도 세우고 집으로 향했다." + "\n\n" +
                " \" 띡띡띡띡 띠리릭~\" \n\n" +
                "집 도어락을 열고 들어가 책상에 앉으려다" + "\n\n" +
                "\'시험지도 있겠다.. 답도 지피티가 찾아줄거고,, 조금만 쉬었다 할까? \'" + "\n\n" +
                "라는 생각이 들어 밤새 긴장한 몸을 잠깐 침대에 눕혔다." + "\n\n" +
                ". \n\n" +
                ". \n\n" +
                ". \n\n" +
                " \" 세탁기.. 오디오.. 텔레비전.. 중고.. 기기... 삽니다... 공 일 공 사 구 ...." + " \n\n" +
                "아침이라기엔 너무 환한 창문과, 활기있는 길거리 소리가 들렸다." + "\n\n" + 
                "\'...?!\'" + "\n\n"+
                "\'이러면 안되는데..?????";


        }

        int counter = 0;
        int len = 0;
        string txt;


        private void EndingSucceed_Load(object sender, EventArgs e)
        {
            txt = lblEndingSucceed.Text;
            len = txt.Length;
            lblEndingSucceed.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                lblEndingSucceed.Text = "";
            }

            lblEndingSucceed.Text = txt.Substring(0, counter);
            lblEndingSucceed.Height = 200;

            lblEndingSucceed.SetBounds(x, y, 1, 1);
            y--;


        }
    }
}
