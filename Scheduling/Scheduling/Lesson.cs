using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BL;

namespace Scheduling
{
    // 1
    public delegate bool delCheckSubject(Lesson l);
    public delegate void delDeleateSubject(Lesson l);
    public partial class Lesson : UserControl
    {
        //Step 2
        public static delCheckSubject DelCheck;
        public static delDeleateSubject DelDeleat;
        public Profession SubjectInfo { get; set; }
        public Days DayOfWeek { get; set; }
        public int HourOfDay { get; set; }
        public int Amount { get; set; }
        //static int legnth = 45;

        public Lesson()
        {
            InitializeComponent();
        }
    
        private void Lesson_Load_1(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = BLProffesion.GetAllSubjects();
            SubjectCB.DataSource = bindingSource1.DataSource;
            SubjectCB.DisplayMember = "Name";
            SubjectCB.ValueMember = "Code";
            SubjectCB.Text = "";
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (SaveBTN.Text == "Save")
            {

                SubjectInfo = BLProffesion.GetSubject((int)SubjectCB.SelectedValue);
                Amount = int.Parse(AmountCB.Text);
                //Step 5
                if (DelCheck(this))
                {
                    BackColor = SystemColors.AppWorkspace;
                    // this.Size=new Size()
                    SubjectCB.DropDownStyle = ComboBoxStyle.Simple;
                    AmountCB.DropDownStyle = ComboBoxStyle.Simple;
                    SaveBTN.Text = "Remove";
                }
                else
                {
                    SubjectCB.Text = "";
                    AmountCB.Text = "";
                }
            }
            else
                //Step 5
                DelDeleat(this);

        }
    }
}
