using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class StaticItem
    {
        public static bool[] inventory = new bool[12];
        public static string[] items = new string[12] { "Papper_1","Test_1","Test_2","Papper_3","Cardkey_3","Poster_3","Test_3","Papper_4","Safecard_4","Key_4","Test_4","Cardkey_5"};

        //1. 게시판 - 강의실1 - 연구실1 관련 item
        public static bool mPapper1 = false;
        public static bool mTest1 = false;

        //2. 강의실2 - 연구실2 관련 item
        public static bool mTest2 = false;

        //3. 창업동아리 - 강의실3 - 연구실3 관련 item
        public static bool mPapper3 = false;
        public static bool mCardkey3 = false;
        public static bool mPoster3 = false;
        public static bool mTest3 = false;

        //4. 과사 - 경비실 - 실습실 - 연구실4 관련 item
        public static bool mPapper4 = false;
        public static bool mSafekey4 = false;
        public static bool mKey4 = false;
        public static bool mTest4 = false;

        //5. 대학원 강의실 관련 item
        public static bool mCardkey5 = false;

        public static void inventory_set() 
        {
            inventory[0] = mPapper1;
            inventory[1] = mTest1;
            inventory[2] = mTest2;
            inventory[3] = mPapper3;
            inventory[4] = mCardkey3;
            inventory[5] = mPoster3;
            inventory[6] = mTest3;
            inventory[7] = mPapper4;
            inventory[8] = mSafekey4;
            inventory[9] = mKey4;
            inventory[10] = mTest4;
            inventory[11] = mCardkey5;
        }

        public static void inventory_reset()
        {
            mPapper1=false;
             mTest1=false;
            mTest2= false;
             mPapper3 = false;
           mCardkey3 = false;
           mPoster3 = false;
            mTest3 = false;
            mPapper4 = false;
          mSafekey4 = false;
            mKey4 = false;
             mTest4 = false;
             mCardkey5 = false;
            inventory_set();
        }
    }
}
