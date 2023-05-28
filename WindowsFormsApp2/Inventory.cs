using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }


        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }

    class Inven
    {
        bool[] inventory = new bool[11];
        

        public Inven()
        {
            for(int i = 0; i < 11; i++){
                inventory[i] = false;
            }
        }
    }

    class Item
    {
        //1. 게시판 - 강의실1 - 연구실1 관련 item
        bool mPapper1;
        bool mTest1;
        public bool Papper_1
        {
            get { return mPapper1; }
            set { mPapper1 = value; }
        }
        public bool Test_1
        {
            get { return mTest1; }
            set { mTest1 = value; }
        }
        //2. 강의실2 - 연구실2 관련 item
        bool mTest2;
        public bool Test_2
        {
            get { return mTest2; }
            set { mTest2 = value; }
        }
        //3. 창업동아리 - 강의실3 - 연구실3 관련 item
        bool mPapper3;
        bool mCardkey3;
        bool mPoster3;
        bool mTest3;
        public bool Papper_3
        {
            get { return mPapper3; }
            set { mPapper3 = value; }
        }
        public bool Cardkey_3
        {
            get { return mCardkey3; }
            set { mCardkey3 = value; }
        }
        public bool Poster_3
        {
            get { return mPoster3; }
            set { mPoster3 = value; }
        }
        public bool Test_3
        {
            get { return mTest3; }
            set { mTest3 = value; }
        }
        //4. 과사 - 경비실 - 실습실 - 연구실4 관련 item
        bool mPapper4;
        bool mSafekey4;
        bool mKey4;
        bool mTest4;
        public bool Papper_4
        {
            get { return mPapper4; }
            set { mPapper4 = value; }
        }
        public bool Safekey_4
        {
            get { return mSafekey4; }
            set { mSafekey4 = value; }
        }
        public bool Key_4
        {
            get { return mKey4; }
            set { mKey4 = value; }
        }
        public bool Test_4
        {
            get { return mTest4; }
            set { mTest4 = value; }
        }
        //5. 대학원 강의실 관련 item
        bool mCardkey5;
        public bool Cardkey_5
        {
            get { return mCardkey5; }
            set { mCardkey5 = value; }
        }

    }
}
