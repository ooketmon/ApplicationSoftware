using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;
using WindowsFormsApp2.UDC;

namespace WindowsFormsApp2
{
    internal class ControlConversationUDC
    {
        ConvModeUDC target= null;
        string eventType = "";
        int phase = 0;
        public ControlConversationUDC(ConvModeUDC conv) {
            target = conv;
        }
        public void  Prologue()
        {
            phase++;
            eventType = "prologue";
            target.nameCharacter.Text = string.Format("{0}",STUDENT_INFO.name);
            target.contentConv.Text = "눈 깜짝할 새 시험기간이 다가와버렸네..";
            target.BackgroundImage = Properties.Resources.s_1;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void Prologue2()
        {
            phase++;
            target.text = "보아하니 이번 시험도 범위도 못 훑고 가게 생겼어.";
            target.timerReset();
        }
        public void Prologue3()
        {
            phase++;
            target.text = "그래! 시험지를 훔쳐버리자!";
            target.timerReset();
        }
        public void BoardInit(string board_info)
        {
            eventType = board_info;
            phase++;
            string number_only = board_info.Substring(5);
            string[] number_info = number_only.Split('_');
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            
            target.contentConv.Text= string.Format("이건 {0}층 게시판인 것 같다.", number_info[0]);
            Room_Board board_background = new Room_Board();
            target.Controls.Add(board_background);
            board_background.Dock = DockStyle.Fill;
            board_background.SendToBack();
            board_background.BackColor = Color.Transparent;
            //target.BackgroundImage = Properties.Resources.s_1;
            //target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            //target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            target.imgCharacter.Visible = false;
            target.imgCharBack.Visible = false;
        } 

        public void LabInit(string lab_info)
        {

        }

        public void RoomInit(string room_info)
        {
            eventType = room_info;
            phase++;
            string number_only = room_info.Substring(4);
            string[] number_info = number_only.Split('_');
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text= string.Format("여기는 {0}층 {1}호실인 것 같다.", number_info[0], number_info[1]);
            //여기 부분은 switch문이나 if문으로 서로 다른 강의실을 호출할 수도 있습니다.
            int floor_info = Convert.ToInt32(number_info[0]);
            Control room_background = null;
            switch (floor_info)
            {
                case 2:
                    room_background = new Room_lecture1();
                    break;
                case 3:
                    room_background=new Room_lecture2();
                    break;
                case 4:
                    room_background=new Room_lecture3();
                    break;
            }
            target.Controls.Add(room_background);
            room_background.Dock= DockStyle.Fill;
            room_background.SendToBack();
            room_background.BackColor = Color.Transparent;
            target.imgCharacter.Visible=false;
            target.imgCharBack.Visible = false;
        }

        public void GameStart1()
        {
            target.nameCharacter.Text = "'나'";
            target.contentConv.Text = "어디 ";
            target.BackgroundImage = Properties.Resources.s_1;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void SkipConversation()
        {
            if (eventType == "prologue")
            {
                switch (phase)
                {
                    case 1:
                        Prologue2();
                        break;
                    case 2:
                        Prologue3();
                        break;
                    default:
                        (target.Parent as InitMenu).FloorChange(1);
                        break;

                }
                return;
            }

            if (eventType.StartsWith("room"))
            {
                
                    string number_only = eventType.Substring(4);
                    string[] number_info = number_only.Split('_');
                    int floor = Convert.ToInt32(number_info[0]);
                    Control player = null;
                    Control room = null;
                    switch(floor)
                    {
                        case 2:
                            Floor2UDC tmp1 = new Floor2UDC();
                            foreach(Control c in tmp1.Controls)
                            {
                                if (c.Name == "player")
                                player = c;
                                if (c.Name == eventType)
                                room = c;
                            }
                            switch (room.Name)
                            {
                                case "room2_3":
                                case "room2_1":
                                    player.Left =room.Left-50;
                                    player.Top = room.Top;
                                    break;
                                case "room2_4":
                                    player.Left = room.Left;
                                    player.Top = room.Top - 100;
                                    break;
                                case "room2_2":
                                    player.Left = room.Left;
                                    player.Top = room.Top+100;
                                    break;
                                case "room2_5":
                                    player.Left = room.Left + 50;
                                    player.Top = room.Top;
                                    break;
                            }
                            (target.Parent as InitMenu).ConvComeback(tmp1);
                            break;
                        case 3:
                            Floor3UDC tmp2 = new Floor3UDC();
                            foreach (Control c in tmp2.Controls)
                            {
                                if (c.Name == "player")
                                player = c;
                                if (c.Name == eventType)
                                room = c;
                            }
                            player.Left = room.Left;
                            player.Top = room.Top-50;
                            (target.Parent as InitMenu).ConvComeback(tmp2);
                            break;
                        case 4:
                            Floor4UDC tmp3 = new Floor4UDC();
                            foreach (Control c in tmp3.Controls)
                            {
                                if (c.Name == "player")
                                     player = c;
                                
                                if (c.Name == eventType)
                                    room = c;
                            }
                            player.Left = room.Left;
                            player.Top = room.Top - 50;
                            (target.Parent as InitMenu).ConvComeback(tmp3);
                            break;
                        case 8:
                            break;

                    }
                
                return;
            }
            if (eventType.StartsWith("board"))
            {
                Floor2UDC tmp=new Floor2UDC();
                Control player = null;
                Control board = null;
                foreach(Control c in tmp.Controls)
                {
                    if (c.Name == "player")
                        player = c;
                    if(c.Name== eventType)
                        board = c;
                }
                player.Left = board.Left+50;
                player.Top = board.Top;
                (target.Parent as InitMenu ).ConvComeback(tmp);
                return;
            }
        }
    }
}
