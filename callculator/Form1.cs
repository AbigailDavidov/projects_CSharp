using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callculator
{
    public partial class Form1 : Form
    {
        private object lblsign;
        int f = 0;
        private TextBox pointer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pointer = txt1;
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = ((Button)sender).Text;
            pointer = txt2;
             f = 1;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt1.Text);
            int y = Convert.ToInt32(txt2.Text);


            if (label1.Text == Convert.ToString('+'))
                txt3.Text = Convert.ToString(x + y);
            if (label1.Text == Convert.ToString('-'))
                txt3.Text = Convert.ToString(x - y);
            if (label1.Text == Convert.ToString('*'))
                txt3.Text = Convert.ToString(x * y);
            if (label1.Text == Convert.ToString('/'))
                txt3.Text = Convert.ToString(x / y);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(f==0)
                txt1.Text+=((Button)sender).Text;
            else
                txt2.Text+=((Button)sender).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt1.Text = " ";
            txt2.Text = " ";
            txt3.Text = " ";
            label1.Text = " ";
            f = 0;
        }

        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit((char)e.KeyChar) || (char)e.KeyChar == '.' || (char)e.KeyChar == (char)Keys.Back)
            {
                if ((char)e.KeyChar == (char)Keys.Back && pointer.Focus() == false && pointer.Text.Length>0)
                    pointer.Text = pointer.Text.Substring(0, pointer.Text.Length - 1);
                else if ((char)e.KeyChar == '.' && pointer.Text.Contains('.') && pointer.Focus() == true)
                    e.Handled = true;

                else if (pointer.Focus() == false)
                    pointer.Text += e.KeyChar;
            }
            else
                e.Handled = true;
               

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
    
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
       
                
                 

        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

      

        private void txt1_Enter(object sender, EventArgs e)
        {
            pointer = txt1;
        }

        private void txt2_Enter(object sender, EventArgs e)
        {
            pointer = txt2;

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
