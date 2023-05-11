
using steal_the_exam;
using System.Linq.Expressions;

namespace Eungsosil
{

    public partial class Form1 : Form
    {

        public Form1()
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
                        Student_INFO.total_grade = Double.Parse(res);
                    }
                    catch
                    {
                        //�񵿱��� ó���� �ϱ� ������ ���� �޽��� �߻������� ��������δ� ���� �۵��Ѵ�. �Ϻη� ����ξ���.
                    }
                }
                res = await web_view.ExecuteScriptAsync("document.getElementsByClassName('tablegw')[0].getElementsByTagName('tbody')[0].getElementsByTagName('td')[3].innerText");
                res = res.Replace('"', ' ').Trim();
                if (res != "null" && !String.IsNullOrEmpty(res) && !String.IsNullOrWhiteSpace(res))
                {
                    try
                    {
                        Student_INFO.name = res;
                    }
                    catch
                    {
                        //�񵿱��� ó���� �ϱ� ������ ���� �޽��� �߻������� ��������δ� ���� �۵��Ѵ�. �Ϻη� ����ξ���.
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
                            Student_INFO.course_grade.Add(key, value);
                        }
                        catch (Exception)
                        {

                        }


                    }
                }


                textBox1.Text += "�̸�:" + Student_INFO.name + "\r\n";
                textBox1.Text += "�� ����:" + Student_INFO.total_grade.ToString() + "\r\n";
                foreach (var item in Student_INFO.course_grade)
                {
                    textBox1.Text += item.Key + ":" + item.Value + "\r\n===\r\n";
                }



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3rd_floor play = new _3rd_floor();
            play.ShowDialog();
            this.Close();
        }
    }
}