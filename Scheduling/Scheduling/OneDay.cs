using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Scheduling
{
    public enum Days
    {
        Sunday = 1,
        Munday,
        Tuseday,
        Wensday,
        Thursday,
        Friday} 
    public partial class OneDay : UserControl
    {
        private int y = 60;
        public int lessonNum = 0;
        public Days Day { get; set; }
        public OneDay(Days d)
        {
            InitializeComponent();        
            Name = d.ToString();
            lblDay.Text = d.ToString();
            Day = d;
        }
        private void button1_Click(object sender, EventArgs e)
        {   bool flag = false;
            if (y <= 600) {
                flag = true;
                lessonNum++;
            }
            if (flag) {
                Hour h = new Hour();
                h.Location = new Point(2, y);
                h.DayOfWeek = Day;
                h.HourDay = lessonNum;
                Controls.Add(h);
                y += 95;
                button1.Location = new Point(2, y);

            }
        }
    }
}
