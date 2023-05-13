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
    public partial class crawling_test : Form
    {
        public crawling_test()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            web_view.Source = new Uri("https://klas.kw.ac.kr");
        }

        private async void web_view_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (web_view.Source.ToString() == "https://klas.kw.ac.kr/std/cmn/frame/Frame.do")
            {
                textBox1.Left = web_view.Left;
                textBox1.Top = web_view.Top;
                web_view.Hide();
                web_view.Source = new Uri("https://klas.kw.ac.kr/std/cps/inqire/AtnlcScreStdPage.do");
            }
            if (web_view.Source.ToString() == "https://klas.kw.ac.kr/std/cps/inqire/AtnlcScreStdPage.do")
            {

                var res = await web_view.ExecuteScriptAsync("document.getElementsByClassName('tablegw')[2].getElementsByTagName('td')[13].innerText;");
                res = res.Replace('"', ' ').Trim();
                if (res != "null" && !String.IsNullOrEmpty(res) && !String.IsNullOrWhiteSpace(res))
                {
                    try
                    {
                        STUDENT_INFO.total_grade = Double.Parse(res);
                    }
                    catch
                    {
                        //비동기적 처리를 하기 때문에 오류 메시지 발생하지만 결과적으로는 정상 작동한다. 일부러 비워두었다.
                    }
                }
                res = await web_view.ExecuteScriptAsync("document.getElementsByClassName('tablegw')[0].getElementsByTagName('tbody')[0].getElementsByTagName('td')[3].innerText");
                res = res.Replace('"', ' ').Trim();
                if (res != "null" && !String.IsNullOrEmpty(res) && !String.IsNullOrWhiteSpace(res))
                {
                    try
                    {
                        STUDENT_INFO.name = res;
                    }
                    catch
                    {
                        //비동기적 처리를 하기 때문에 오류 메시지 발생하지만 결과적으로는 정상 작동한다. 일부러 비워두었다.
                    }
                }

                res = await web_view.ExecuteScriptAsync("document.getElementsByClassName('AType').length");
                int atype_amount = Convert.ToInt32(res) / 2;

                for (int i = 0; i < atype_amount; i++)
                {
                    res = await web_view.ExecuteScriptAsync(String.Format("document.getElementsByClassName('AType')[{0}].getElementsByTagName('tbody')[0].getElementsByTagName('td').length", i));
                    int tr_amount = Convert.ToInt32(res);
                    for (int j = 0; j < tr_amount; j++)
                    {
                        res = await web_view.ExecuteScriptAsync(String.Format("document.getElementsByClassName('AType')[{0}].getElementsByTagName('tbody')[0].getElementsByTagName('tr')[{1}].getElementsByTagName('td')[1].innerText", i, j));
                        string key = res.Replace('"', ' ').Trim();
                        res = await web_view.ExecuteScriptAsync(String.Format("document.getElementsByClassName('AType')[{0}].getElementsByTagName('tbody')[0].getElementsByTagName('tr')[{1}].getElementsByTagName('td')[5].innerText", i, j));
                        string value = res.Replace('"', ' ').Trim();
                        if (key == "null" || value == "null" || String.IsNullOrEmpty(key) || String.IsNullOrWhiteSpace(key) || String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                        {
                            continue;
                        }

                        try
                        {
                            STUDENT_INFO.course_grade.Add(key, value);
                        }
                        catch (Exception)
                        {

                        }


                    }
                }


                textBox1.Text += "이름:" + STUDENT_INFO.name + "\r\n";
                textBox1.Text += "총 평점:" + STUDENT_INFO.total_grade.ToString() + "\r\n";
                foreach (var item in STUDENT_INFO.course_grade)
                {
                    textBox1.Text += item.Key + ":" + item.Value + "\r\n===\r\n";
                }
                textBox1.Top=web_view.Top;
                textBox1.Left=web_view.Left;
                web_view.Hide();


            }
        }
    }
}
