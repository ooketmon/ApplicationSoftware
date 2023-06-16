using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.UDC;

namespace WindowsFormsApp2
{
    public partial class InitMenu : Form
    {

        public bool haveSeenFourthBoard = false;
        public bool havetoGoGuardRoom = false;


        public bool guardmanChasing = false;
        public bool assistantChasing = false;
        public bool assistantEvent = false;
        public bool firstStart = true;

        public bool haveSeenSecondBoard = false;
        public bool knowLab1PW=false;

        public bool knowLab2PW = false;
        public bool knowLab3PW = false;

        public bool openLecture2_1 = false;
        public bool openLab1 = false;
        public bool openLab2 = false;
        public bool openLab3 = false;

        public bool openPractice1 = false;
        public bool openPractice2 = false;
        public bool openPractice3 = false;
        public bool openPractice4 = false;

        public bool Lab2PcSolved=false;
        public bool Lab4LockCaseSolve = false;

        public Inventory inventory = new Inventory();

        public InitMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void CallMainMenu()
        {
            this.Controls.Clear();
            this.Controls.Add(new InitWindow());
        }

        public void FloorChange(int floor)
        {
            this.Controls.Clear();
            Control tmp = null;
            switch (floor)
            {
                case 1:

                    tmp = new Floor1UDC();
                    if (!firstStart)
                    {
                        Control player = null;
                        Control elevator = null;
                        foreach (Control c in tmp.Controls)
                        {
                            if (c.Name == "player")
                            {
                                player = c;
                            }
                            if (c.Name.Contains("elevator"))
                            {
                                elevator = c;
                            }

                        }

                        player.Left = elevator.Left + 100;
                        player.Top = elevator.Top;
                    }
                    this.Controls.Add(tmp);
                    break;
                case 2:
                    tmp = new Floor2UDC();
                    this.Controls.Add(tmp);
                    break;
                case 3:
                    tmp = new Floor3UDC();
                    this.Controls.Add(tmp);
                    break;
                case 4:
                    tmp = new Floor4UDC();
                    this.Controls.Add(tmp);
                    break;
                case 8:
                    tmp = new Floor8UDC();
                    this.Controls.Add(tmp);
                    break;
            }
            tmp.Focus();

        }

        public void FloorChangeForBackElevator(int floor)
        {
            this.Controls.Clear();
            Control tmp = null;
            switch (floor)
            {
                case 1:

                    tmp = new Floor1UDC();
                    if (!firstStart)
                    {
                        Control player = null;
                        Control elevator = null;
                        foreach (Control c in tmp.Controls)
                        {
                            if (c.Name == "player")
                            {
                                player = c;
                            }
                            if (c.Name.Contains("elevator"))
                            {
                                elevator = c;
                            }

                        }

                        player.Left = elevator.Left;
                        player.Top = elevator.Top+55;
                    }
                    this.Controls.Add(tmp);
                    break;
                case 2:
                    tmp = new Floor2UDC();

                    Control player2 = null;
                    Control elevator2 = null;
                    foreach (Control c in tmp.Controls)
                    {
                        if (c.Name == "player")
                        {
                            player2 = c;
                        }
                        if (c.Name=="back_elevator")
                        {
                            elevator2 = c;
                        }

                    }

                    player2.Left = elevator2.Left;
                    player2.Top = elevator2.Top + 65;
                    
                    this.Controls.Add(tmp);
                    break;
                case 3:
                    tmp = new Floor3UDC();
                    Control player3 = null;
                    Control elevator3 = null;
                    foreach (Control c in tmp.Controls)
                    {
                        if (c.Name == "player")
                        {
                            player3 = c;
                        }
                        if (c.Name == "back_elevator")
                        {
                            elevator3 = c;
                        }

                    }
                    player3.Left = elevator3.Left;
                    player3.Top = elevator3.Top + 65;
                    this.Controls.Add(tmp);
                    break;
                case 4:
                    tmp = new Floor4UDC();
                    Control player4 = null;
                    Control elevator4 = null;
                    foreach (Control c in tmp.Controls)
                    {
                        if (c.Name == "player")
                        {
                            player4 = c;
                        }
                        if (c.Name == "back_elevator")
                        {
                            elevator4 = c;
                        }

                    }
                    player4.Left = elevator4.Left;
                    player4.Top = elevator4.Top + 65;
                    this.Controls.Add(tmp);
                    break;
                case 8:
                    tmp = new Floor8UDC();
                    Control player8 = null;
                    Control elevator8 = null;
                    foreach (Control c in tmp.Controls)
                    {
                        if (c.Name == "player")
                        {
                            player8 = c;
                        }
                        if (c.Name == "back_elevator")
                        {
                            elevator8 = c;
                        }

                    }
                    player8.Left = elevator8.Left;
                    player8.Top = elevator8.Top + 65;
                    this.Controls.Add(tmp);
                    break;
            }
            tmp.Focus();

        }

