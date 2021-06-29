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
    public partial class AddProffesion : Form
    {
        public AddProffesion()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// בדיקת תקינות קלט לכול הנתונים שהוקשו
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            String prof = textBox1.Text;
            string code,hour;
            foreach (char letter in prof)
            {
                if (char.IsDigit(letter))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                errorProvider1.SetError(textBox1, "wrong value");
            else {
                 flag = false;
                  code = textBox3.Text;
                foreach (char letter in code)
                {
                    if (!char.IsDigit(letter))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    errorProvider1.SetError(textBox3, "wrong value");

                else{

                    int code1 = Convert.ToInt32(code);
                    if (!BLTeachers.GetAllTeachers().Any(a => a.code == code1))
                        errorProvider1.SetError(textBox3, "wrong value");
                    else {
                        flag = false;
                        hour = textBox2.Text;
                        foreach (char letter in hour)
                        {
                            if (!char.IsDigit(letter))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag)
                            errorProvider1.SetError(textBox3, "wrong value");
                        else
                        {
                            Profession p = new Profession();
                            p.professionName = textBox1.Text;
                            p.codeTeach = Convert.ToInt32(textBox3.Text);
                            p.numOfHours = Convert.ToInt32(textBox2.Text);
                            BLProffesion.Add(p);
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
