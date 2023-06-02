using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2.UDC;

namespace WindowsFormsApp2
{
    public class ControlConversationUDC
    {
        ConvModeUDC target= null;
        string eventType = "";
        int phase = 0;
        public ControlConversationUDC(ConvModeUDC conv) {
            target = conv;
        }
        public void GetRidofEventSplit()
        {
            if (eventType.Contains("/"))
            {
                int startofsplit = eventType.IndexOf("/");
                eventType=eventType.Substring(0,startofsplit);
            }
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
            (target.Parent as InitMenu).havetoGoGuardRoom = true;
            phase++;
            string number_only = board_info.Substring(5);
            string[] number_info = number_only.Split('_');
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            
            target.contentConv.Text= string.Format("이건 {0}층 게시판인 것 같다.", number_info[0]);
            if (number_info[0] == "2")
            {
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
            else
            {
                target.BackgroundImage = Properties.Resources._2F_board;
                target.imgCharacter.Image = Properties.Resources.player_anime_ver;
                target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        } 

        public void FourthFloorBoard2()
        {
            phase++;
            target.nameCharacter.Text = "게시판";
            target.text = string.Format("실습실이 닫혀있다면 여기 말고\r\n경비실로 가시기 바랍니다.");
            target.timerReset();
        }

        public void FourthFloorBoard3()
        {
            phase++;
            target.nameCharacter.Text = STUDENT_INFO.name;
            target.text = string.Format("경비 아저씨...주무시려나?");
            target.timerReset();
        }



        public void LabInit(string lab_info)
        {
            eventType = lab_info;
            string number_only = lab_info.Substring(3);
            string[] number_info = number_only.Split('_');
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = string.Format("여기는 {0}층 {1}연구실인 것 같다.", number_info[0], number_info[1]);
            phase++;

            target.imgCharacter.Visible = false;
            target.imgCharBack.Visible = false;

        }

        public void Test1Get1()
        {
            GetRidofEventSplit();
            eventType += "/GetTest1";
            phase++;
            target.nameCharacter.Text = STUDENT_INFO.name;
            target.text = string.Format("저기 복사기 위의 종이...혹시?");
            target.timerReset();

        }
        public void Test1Get2()
        {
            phase++;
            target.nameCharacter.Text = "System";
            target.text = string.Format("시험지를 발견했다.");
            target.timerReset();
        }

        public void Test2Get1()
        {
            GetRidofEventSplit();
            eventType += "/GetTest2";
            phase++;
            target.nameCharacter.Text = STUDENT_INFO.name;
            target.text = string.Format("교수님 컴퓨터가 켜져있군..좋아!");
            target.timerReset();

        }

        public void Test2Get2()
        {
            phase++;
            target.nameCharacter.Text = "System";
            target.text = string.Format("시험지를 뽑아 가져갔다.");
            target.timerReset();

        }
        public void Test3Get1()
        {
            GetRidofEventSplit();
            eventType += "/GetTest2";
            phase++;
            target.nameCharacter.Text = STUDENT_INFO.name;
            target.text = string.Format("책꽂이의 서류뭉치...수상하군..좋아!");
            target.timerReset();
        }

        public void Test3Get2()
        {
            phase++;
            target.nameCharacter.Text = "System";
            target.text = string.Format("서류뭉치에서 시험지를 발견했다.");
            target.timerReset();

        }
        public void GuardRoom_JustEnter_Init(string guard_info)
        {
            eventType=guard_info+"/JustEnter";
            phase++;
            target.BackgroundImage = Properties.Resources.guardmanroom;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = "경비실이 열려있네?";

        }

        public void GuardRoom_JustEnter2()
        {
            phase++;
            target.nameCharacter.Text = "경비아저씨";
            target.text = "Zzz.z.z.z..zzZZZ..z.ZZ";
            target.timerReset();
        }

        public void GuardRoom_JustEnter3()
        {
            phase++;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = "좋아! 경비아저씨는 주무시고 계시는군.\r\n경비아저씨께 들키면 안되겠어.";
            target.timerReset();
        }

        public void GuardRoom_GetPracticeRoomKey_Init(string guard_info)
        {
            eventType = guard_info + "/GetSafeCard";
            phase++;
            target.BackgroundImage = Properties.Resources.guardmanroom;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = "(혹시 주무시나?)";
        }
        public void GuardRoom_GetPracticeRoomKey2()
        {
            phase++;
            target.nameCharacter.Text = "경비 아저씨";
            target.text = "Zzz.z.z.z..zzZZZ..z.ZZ";
            target.timerReset();
        }
        
        public void GuardRoom_GetPracticeRoomKey3()
        {
            phase++;
            target.nameCharacter.Text =STUDENT_INFO.name;
            target.text = "좋아..가져가겠습니다..";
            target.timerReset();
        }
        public void GuardRoom_GetPracticeRoomKey4()
        {
            phase++;
            target.nameCharacter.Text = "System";
            target.text = "실습실 보안 카드를 획득했다.";
            target.timerReset();
        }

        public void GuardRoom_Do_Nothing(string guard_info)
        {
            eventType = guard_info + "/DoNothing";
            phase++;
            target.BackgroundImage = Properties.Resources.guardmanroom;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = "이제 볼 일이 없다.";
        }

        public void RoomInit(string room_info)
        {
            eventType = room_info;
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
                    room_background = new Room_lecture1(this);
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

        public void Papper1Get()
        {
            eventType += "/GetPapper1";
            target.nameCharacter.Text = "System";
            target.text = string.Format("찢어진 조각을 발견했다.");
            target.timerReset();
        }
        public void Poster1Get()
        {
            GetRidofEventSplit();
            eventType += "/Poster1Get";
            target.nameCharacter.Text = "System";
            target.text = string.Format("2층 포스터를 발견했다.");
            target.timerReset();
        }

        public void Poster2Get()
        {
            eventType += "/Poster2Get";
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("홍보 게시물이 여기 있네.\r\n숫자가 강조된 부분이 신경쓰이는 걸?");
            target.timerReset();
        }
        public void LectureComputer()
        {
            GetRidofEventSplit();
            eventType += "/LectureComputer";
            target.nameCharacter.Text = "System";
            target.text = string.Format("해석을 할 수 있을 것 같다.");
            target.timerReset();
        }

        public void SecondFloorCardKeyGet()
        {
            GetRidofEventSplit();
            eventType += "/GetSecondFloorCardKey";
            target.nameCharacter.Text = string.Format("{0}",STUDENT_INFO.name);
            target.text = string.Format("카드 키를 찾았다. 어디를 열 수 있는 걸까?");
            target.timerReset();
        } 


        public void SecondFloorNPC()
        {
            GetRidofEventSplit();
            eventType += "/GetSecondFloorCardKey";
            target.nameCharacter.Text ="잠에 든 대학원생";
            target.text = string.Format("…zzzZ..zZ.zZz…\r\n네 교수님, 실습실4, 연구실4 과사에 놓고 왔.. 습니 … zzZZZ.z..zZZZ…");
            target.timerReset();
        }


        public void Papper3Get1()
        {
            eventType += "/GetPapper3";
            phase++;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("이게..뭐라는거지?");
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "▶";
                }
            }
            target.timerReset();
        }
        public void Papper3Get2()
        {
            phase++;
            target.nameCharacter.Text = "System";
            target.text = "애너그램을 얻었다.";
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            target.timerReset();
        }

        public void Papper4Get()
        {
            phase++;
            target.nameCharacter.Text = "System";
            target.text = "쪽지를 얻었다.\r\n인벤토리에서 자세히 확인하자.";
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            target.timerReset();
        }

        public void GetKey()
        {
            eventType += "/GetKey";
            phase++;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("연구실 열쇠다!");
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            target.timerReset();
        }
        public void firstFloorNPC_Init(string npcinfo)
        {
            eventType = npcinfo;
            phase++;
            target.BackgroundImage = Properties.Resources.lobby_sofa;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = "저기 소파에 누가 앉아있는 것 같다.";
        }

        public void firstFloorNPC2()
        {
            phase++;
            target.nameCharacter.Text = "조교님";
            target.text = "하..할 일 참 많네...전화가 왔네? 또 뭐야?";
            target.timerReset();
        }

        public void firstFloorNPC3()
        {
            phase++;
            target.nameCharacter.Text = "조교님";
            target.text = "여보세요? 거기 강의실 비번?\r\n거기 강의실 번호라고 알려줬었잖아!그래..고생해라..";
            target.timerReset();
        }

        public void firstFloorNPC4()
        {
            phase++;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = "조교님도 조심해야겠군.";
            target.timerReset();
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
                    string[] event_split=eventType.Split('/');
                    if (event_split.Length>1)
                    {
                        switch(event_split[1])
                        {
                            case "GetPapper1":
                                break;
                            case "GetPapper3":
                                if (phase < 1)
                                {
                                    Papper3Get2();
                                    return;
                                }
                                else { break; }
                                
                        }
                    }
                    string number_only = eventType.Substring(4,3);
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
                                if (c.Name == event_split[0])
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
                                    player.Left = room.Left + 60;
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
                string number_only=eventType.Substring(5);
                string[] number_info=number_only.Split('_');
                if (number_info[0] == "2")
                {
                    Floor2UDC tmp = new Floor2UDC();
                    Control player = null;
                    Control board = null;
                    foreach (Control c in tmp.Controls)
                    {
                        if (c.Name == "player")
                            player = c;
                        if (c.Name == eventType)
                            board = c;
                    }
                    player.Left = board.Left + 50;
                    player.Top = board.Top;
                    (target.Parent as InitMenu).ConvComeback(tmp);
                }
                else
                {
                    switch (phase)
                    {
                        case 1:
                            FourthFloorBoard2();
                            return;
                        case 2:
                            FourthFloorBoard3();
                            return;
                        default:
                            Floor4UDC tmp = new Floor4UDC();
                            Control player = null;
                            Control board = null;
                            foreach (Control c in tmp.Controls)
                            {
                                if (c.Name == "player")
                                    player = c;
                                if (c.Name == eventType)
                                    board = c;
                            }
                            player.Left = board.Left;
                            player.Top = board.Top - 50;
                            (target.Parent as InitMenu).ConvComeback(tmp);
                            return;
                    }
                }
            }
            if (eventType.StartsWith("guardroom"))
            {
                string[] event_split=eventType.Split('/');
                if (event_split[1] == "JustEnter")
                {
                    switch (phase)
                    {
                        case 1:
                            GuardRoom_JustEnter2();
                            return;
                        case 2:
                            GuardRoom_JustEnter3();
                            return;
                        default:
                            break;
                    }
                }
                else if (event_split[1]=="GetSafeCard")
                {
                    switch (phase)
                    {
                        case 1:
                            GuardRoom_GetPracticeRoomKey2();
                            return;
                        case 2:
                            GuardRoom_GetPracticeRoomKey3();
                            return;
                        case 3:
                            StaticItem.mSafekey4 = true;
                            StaticItem.inventory_set();
                            (target.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
                            GuardRoom_GetPracticeRoomKey4();
                            return;
                        default:
                            break;
                            
                    }
                }
                Floor1UDC tmp = new Floor1UDC();
                Control player = null;
                Control room = null;
                foreach (Control c in tmp.Controls)
                {
                    if (c.Name == "player")
                        player = c;
                    if (c.Name == event_split[0])
                        room = c;
                }
                player.Left = room.Left - 50;
                player.Top = room.Top;
                (target.Parent as InitMenu).ConvComeback(tmp);

            }

            if (eventType=="hintNPC_1")
            {
                switch (phase)
                {
                    case 1:
                        firstFloorNPC2();
                        return;
                    case 2:
                        firstFloorNPC3();
                        return;
                    case 3:
                        firstFloorNPC4();
                        return;
                    default:
                        break;
                }
                Floor1UDC tmp = new Floor1UDC();
                Control player = null;
                Control npc = null;
                foreach (Control c in tmp.Controls)
                {
                    if (c.Name == "player")
                        player = c;
                    if (c.Name == eventType)
                        npc = c;
                }
                player.Left = npc.Left - 50;
                player.Top = npc.Top;
                (target.Parent as InitMenu).ConvComeback(tmp);
                return;
            }
        }
        
    }
}
