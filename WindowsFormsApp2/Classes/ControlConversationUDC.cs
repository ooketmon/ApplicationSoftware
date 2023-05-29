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
            eventType = "prologue";
            target.nameCharacter.Text = string.Format("{0}",STUDENT_INFO.name);
            target.contentConv.Text ="이렇게 된 이상 어쩔 수 없지..";
            target.BackgroundImage = Properties.Resources.s_1;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void BoardInit(string board_info)
        {

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
            target.contentConv.Text = string.Format("여기는 {0}층 {1}호실인 것 같다.", number_info[0], number_info[1]);
            Room_lecture1 room_background = new Room_lecture1();
            target.Controls.Add(room_background);
            room_background.Dock= DockStyle.Fill;
            room_background.SendToBack();
            room_background.BackColor = Color.Transparent;
            //target.BackgroundImage = Properties.Resources.s_1;
            //target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            //target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            target.imgCharacter.Visible=false;
            target.imgCharBack.Visible = false;
        }
        public void RoomPhase2()
        {
            phase++;
            target.nameCharacter.Text = string.Format("{0}", STUDENT_INFO.name);
            target.contentConv.Text = "별 게 없으니 나가보자.";
            target.BackgroundImage = Properties.Resources.s_1;
            target.imgCharacter.Image = Properties.Resources.player_anime_ver;
            target.imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;

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
                (target.Parent as InitMenu).FloorChange(1);
                return;
            }
            if (eventType.StartsWith("room"))
            {
                if (phase < 2)
                {
                    RoomPhase2();
                    return;
                }
                else
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
                                {
                                    player = c;
                                }
                                if (c.Name == eventType)
                                {
                                    room = c;
                                }
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
                                {
                                    player = c;
                                }
                                if (c.Name == eventType)
                                {
                                    room = c;
                                }
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
                                {
                                    player = c;
                                }
                                if (c.Name == eventType)
                                {
                                    room = c;
                                }
                            }
                            player.Left = room.Left;
                            player.Top = room.Top - 50;
                            (target.Parent as InitMenu).ConvComeback(tmp3);
                            break;
                        case 8:
                            break;

                    }
                    
                }
            }
        }
    }
}
