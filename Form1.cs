using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void cal()
        {
            DateTime dtToday = DateTime.Today;
            DateTime dtTonow = DateTime.Now;

            //今月の最後の日
            DateTime dtLDM = new DateTime(dtToday.Year, dtToday.Month,
                DateTime.DaysInMonth(dtToday.Year, dtToday.Month));

            int daytime = 24; //1日24時間
            int oneday = 23;//23時に就寝
            int sleep = 8; //合計睡眠時間
            int running = 7; //一日の寝ていた時間
            int usedtime = (oneday - running); //1日 23 - 7時間 = 16時間
            int result = usedtime * dtLDM.Day; //1日の使用可能時間 * 月数 = 当月分の使用可能時間。 次の日、7時に起床時は 7-8で-1時間 つまり、前日の24時 - 1 = 23時ということがわかる。
            int lowresult = (dtLDM.Day - dtToday.Day) * usedtime;//単純時間 
            int now = oneday - dtTonow.Hour;
            Month.Text = String.Format("今月分23時間計算: {0}月{1}日: {2} 時間", dtToday.Month.ToString(), dtLDM.Day.ToString(), result);
            Result.Text = String.Format("今月使用可能時間: {0} 時間(今日分含)", lowresult);
            Now.Text = String.Format("今日使用可能時間: {0} 時間", now);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(1500, 10);
            cal();
            timer1.Start();
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            int aa = (int)(int.Parse(toolStripComboBox1.Text) * 0.01);
            //MessageBox.Show(aa.ToString());
            Opacity = (int.Parse(toolStripComboBox1.Text) * 0.01);
        }
    }
}
