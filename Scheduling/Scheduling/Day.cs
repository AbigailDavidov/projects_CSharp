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
        Friday
    }
    public partial class Day : UserControl
    {
        public Lesson[] lessons { get; set; }
        private int x = 25;
        private int lessonNum = 1;
        public Days D { get; set; }
        public Day(string s)//Step 3
        {
            InitializeComponent();
            lessons = new Lesson[10];
            //Step 4
            Lesson.DelCheck = CheckSubjects;
            Lesson.DelDeleat = DeleatSubject;
            Name = s;
            DayNamelable.Text = s;
        }
       

      
        
        public bool CheckSubjects(Lesson l)
        {
            //בודקת עם נשארו מס, שיעורים מספיק ביום
            //בודק אילוצים של מורה
            //בודק עם מס' הפעמים לא יותר מהכמות הנדרשת
            //בודק שהשיעור לפני לא אותו הדבר
            if (lessonNum + l.Amount < 10
                && BLLessonMatch.CheckHoursPosible((int)D, lessonNum, l.SubjectInfo, l.Amount)
                && BLLessonMatch.checkAmount(l.SubjectInfo) + l.Amount < l.SubjectInfo.numOfHours
                && BLLessonMatch.CheckPrevious((int)D, lessonNum, l.SubjectInfo))
            {
                BLLessonMatch.SaveLesson((int)D, lessonNum, l.Amount, l.SubjectInfo);
                lessonNum += l.Amount;
                MessageBox.Show("Lesson added successfully");
                return true;
            }
            else
            {
                MessageBox.Show("Connot add lesson");
                return false;
            }
        }
        public void DeleatSubject(Lesson l)
        {
            int loc = l.Location.X;
            l.Visible = false;
            foreach (var item in Controls)
            {
                if ((item is Lesson) && (item as Lesson).Location.X - 95 == loc)
                {
                    (item as Lesson).Location = new Point(2, loc);
                    (item as Lesson).HourOfDay -= l.Amount;
                    loc += 95;
                }
                else if ((item is Button) && (item as Button).Location.X - 95 == loc)
                {
                    (item as Button).Location = new Point(2, loc);
                    if ((item as Button).Visible == false)
                        (item as Button).Visible = true;
                }
            }
            BLLessonMatch.DeleatLesson((int)D, lessonNum, l.Amount);
            lessonNum -= l.Amount;
            MessageBox.Show("Lesson deleated successfully");
        }
        private void AddBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
