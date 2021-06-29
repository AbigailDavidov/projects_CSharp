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
using BL;

namespace Scheduling
{
    public partial class ShowTeachers : Form
    {
        static teacher row = null;
        public ShowTeachers()
        {
            InitializeComponent();
        }
 
        /// <summary>
        /// בלחיצה על הוסף מורה פותח טופס של הוספת מורה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTeacher newForm = new AddTeacher();
            newForm.Show();
        }

        /// <summary>
        /// ברגע שטוען את הטופס מציג את כול המורות ע"י שמהיא אותם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTeachers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.BLTeachers.GetAllTeachers();
            dataGridView1.Refresh();
        }

        /// <summary>
        /// ברגע שנצאים  על הטופס מרענן את כול המורות  ומהיא אותם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTeachers_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.BLTeachers.GetAllTeachers();
            dataGridView1.Refresh();
        }

        /// <summary>
        /// מציג את הפרטים של אותה מורה ע"י לחיצה על  עדכן מורה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            new EditTeacher(row).Show();
        }

        /// <summary>
        ///שומר את השורה שלחצנו עליה בכול מיני אפשריות של לחיצה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((sender as DataGridView).SelectedRows[0].DataBoundItem as teacher);
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((sender as DataGridView).SelectedRows[0].DataBoundItem as teacher);
           
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = ((sender as DataGridView).SelectedRows[0].DataBoundItem as teacher);
        }

        /// <summary>
        /// כאשר המשתמש לוחץ לחיצה כפולה על שורה בטבלה הפונקציה פותחת לו טופס עריכת מורה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            teacher chosen = ((sender as DataGridView).SelectedRows[0].DataBoundItem as teacher);

            new EditTeacher(chosen).Show();
        }
    }
}

