using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conditional_statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score;
            if (double.TryParse(textBox1.Text, out score))
            {
                char grade = 'F';

                if (score >= 90)
                {
                    grade = 'A';
                }

                if (score >= 80 && score < 90)
                {
                    grade = 'B';
                }

                if (score >= 70 && score < 80)
                {
                    grade = 'C';
                }

                if (score >= 60 && score < 70)
                {
                    grade = 'D';
                }

                //if (score < 60 )
                //{
                //    grade = 'F';
                //}
                Console.WriteLine("***Using if-only****");
                Console.WriteLine("Your grade is " + grade.ToString());

                if (score >= 90)
                {
                    grade = 'A';
                }
                else if (score >= 80)
                {
                    grade = 'B';
                }
                else if (score >= 70)
                {
                    grade = 'C';
                }
                else if (score >= 60)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'F';
                }
                Console.WriteLine("\r\n***Using if-elseif-else****");
                Console.WriteLine("Your grade is " + grade.ToString());
            }
            else
            {
                MessageBox.Show("Your input is wrong");
            }

        }
    }
}