        public void ResetAll()
        {
            haveSeenFourthBoard = false;
            havetoGoGuardRoom = false;


            guardmanChasing = false;
            assistantChasing = false;
            assistantEvent = false;
            firstStart = true;

            haveSeenSecondBoard = false;
            knowLab1PW = false;

            knowLab2PW = false;
            knowLab3PW = false;

            openLecture2_1 = false;
            openLab1 = false;
            openLab2 = false;
            openLab3 = false;

            openPractice1 = false;
            openPractice2 = false;
            openPractice3 = false;
            openPractice4 = false;

            Lab2PcSolved = false;
            Lab4LockCaseSolve = false;
            STUDENT_INFO.ResetStudentInfo();
            StaticItem.inventory_reset();


        }

        public void ElevatorCall(int floor)
        {
            if (firstStart)
            {
                firstStart = false;
            }
            ElevatorChoiceUDC elevator = new ElevatorChoiceUDC(floor,"front");
            
            Control main_floor = null;
            foreach(Control ctrl in this.Controls)
            {
                main_floor = ctrl;
            }

            switch (floor)
            {
                
                case 1:
                    Floor1UDC target1=(main_floor as Floor1UDC);
                    Control character1 = null;
                    foreach (Control item in target1.Controls)
                    {
                        if (item.Name == "elevator")
                        {
                            character1 = item;
                            break;
                        }
                    }
                    elevator.Left = character1.Left - 100;
                    elevator.Top= character1.Top;
                    break;
                case 2:
                    Floor2UDC target2 = (main_floor as Floor2UDC);
                    Control character2 = null;
                    foreach (Control item in target2.Controls)
                    {
                        if (item.Name == "elevator")
                        {
                            character2 = item;
                            break;
                        }
                    }
                    elevator.Left = character2.Left-100;
                    elevator.Top = character2.Top;
                    break;
                case 3:
                    Floor3UDC target3 = (main_floor as Floor3UDC);
                    Control character3 = null;
                    foreach (Control item in target3.Controls)
                    {
                        if (item.Name == "elevator")
                        {
                            character3 = item;
                            break;
                        }
                    }
                    elevator.Left = character3.Left - 100;
                    elevator.Top = character3.Top;
                    break;
                case 4:
                    Floor4UDC target4 = (main_floor as Floor4UDC);
                    Control character4 = null;
                    foreach (Control item in target4.Controls)
                    {
                        if (item.Name == "elevator")
                        {
                            character4= item;
                            break;
                        }
                    }
                    elevator.Left = character4.Left - 100;
                    elevator.Top = character4.Top;
                    break;
                case 8:
                    Floor8UDC target8 = (main_floor as Floor8UDC);
                    Control character8 = null;
                    foreach (Control item in target8.Controls)
                    {
                        if (item.Name == "elevator")
                        {
                            character8 = item;
                            break;
                        }
                    }
                    elevator.Left = character8.Left - 100;
                    elevator.Top = character8.Top;
                    
                    break;
            }
            this.Controls.Add(elevator);
            elevator.BringToFront();
            elevator.Focus();

        }

