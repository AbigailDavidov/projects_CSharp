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
using Entities;


namespace Scheduling
{
        
    public partial class Hour : UserControl
    {    
        public Days DayOfWeek { get; set; }
        public int HourDay { get; set; }       
        private bool flag=false;
        public int cod { get; set; }
        public int codProf { get; set; }
        public string codi { get; set; }
       
        public Hour()
        {
            InitializeComponent();
        }

        /// <summary>
        /// get profession list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hour_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = BLProffesion.GetAllSubjects();
            cmbHour.DataSource = bindingSource1.DataSource;
            cmbHour.DisplayMember = "professionName";
            cmbHour.ValueMember = "code";
            cmbHour.Text = "";
            label1.Text = "";
            flag = true;
         
        }
        /// <summary>
        /// saves profession to the hour that was picked, removes 1 fron overall count of hours per week, per profession
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
          
            ScheduleFrm.list2.Find(a => a.professionName == cmbHour.Text).numOfHours--;
            int num = Convert.ToInt32(ScheduleFrm.list2.Find(a => a.professionName == cmbHour.Text).numOfHours);
            if (num < 0)
                MessageBox.Show("you finsh the hours of this profession ");
            else
                ScheduleFrm.Func(cmbHour.Text, num);
            if (BLImpossibleHours.FitsToTeacher(cod, Convert.ToInt32(DayOfWeek), HourDay))
                this.BackColor = Color.Orange;
            else
            if (IdealHoursBL.FitsToProff(codProf, HourDay))
                this.BackColor = Color.Violet;
            else
                this.BackColor = Color.Yellow;

          
        }
  
        /// <summary>
        /// when profession was picked, fills teacher accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag) {
            label1.Text = BLTeachers.GetMember(cmbHour.Text).firstName;
                cod = BLTeachers.GetMember(cmbHour.Text).code;
                    
                codProf = BLProffesion.GetMember(cmbHour.Text).code;

                codi = BLImpossibleHours.getCodeByTeach(cod);
            }

        }
    }
}
