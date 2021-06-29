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
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }
        /// <summary>
        /// בליחצה על לוח שעות פותח את הטופס המיועד
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new ScheduleFrm().Show();
        }

        /// <summary>
        /// בליחצה על מורות פותח את הטופס המיועד
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            new ShowTeachers().Show();
        }

        /// <summary>
        /// בליחצה על מקצועות פותח את הטופס המיועד
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            new ShowProffesions().Show();
        }  
    }
}