        public void BackElevatorCall(int floor)
        {
            if (firstStart)
            {
                firstStart = false;
            }
            ElevatorChoiceUDC elevator = new ElevatorChoiceUDC(floor,"back");

            Control main_floor = null;
            foreach (Control ctrl in this.Controls)
            {
                main_floor = ctrl;
            }

            switch (floor)
            {

                case 1:
                    Floor1UDC target1 = (main_floor as Floor1UDC);
                    Control character1 = null;
                    foreach (Control item in target1.Controls)
                    {
                        if (item.Name == "back_elevator")
                        {
                            character1 = item;
                            break;
                        }
                    }
                    elevator.Left = character1.Left - 50;
                    elevator.Top = character1.Top+50;
                    break;
                case 2:
                    Floor2UDC target2 = (main_floor as Floor2UDC);
                    Control character2 = null;
                    foreach (Control item in target2.Controls)
                    {
                        if (item.Name == "back_elevator")
                        {
                            character2 = item;
                            break;
                        }
                    }
                    elevator.Left = character2.Left-50;
                    elevator.Top = character2.Top+50;
                    break;
                case 3:
                    Floor3UDC target3 = (main_floor as Floor3UDC);
                    Control character3 = null;
                    foreach (Control item in target3.Controls)
                    {
                        if (item.Name == "back_elevator")
                        {
                            character3 = item;
                            break;
                        }
                    }
                    elevator.Left = character3.Left-50;
                    elevator.Top = character3.Top+100;
                    break;
                case 4:
                    Floor4UDC target4 = (main_floor as Floor4UDC);
                    Control character4 = null;
                    foreach (Control item in target4.Controls)
                    {
                        if (item.Name == "back_elevator")
                        {
                            character4 = item;
                            break;
                        }
                    }
                    elevator.Left = character4.Left - 50;
                    elevator.Top = character4.Top+50;
                    break;
                case 8:
                    Floor8UDC target8 = (main_floor as Floor8UDC);
                    Control character8 = null;
                    foreach (Control item in target8.Controls)
                    {
                        if (item.Name == "back_elevator")
                        {
                            character8 = item;
                            break;
                        }
                    }
                    elevator.Left = character8.Left - 50;
                    elevator.Top = character8.Top+50;

                    break;
            }
            this.Controls.Add(elevator);
            elevator.BringToFront();
            elevator.Focus();

        }
        public void StairCall(int floor)
        {
            if (firstStart)
            {
                firstStart = false;
            }
            StairChoice stair = new StairChoice(floor);
            Control main_floor = null;
            foreach(Control ctrl in this.Controls)
            {
                main_floor = ctrl;
            }
            switch (floor)
            {

                case 1:
                    Floor1UDC target1 = (main_floor as Floor1UDC);
                    Control character1 = null;
                    foreach (Control item in target1.Controls)
                    {
                        if (item.Name == "stair")
                        {
                            character1 = item;
                            break;
                        }
                    }
                    stair.Left = character1.Left-220;
                    stair.Top = character1.Top;
                    break;
                case 2:
                    Floor2UDC target2 = (main_floor as Floor2UDC);
                    Control character2 = null;
                    foreach (Control item in target2.Controls)
                    {
                        if (item.Name == "stair")
                        {
                            character2 = item;
                            break;
                        }
                    }
                    stair.Left = character2.Left - 100;
                    stair.Top = character2.Top;
                    break;
                case 3:
                    Floor3UDC target3 = (main_floor as Floor3UDC);
                    Control character3 = null;
                    foreach (Control item in target3.Controls)
                    {
                        if (item.Name == "stair")
                        {
                            character3 = item;
                            break;
                        }
                    }
                    stair.Left = character3.Left - 100;
                    stair.Top = character3.Top;
                    break;
                case 4:
                    Floor4UDC target4 = (main_floor as Floor4UDC);
                    Control character4 = null;
                    foreach (Control item in target4.Controls)
                    {
                        if (item.Name == "stair")
                        {
                            character4 = item;
                            break;
                        }
                    }
                    stair.Left = character4.Left - 100;
                    stair.Top = character4.Top;
                    break;
                /*case 8:
                    Floor8UDC target8 = (main_floor as Floor8UDC);
                    Control character8 = null;
                    foreach (Control item in target8.Controls)
                    {
                        if (item.Name == "stair")
                        {
                            character8 = item;
                            break;
                        }
                    }
                    elevator.Left = character8.Left - 100;
                    elevator.Top = character8.Top;
                    break;*/
            }
            this.Controls.Add(stair);
            stair.BringToFront();
            stair.Focus();
        }

        public void ConvComeback(Control floor)
        {
            Controls.Clear();
            Controls.Add(floor);
            floor.Focus();
        }

        public void CallConvMode(string place)
        {
            Controls.Clear();
            ConvModeUDC tmp = new ConvModeUDC(place);
            Controls.Add(tmp);
            tmp.Focus();
        }
        private void InitMenu_Load(object sender, EventArgs e)
        {
            CallMainMenu();
        }
        public void GoToLogin()
        {
            this.Controls.Clear();
            this.Controls.Add(new LoginStartUDC());

        }

        public void GetRidofPuzzleInFloor()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Floor8UDC) || c.GetType()==typeof(Floor2UDC) || c.GetType()==typeof(Floor3UDC))
                {
                    var allControls = c.Controls;
                    foreach(Control c2 in allControls)
                    {
                        if (c2.GetType() == typeof(Doorlock))
                        {
                            c.Controls.Remove(c2);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public void CheckTestComplete()
        {
            if(StaticItem.mTest1 && StaticItem.mTest2 && StaticItem.mTest3 && StaticItem.mTest4 && !assistantChasing && !guardmanChasing)
            {
                assistantChasing = true;
                guardmanChasing = true;
            }
        }

        public void CallEndingFail(string whoCatchMe)
        {
            this.Controls.Clear();
            this.Controls.Add(new EndingFail(whoCatchMe));
        }

        public void CallEndingSucceed()
        {
            this.Controls.Clear();
            this.Controls.Add(new EndingSucceed());
        }

    }
}
