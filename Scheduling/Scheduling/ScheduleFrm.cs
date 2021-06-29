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
using Entities;

namespace Scheduling
{
    public partial class ScheduleFrm : Form
    {
        List<Profession> list = BLProffesion.GetAllSubjects();
        public static List<Profession> list2 = new List<Profession>();
        public static List<Label> l = new List<Label>();

        public ScheduleFrm()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// מביא 6 פקדים של יום ומביא את כול המקצועות עם מספר השעות שאמור להיות להם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScheduleFrm_Load(object sender, EventArgs e)
        {
            int z = 30;
            int x = 40;
            int y = 70;
            for (int i = 0; i < 6; i++)
            {
                OneDay D = new OneDay((Days)i + 1);
                D.Location = new Point(x, 5);
                x += 130;
                D.Visible = true;
                Controls.Add(D);
                Label l = new Label();
                l.Text = (i + 1).ToString();
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Size = new Size(30, 70);
                l.Location = new Point(820, y);
                l.BackColor = Color.AntiqueWhite;
                y += 90;
                
                Controls.Add(l);
            }
            for (int i = 0; i < list.Count(); i++)
            {
                Label ll = new Label();
                list2.Add(list[i]);
                ll.Text = list[i].professionName + "" + list[i].numOfHours;
                ll.TextAlign = ContentAlignment.MiddleCenter;
                ll.Size = new Size(70, 50);
                ll.Location = new Point(z, 750);
                ll.BackColor = Color.Chocolate;
                ll.Name = list[i].professionName;
                z += 100;
                Controls.Add(ll);
                l.Add(ll);

            }}


        /// <summary>
        /// משנה את התג שהתקבלה למספר החדש שהתקבל
        /// </summary>
        /// <param name="n"></param>
        /// <param name="mis"></param>
            public static void Func(string n, int mis)
            {
                (l.Find(a => a.Name == n)).Text = n + "" + mis;
            }
    }
}
