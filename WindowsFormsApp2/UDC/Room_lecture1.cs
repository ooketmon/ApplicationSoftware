using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WindowsFormsApp2.StaticItem;

namespace WindowsFormsApp2
{
    public partial class Room_lecture1 : UserControl
    {
        ControlConversationUDC controller=null;

        public Room_lecture1(ControlConversationUDC ctrl)
        {
            InitializeComponent();

            Papper_1.BackColor = Color.Transparent;
            Papper_1.Parent = lecture1;

            controller= ctrl;
        }
        private void Papper1_Click(object sender, EventArgs e)
        {
            // 단서 papper1 함수 _ 클릭 이벤트 발생시
            mPapper1 = true;
            inventory_set();
            Papper_1.Visible = false;
            (this.Parent.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
            (this.Parent.Parent as InitMenu).CheckTestComplete();
            if((this.Parent.Parent as InitMenu).haveSeenSecondBoard)
            {
                (this.Parent.Parent as InitMenu).knowLab1PW=true;
            }
            controller.Papper1Get();
            
        }

        private void Room_lecture1_Load(object sender, EventArgs e)
        {
            if (mPapper1)
            {
                Papper_1.Visible = false;
            }
        }
    }
}
