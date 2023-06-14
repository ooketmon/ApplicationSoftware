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


        public bool guardmanChasing = true;
        public bool assistantChasing = false;
        public bool assistantEvent = false;
        public bool firstStart = true;

        public bool haveSeenSecondBoard = false;
        public bool knowLab1PW=false;


        public bool knowLab2PW = false;
        public bool knowLab3PW = false;
        //public bool knowLab4PW = false;
        public bool openLecture2_1 = false;
        public bool openLab1 = false;
        public bool openLab2 = false;
        public bool openLab3 = false;
        //public bool openLab4 = false;
        
        public bool Lab2PcSolved=false;
        public bool Lab4LockCaseSolve = false;


        public int Lab1PW = 1234;
        public int Lab2PW = 5678;
        public int Lab3PW = 9876;
        public int Lab2PCPW = 8721;
        public int Lab4LockCasePW = 40;

        public int lecture2_answer = -1;
        public string lecture2_problem = "";
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



        public void ElevatorCall(int floor)
        {
            if (firstStart)
            {
                firstStart = false;
            }
            ElevatorChoiceUDC elevator = new ElevatorChoiceUDC(floor);
            
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
            Random random = new Random();
            lecture2_answer = random.Next(128);
            for (int i = 7; i >= 0; i--)
            {
                lecture2_problem += ((lecture2_answer >> i) & 1).ToString();
            }
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
                if (c.GetType() == typeof(Floor8UDC) || c.GetType()==typeof(Floor2UDC))
                {
                    var allControls = c.Controls;
                    foreach(Control c2 in allControls)
                    {
                        if (c2.GetType() == typeof(puzzle))
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

    }
}
