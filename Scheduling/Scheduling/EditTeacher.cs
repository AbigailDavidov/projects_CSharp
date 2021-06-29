using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class EditTeacher : Form
    {
        static teacher teacher;
        static BLImpossibleHours chosen = null;
        public EditTeacher()
        {
            InitializeComponent();
        }
        public EditTeacher(teacher t)
        {
            
            InitializeComponent();
            teacher = t;

        }

        /// <summary>
        ///  הפונקציה המופעלת עם פתיחת הקובץ, הפונקציה מקשרת את הטבלה לרשימה השעות הבלתי אפשריות של המורה ומכניסה את הנתונים על המורה טופס 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditTeacher_Load(object sender, EventArgs e)
        {
            imposibleHoursDGV.DataSource = BLImpossibleHours.GetNotPosibleHours(teacher);
            FirstNameTB.Text = teacher.firstName;
            LastNameTB.Text = teacher.lastName;
        }

       /// <summary>
       /// הוספת שעה בלתי אפשריות ברשימה שעות בלתי אפשיות 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void AddBTN_Click_1(object sender, EventArgs e)
        {
            if (DayCB.Text != null && HourCB.Text != null && BLImpossibleHours.NPHExists(int.Parse(DayCB.Text), int.Parse(HourCB.Text), teacher) == false)
            {
                BLImpossibleHours.AddNotPosiblHour(new BLImpossibleHours(int.Parse(DayCB.Text), int.Parse(HourCB.Text)), teacher);
                MessageBox.Show("one imposibleHour hour added");
                imposibleHoursDGV.DataSource = BLImpossibleHours.GetNotPosibleHours(teacher);
                imposibleHoursDGV.Refresh();
            }
        }
        /// <summary>
        /// לחיצה על מחק שורה 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveRowBTN_Click_1(object sender, EventArgs e)
        {
            if (chosen != null)
                try
                {
                    BLImpossibleHours.Remove(chosen, teacher);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            imposibleHoursDGV.DataSource = BLImpossibleHours.GetNotPosibleHours(teacher);
            imposibleHoursDGV.Refresh();
        }
 
      /// <summary>
      /// בדיקת התקינות של הנתונים שהוקשו
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {                   
                errorProvider1.Clear();

                if (FirstNameTB.Text == "")
                    errorProvider1.SetError(FirstNameTB, "empty");
                if (LastNameTB.Text == "")
                    errorProvider1.SetError(LastNameTB, "empty");
               
                
               
                bool hasDigit = false;
                foreach (char letter in FirstNameTB.Text)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                        break;
                    }
                }
                if (hasDigit)
                {
                    errorProvider1.SetError(FirstNameTB, "worng value");
                }
                
                hasDigit = false;
                foreach (char letter in LastNameTB.Text)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                        break;
                    }
                }
                if (hasDigit)
                {
                    errorProvider1.SetError(LastNameTB, "worng value");
                }
           
            else
            {
                
                teacher t = new teacher() { firstName = FirstNameTB.Text, lastName = LastNameTB.Text};
                BLTeachers.EditTeacher(t, teacher);
                MessageBox.Show("Teacher info edited successfully");
            }
        }
        /// <summary>
        /// שומר את השורה שנבחרה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imposibleHoursDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chosen = ((sender as DataGridView).SelectedRows[0].DataBoundItem as BLImpossibleHours);
        }

        
    }
}
