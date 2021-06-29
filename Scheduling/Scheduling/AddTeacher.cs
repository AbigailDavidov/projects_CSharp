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
    public partial class AddTeacher : Form
    { 
        public AddTeacher()
        {
            InitializeComponent();
        }
        /// <summary>
        /// יוצרת teacher חדש במסד נתונים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            SchedulingEntities s = new SchedulingEntities();

            
            Entities.teacher t= new Entities.teacher();
                
           
        }

        /// <summary>
        /// בדיקת תקינות קלט עבור הנתונים שהוכנסו
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag=false;
            String name = textBox2.Text;
            foreach (char letter in name)
            {
                if (char.IsDigit(letter))
                {
                     flag= true;
                    break;
                }
            }
            if(flag)
            errorProvider1.SetError(textBox2,"rong value");
            else {
                 flag = false;
                 name = textBox3.Text;
                foreach (char letter in name)
                {
                    if (char.IsDigit(letter))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    errorProvider1.SetError(textBox3, "rong value");
                else {
                    flag = false;
                   string id = textBox4.Text;
                    int mone = 0;
                    foreach (char letter in id)
                    {
                        mone++;
                        if (!char.IsDigit(letter))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if ((flag)&&( mone != 9))
                        errorProvider1.SetError(textBox4, "rong value");
                    else { 
                           teacher T = new teacher();
            
                            T.firstName = textBox2.Text;
                              T.lastName = textBox3.Text;
              
                              BLTeachers.addTeacher(T);
                             this.Close();
                    }
                }
             }   
        }
    }
}
