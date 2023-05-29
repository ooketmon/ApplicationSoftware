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
        public bool floor8MissionComplete = false;
        public bool floor1MissionComplete = false;
        public bool guardmanChasing = false;
        public bool assistantChasing = true;

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
        public void CallPrologue()
        {
            this.Controls.Clear();
            this.Controls.Add(new ConvModeUDC());
        }
        public void ElevatorCall(int floor)
        {
            
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
        private void InitMenu_Load(object sender, EventArgs e)
        {
            CallMainMenu(); 
        }
        public void GoToLogin()
        {
            this.Controls.Clear();
            this.Controls.Add(new LoginStartUDC());

        }

    }
}
