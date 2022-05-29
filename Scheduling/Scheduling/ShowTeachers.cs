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
        /// opens adding teacher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTeacher newForm = new AddTeacher();
            newForm.Show();
        }

        /// <summary>
        /// gets all teachers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTeachers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.BLTeachers.GetAllTeachers();
            dataGridView1.Refresh();
        }

        /// <summary>
        /// refreshin the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTeachers_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BL.BLTeachers.GetAllTeachers();
            dataGridView1.Refresh();
        }

        /// <summary>
        /// show teacher's details for editing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            new EditTeacher(row).Show();
        }

        /// <summary>
        /// saves row
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
        /// double click on row from table will open up an editing teacher form
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

