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

namespace WindowsFormsApp2.UDC
{
    public partial class Room_lab2 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_lab2(ControlConversationUDC controller)
        {
            InitializeComponent();

            Printer_2.BackColor = Color.Transparent;
            Printer_2.Parent = lab2;
            this.controller = controller;

<<<<<<< HEAD
=======
            labPC_2.BackColor = Color.Transparent;
            labPC_2.Parent = lab2;

            this.KeyDown += Inventory_KeyDown; // 이벤트 핸들러 등록
>>>>>>> 791256f5d9e92b193cb68c9c8ec92481883244fe
        }
        public void labPC2_Click(object sender, EventArgs e) 
        { 
            //클릭 시 힌트화면과 입력화면이 보이는 PC UDC화면이 나옴
            //정답을 입력할 경우 '출력' button이 있는 화면 등장
            //출력을 클릭한 후 프린터기를 클릭하면 시험지가 인벤토리에 저장
        }


        public void Printer2_Click(object sender, EventArgs e)
        {
            // 단서 Printer2 함수 _ 클릭 이벤트 발생시
            // PC에서 button을 클릭한 후에 실행이 되도록
            mTest1 = true;
            inventory_set();
            (this.Parent as InitMenu).inventory.Inventory_ItemVisibility_Check();
        }

    }
}
