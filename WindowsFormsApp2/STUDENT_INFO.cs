using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class STUDENT_INFO
    {
        public static Dictionary<string, double> all_course_grade = new Dictionary<string, double>();
        public static double total_grade = -1;
        public static string name = "아무개";
        public static List<string> low_grade_courses=new List<string>();
    }
}
