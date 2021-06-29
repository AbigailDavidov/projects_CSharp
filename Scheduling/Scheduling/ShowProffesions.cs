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
        /// עם פתיחת הקובץ מקשר את הטבלה לכל הקורסים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowProffesions_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLProffesion.GetAllSubjects();
        }

        /// <summary>
        /// בלחיצה על הוסף מקצוע פותח טופס של הוספת קורס
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddProffesion newForm = new AddProffesion();
            newForm.Show();
        }

        /// <summary>
        /// ברגע שעומדים על הטופס מרענן אותו וממביא את הקורסים מחדש
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowProffesions_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLProffesion.GetAllSubjects();
            dataGridView1.Refresh();
        }

        /// <summary>
        ///  מוחקת את השורה שנבחרה על ושמורה במשתנה
        /// </summary>
        /// <param name="sender">כפתור "REMOVE"</param>
        /// <param name="e"></param>

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


        /// <summary>
        /// שומרת את שורה הנבחרת בתוך משנה 
        /// </summary>
        /// <param name="sender">טבלה</param>
        /// <param name="e"></param>

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
