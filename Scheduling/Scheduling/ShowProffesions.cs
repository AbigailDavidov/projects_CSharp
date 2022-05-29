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
    public partial class ShowProffesions : Form
    {
        static Profession row = null;
        public ShowProffesions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gets all professions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowProffesions_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLProffesion.GetAllSubjects();
        }

        /// <summary>
        /// opens editing course form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddProffesion newForm = new AddProffesion();
            newForm.Show();
        }

        /// <summary>
        /// refreshing form and brings all courses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowProffesions_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLProffesion.GetAllSubjects();
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            BLProffesion.Remove(row);
            dataGridView1.DataSource = BLProffesion.GetAllSubjects();
            /*dataGridView1.Columns.Add("firstName", "firstName");
           dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("ID", "ID");*/
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = ((sender as DataGridView).SelectedRows[0].DataBoundItem as Profession);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = ((sender as DataGridView).SelectedRows[0].DataBoundItem as Profession);
        }
    }
}
