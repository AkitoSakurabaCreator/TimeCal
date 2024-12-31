using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeCal;

namespace TimeCal
{
    class Functions
    {
        Form1 form1 = null;
        public Functions(Form1 form)
        {
            this.form1 = form;
        }
        public void topMost(bool Switch)
        {
            form1.TopMost = Switch;
        }
        public void cal()
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
            form1.Month.Text = String.Format("今月分23時間計算: {0}月{1}日: {2} 時間", dtToday.Month.ToString(), dtLDM.Day.ToString(), result);
            form1.Result.Text = String.Format("今月使用可能時間: {0} 時間(今日分含)", lowresult);
            form1.Now.Text = String.Format("今日使用可能時間: {0} 時間", now);
        }

        public void opacityChange(int value)
        {
            form1.Opacity = value * 0.01;
        }

    }
}

