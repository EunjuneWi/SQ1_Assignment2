using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    
    public partial class TriangleUI : Form
    {
        public TriangleUI()
        {
            InitializeComponent();
        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            try
            {
                result = Triangle.GetRemainingSide(side1_1.Text, side1_2.Text);
                Result1.Text = "Answer: " + result.ToString();
            }
            catch
            {
                Result1.Text = "Answer: [Error] Invalid Input";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            try
            {
                result = Triangle.GetArea(side2_1.Text, side2_2.Text);
                answer2.Text = "Answer: " + result.ToString();
            }
            catch
            {
                answer2.Text = "Answer: [Error] Invalid Input";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            try
            {
                result = Triangle.GetAngle(angle1.Text, angle2.Text);
                answer3.Text = "Answer: " + result.ToString();
            }
            catch
            {
                answer3.Text = "Answer: [Error] Invalid Input";
            }
        }
    }
}
