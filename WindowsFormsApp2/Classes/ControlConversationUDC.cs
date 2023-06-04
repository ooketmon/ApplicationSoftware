using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
        public void Department_Init(string deptinfo)
        {
            eventType= deptinfo;
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            phase = 1;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = string.Format("여긴 4층 과사무실이다.");
            Room_department dept= new Room_department(this);
            target.Controls.Add(dept);
            
            dept.Top -= target.imgConvWindowBack.Height;
            dept.SendToBack();
            dept.BackColor = Color.Transparent;
            target.imgCharacter.Visible = false;
            target.imgCharBack.Visible = false;
        }
        public void Practice_Init(string practiceinfo)
        {
            eventType = practiceinfo;
            string[] number_info = eventType.Substring(8).Split('_');
            phase = 1;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = string.Format("여긴 {0}층 {1}실습실이다.", number_info[0], number_info[1]);
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            if (number_info[1] == "4")
            {
                Room_practice4 practice = new Room_practice4(this);
                target.Controls.Add(practice);
                practice.SendToBack();
                practice.BackColor = Color.Transparent;
                target.imgCharacter.Visible = false;
                target.imgCharBack.Visible = false;
            }
            else
            {
                target.BackgroundImage = Properties.Resources.practice_room_2;
                target.imgCharacter.Image = Properties.Resources.player_anime_ver;
                target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void MeetingPlaceInit(string placeinfo)
        {
            phase=1;
            eventType = placeinfo;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = string.Format("이건 2층 만남의 장소다.");
            Room_StartupClub3 meetingPlace = new Room_StartupClub3(this);
            target.Controls.Add(meetingPlace);
            meetingPlace.SendToBack();
            meetingPlace.BackColor = Color.Transparent;
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            target.imgCharacter.Visible = false;
            target.imgCharBack.Visible = false;
        }
        public void BoardInit(string board_info)
        {
            eventType = board_info;
            phase++;
            string number_only = board_info.Substring(5);
            string[] number_info = number_only.Split('_');
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            
            target.contentConv.Text= string.Format("이건 {0}층 게시판인 것 같다.", number_info[0]);

            Room_Board board_background = new Room_Board(this);
            var allControls = board_background.Controls;
            if (number_info[0] == "2")//2층
            {
                foreach(Control c in allControls)
                {
                    if (c.Name == "Poster_4")
                    {
                        board_background.Controls.Remove(c);
                        break;
                    }
                }
            }
            else//4층
            {
                foreach (Control c in allControls)
                {
                    if (c.Name == "Poster_1")
                    {
                        board_background.Controls.Remove(c);
                        break;
                    }
                }
            }
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

        public void FourthFloorBoard1()
        {
            phase++;
            (target.Parent as InitMenu).havetoGoGuardRoom = true;
            eventType += "/Poster4";
            target.nameCharacter.Text = STUDENT_INFO.name;
            target.text = string.Format("흠...경비 아저씨...주무시려나?");
            target.timerReset();
        }




        public void LabInit(string lab_info)
        {
            eventType = lab_info;
            string number_only = lab_info.Substring(3);
            string[] number_info = number_only.Split('_');
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = string.Format("여기는 8층 {0}연구실인 것 같다.",  number_info[1]);
            phase++;
            Control room = null;
            switch (number_info[1])
            {
                case "1":
                    room = new Room_lab1(this);
                    break;
                case "2":
                    room = new Room_lab2(this);
                    break;
                case "3":
                    room = new Room_lab3(this);
                    break;
                case "4":
                    room = new Room_lab4(this);
                    break;
            }
            target.Controls.Add(room);
            room.SendToBack();
            room.BackColor = Color.Transparent;
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
            eventType += "/GetTest3";
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

        public void SayNothing()
        {
            phase=1;
            target.nameCharacter.Text=STUDENT_INFO.name;
            target.text = "-";
            target.timerReset();
        }

        public void SecondFloorCodeOff()
        {
            Control to_delete = null;
            foreach(Control c in target.Controls)
            {
                if (c.GetType() == typeof(ShowCode))
                {
                    to_delete = c;
                }
                if (c.GetType() == typeof(Room_lecture2))
                {
                    c.Enabled = true;
                }
            }
            target.Controls.Remove(to_delete);
            SayNothing();
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
            StaticItem.mSafekey4 = true;
            StaticItem.inventory_set();
            (target.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
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
            phase = 1;
            eventType = room_info;
            string number_only = room_info.Substring(4);
            string[] number_info = number_only.Split('_');
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text= string.Format("여기는 {0}층 {1}호실인 것 같다.", number_info[0], number_info[1]);
            //여기 부분은 switch문이나 if문으로 서로 다른 강의실을 호출할 수도 있습니다.
            int room_no_info = Convert.ToInt32(number_info[1]);
            Control room_background = null;
            switch (room_no_info)
            {
                case 1:
                    room_background = new Room_lecture1(this);
                    break;
                case 2:
                    room_background=new Room_lecture2(this);
                    break;
                case 3:
                    room_background=new Room_lecture3(this);
                    break;
                default:
                    target.BackgroundImage = Properties.Resources.lecture_room;
                    target.imgCharacter.Image = Properties.Resources.player_anime_ver;
                    target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
                    return;
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
        public void SecondFloorBoard1()
        {
            GetRidofEventSplit();
            eventType += "/Poster1";
            target.nameCharacter.Text = STUDENT_INFO.name;
            target.text = string.Format("흠...누가 포스터를 찢은거야?");
            target.timerReset();
        }

        public void Poster3Get1()
        {
            phase++;
            eventType += "/GetPoster3";
            foreach(Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "▶";
                }
            }
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("강의실에 포스터가 있네? 뭐지?");
            target.timerReset();
        }

        public void Poster3Get2()
        {
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            phase++;
            target.nameCharacter.Text = "System";
            StaticItem.mPoster3 = true;
            StaticItem.inventory_set();
            (target.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
            target.text = string.Format("연구실 홍보 포스터를 발견했다.");
            target.timerReset();
        }

        public void SecondFloorCardKeyGet1()
        {
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "▶";
                }
            }
            GetRidofEventSplit();
            phase = 2;
            eventType += "/GetSecondFloorCardKey";
            target.nameCharacter.Text = string.Format("{0}",STUDENT_INFO.name);
            target.text = string.Format("카드 키를 찾았다. 어디를 열 수 있는 걸까?");
            target.timerReset();
        }

        public void SecondFloorCardKeyGet2()
        {
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            phase++;
            target.nameCharacter.Text = "System";
            target.text = string.Format("강의실 카드키를 얻었다.");
            target.timerReset();
        }



        public void SecondFloorNPC1()
        {
            GetRidofEventSplit();
            phase=2;
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "▶";
                }
            }
            eventType += "/SecondNPC";
            target.nameCharacter.Text ="대학원생";
            target.text = string.Format("…zzzZ..zZ.zZz…");
            target.timerReset();
        }

        public void SecondFloorNPC2()
        {
            phase++;
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
            }
            target.nameCharacter.Text = "대학원생";
            target.text = string.Format("네 교수님, 실습실4, 연구실4 과사에 놓고 왔.. 습니 …\r\nzzZZZ.z..zZZZ…");
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
            target.text = "쪽지를 얻었다.\r\n인벤토리에서 확인 가능하다.";
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

        public void Room2_2Puzzle()
        {
            GetRidofEventSplit();
            eventType += "/Room2-2Puzzle";
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("이게 뭐지? 비밀번호인가?");
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "";
                }
                if ((c.GetType().ToString()).Contains("Room_lecture2"))
                {
                    c.Enabled = false;
                }
            }
            puzzle p=new puzzle("PC_2",this);
            target.Controls.Add(p);
            p.Top = target.Height/2-p.Height/2;
            p.Left = target.Width / 2 - p.Width / 2;
            p.BringToFront();
            target.timerReset();

        }

        public void Room2_2PuzzleSolved()
        {
            GetRidofEventSplit();
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("비밀번호인 것 같은데?");
            Control to_delete = null;
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
                if (c.GetType() == typeof(puzzle))
                {
                    to_delete = c;
                }
                if (c.GetType() == typeof(Room_lecture2))
                {
                    c.Enabled = false;
                }
            }
            if(!(this.target.Parent as InitMenu).knowLab2PW)
            {
                (this.target.Parent as InitMenu).knowLab2PW = true;
            }
            if (to_delete != null)
            {
                target.Controls.Remove(to_delete);
            }
            ShowCode pw = new ShowCode(this);
            pw.Top = target.Height / 2 - pw.Height / 2;
            pw.Left = target.Width / 2 - pw.Width / 2;
            target.Controls.Add(pw);
            pw.BringToFront();
            target.timerReset();
        }

        public void Room2_2PuzzleWrong()
        {
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("아닌 모양이야.");
            target.timerReset();
        }

        public void Room2_2PuzzleQuit()
        {
            GetRidofEventSplit();
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.text = string.Format("나중에 다시 풀자.");
            Control to_delete = null;
            foreach (Control c in target.Controls)
            {
                if (c.Name == "btnSkip")
                {
                    c.Text = "나가기";
                }
                if (c.GetType() == typeof(puzzle))
                {
                    to_delete = c;
                }
                if (c.GetType() == typeof(Room_lecture2))
                {
                    c.Enabled= true;
                }
            }
            target.Controls.Remove(to_delete);
            target.timerReset();
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
                                if (phase < 3)
                                {
                                    Papper3Get2();
                                    return;
                                }

                                break; 
                                
                            case "GetPoster3":
                                if (phase < 3)
                                {
                                    Poster3Get2();
                                    return;
                                }
                                break;
                            case "Room2-2Puzzle":
                                return;

                        }
                    }
                    GetRidofEventSplit();
                    string number_only = eventType.Substring(4,3);
                    string[] number_info = number_only.Split('_');
                    Control player = null;
                    Control room = null;

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


                    
                
                return;
            }

            if (eventType.StartsWith("board"))
            {
                string[] event_split = eventType.Split('/');
                string number_only=eventType.Substring(5);
                string[] number_info=number_only.Split('_');
                if (number_info[0] == "2")//2층
                {
                    Floor2UDC tmp = new Floor2UDC();
                    Control player = null;
                    Control board = null;
                    foreach (Control c in tmp.Controls)
                    {
                        if (c.Name == "player")
                            player = c;
                        if (c.Name == event_split[0])
                            board = c;
                    }
                    player.Left = board.Left + 50;
                    player.Top = board.Top;
                    (target.Parent as InitMenu).ConvComeback(tmp);

                }
                else//4층
                {

                        Floor4UDC tmp = new Floor4UDC();
                        Control player = null;
                        Control board = null;
                        foreach (Control c in tmp.Controls)
                        {
                            if (c.Name == "player")
                                player = c;
                            if (c.Name == event_split[0])
                                board = c;
                        }
                        player.Left = board.Left;
                        player.Top = board.Top - 50;
                        (target.Parent as InitMenu).ConvComeback(tmp);
                        return;
                    
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

            if (eventType.StartsWith("meetingplace"))
            {
                string[] event_split = eventType.Split('/');
                if(event_split.Length > 1 && event_split[1]== "SecondNPC"&& phase<3) {
                    SecondFloorNPC2();
                    return;   
                }
                if (event_split.Length > 1 && event_split[1] == "GetSecondFloorCardKey" && phase < 3)
                {
                    SecondFloorCardKeyGet2();
                    return;
                }
                GetRidofEventSplit();   
                Floor2UDC tmp = new Floor2UDC();
                Control player = null;
                Control place = null;
                foreach (Control c in tmp.Controls)
                {
                    if (c.Name == "player")
                        player = c;
                    if (c.Name == eventType)
                        place = c;
                }
                player.Left = place.Left;
                player.Top = place.Top+60;
                (target.Parent as InitMenu).ConvComeback(tmp);
                return;
            }

            if (eventType.StartsWith("practice"))
            {
                GetRidofEventSplit();
                Floor3UDC tmp = new Floor3UDC();
                Control player = null;
                Control room = null;
                foreach (Control c in tmp.Controls)
                {
                    if (c.Name == "player")
                        player = c;
                    if (c.Name == eventType)
                        room = c;
                }
                player.Left = room.Left;
                player.Top = room.Top - 50;
                (target.Parent as InitMenu).ConvComeback(tmp);
            }

            if (eventType == "department")
            {
                GetRidofEventSplit();
                Floor4UDC tmp = new Floor4UDC();
                Control player = null;
                Control room = null;
                foreach (Control c in tmp.Controls)
                {
                    if (c.Name == "player")
                        player = c;

                    if (c.Name == eventType)
                        room = c;
                }
                player.Left = room.Left;
                player.Top = room.Top - 50;
                (target.Parent as InitMenu).ConvComeback(tmp);

            }

            if (eventType.StartsWith("lab"))
            {
                string[] event_split = eventType.Split('/');
                if (event_split.Length > 1 && event_split[1] == "GetTest1" && phase==2)
                {
                    Test1Get2();
                    return;
                }
                if (event_split.Length > 1 && event_split[1] == "GetTest3" && phase == 2)
                {
                    Test3Get2();
                    return;
                }
                GetRidofEventSplit();
                Floor8UDC tmp = new Floor8UDC();
                Control player = null;
                Control room = null;
                foreach (Control c in tmp.Controls)
                {
                    if(c.Name=="player")
                        player = c;
                    if(c.Name==eventType)
                        room = c;
                }

                if (room.Left <= 250 && room.Top <= 300)
                {
                    player.Left = room.Left + 70;
                    player.Top = room.Top;
                }
                else if (room.Left >= 800 && room.Top <= 300)
                {
                    player.Left = room.Left - 70;
                    player.Top = room.Top;
                }
                else if (room.Top > 300)
                {
                    player.Left = room.Left;
                    player.Top = room.Top - 70;
                }
                (target.Parent as InitMenu).ConvComeback(tmp);
            }
        }
        
    }
}
