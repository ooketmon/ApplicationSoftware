
using System.Linq.Expressions;

namespace Eungsosil
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> course_grade;
        double total_grade;

        public Form1()
        {
            InitializeComponent();
            course_grade = new Dictionary<string, string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            web_view.Source = new Uri("https://klas.kw.ac.kr");
        }

        private async void web_view_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (web_view.Source.ToString() == "https://klas.kw.ac.kr/std/cmn/frame/Frame.do")
            {

                web_view.Source = new Uri("https://klas.kw.ac.kr/std/cps/inqire/AtnlcScreStdPage.do");
            }
            if (web_view.Source.ToString() == "https://klas.kw.ac.kr/std/cps/inqire/AtnlcScreStdPage.do")
            {

                var res = await web_view.ExecuteScriptAsync("document.getElementsByClassName('tablegw')[2].getElementsByTagName('td')[13].innerText;");
                res=res.Replace('"', ' ').Trim();
                try
                {
                    total_grade = Double.Parse(res);
                }
                catch
                {
                    //비동기적 처리를 하기 때문에 오류 메시지 발생하지만 결과적으로는 정상 작동한다. 일부러 비워두었다.
                }
                res = await web_view.ExecuteScriptAsync("document.getElementsByClassName('AType').length");
                int atype_amount = Convert.ToInt32(res) / 2;

                for (int i = 0; i < atype_amount; i++)
                {
                    res = await web_view.ExecuteScriptAsync(String.Format("document.getElementsByClassName('AType')[{0}].getElementsByTagName('tbody')[0].getElementsByTagName('tr').length", i));
                    int tr_amount = Convert.ToInt32(res);
                    for (int j = 0; j < tr_amount; j++)
                    {
                        res = await web_view.ExecuteScriptAsync(String.Format("document.getElementsByClassName('AType')[{0}].getElementsByTagName('tbody')[0].getElementsByTagName('tr')[{1}].getElementsByTagName('td')[1].innerText", i, j));
                        string key = res.Replace('"', ' ').Trim();
                        res = await web_view.ExecuteScriptAsync(String.Format("document.getElementsByClassName('AType')[{0}].getElementsByTagName('tbody')[0].getElementsByTagName('tr')[{1}].getElementsByTagName('td')[5].innerText", i, j));
                        string value = res.Replace('"', ' ').Trim();
                        if (!String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                        {
                            try
                            {
                                course_grade.Add(key, value);
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }



                    }
                }

                textBox1.Text = "총 평점:" + total_grade.ToString()+"\r\n";
                foreach (var item in course_grade)
                {
                    textBox1.Text += item.Key + ":" + item.Value + "\r\n===\r\n";
                }



            }
        }
    }
}