using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            answer.Text = "0";
            numBox1.Text = "";
            numBox2.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
        }
        private void numBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void answer_Click(object sender, EventArgs e)
        {
            
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void plusButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (numBox2.Text.Length > 0 && numBox2.Text.Length > 0)
                {
                    float num1 = Convert.ToSingle(numBox1.Text);
                    float num2 = Convert.ToSingle(numBox2.Text);
                    answer.Text = (num1 + num2).ToString();
                }
                if (numBox1.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 1!");
                }
                if (numBox2.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }
        }
        public void minusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numBox2.Text.Length > 0 && numBox2.Text.Length > 0)
                {
                    float num1 = Convert.ToSingle(numBox1.Text);
                    float num2 = Convert.ToSingle(numBox2.Text);
                    answer.Text = (num1 - num2).ToString();
                }
                if (numBox1.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 1!");
                }
                if (numBox2.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }
        }
        private void devideButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numBox2.Text.Length > 0 && numBox2.Text.Length > 0)
                {
                    float num1 = Convert.ToSingle(numBox1.Text);
                    float num2 = Convert.ToSingle(numBox2.Text);
                    answer.Text = (num1 / num2).ToString();
                }
                if (numBox1.Text.Length > 0 && numBox2.Text.Length == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                }
                if (numBox1.Text.Length == 0 && numBox2.Text.Length > 0)
                {
                    answer.Text = "0";
                }
                if (numBox1.Text.Length == 0 && numBox2.Text.Length == 0)
                {
                    answer.Text = "0";
                }
                if (numBox1.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 1!");
                }
                if (numBox2.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }
           
        }
        private void multipleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numBox2.Text.Length > 0 && numBox2.Text.Length > 0)
                {
                    float num1 = Convert.ToSingle(numBox1.Text);
                    float num2 = Convert.ToSingle(numBox2.Text);
                    answer.Text = (num1 * num2).ToString();
                }
                if (numBox1.Text.Length > 0 && numBox2.Text.Length == 0)
                {
                    answer.Text = "0";
                }
                if (numBox1.Text.Length == 0 && numBox2.Text.Length > 0)
                {
                    answer.Text = "0";
                }
                if (numBox1.Text.Length == 0 && numBox2.Text.Length == 0)
                {
                    answer.Text = "0";
                }
                if (numBox1.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 1!");
                }
                if (numBox2.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }
        }
        private void moduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numBox2.Text.Length > 0 && numBox2.Text.Length > 0)
                {
                    float num1 = Convert.ToSingle(numBox1.Text);
                    float num2 = Convert.ToSingle(numBox2.Text);
                    answer.Text = (num1 % num2).ToString();
                }
                if (numBox1.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 1!");
                }
                if (numBox2.Text == "")
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }
            
        }
        public void powerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numBox1.Text.Length > 0 && numBox2.Text.Length > 0)
                {
                    float number3 = int.Parse(numBox1.Text);
                    float number4 = int.Parse(numBox2.Text);
                    answer.Text = Math.Pow(number3, number4).ToString();
                }
                if (numBox1.Text == "0")
                {
                    answer.Text = "0";
                }
                if (numBox2.Text == "0")
                {
                    answer.Text = "1";
                }
                if (numBox1.Text.Length < 0)
                {
                    MessageBox.Show("Please write NUMBER 1");
                }
                if (numBox2.Text.Length < 0)
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }

        }
        private void vosklitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int factor = 1;
                int number5 = int.Parse(numBox1.Text);
                for (int i = number5; i >= 1; i--)
                {
                    factor = factor * i;
                }
                if (numBox1.Text == "0")
                {
                    answer.Text = "1";
                }
                if (numBox2.Text.Length > 0)
                {
                    numBox2.Text = "";
                }
                answer.Text = factor.ToString();
                if (numBox1.Text.Length <= 0)
                {
                    MessageBox.Show("Please write NUMBER 1");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Write only numbers!");
            }   
        }
        private void percentageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(numBox1.Text.Length > 0 && numBox2.Text.Length > 0)
                {
                    float num1 = Convert.ToSingle(numBox1.Text);
                    float num2 = Convert.ToSingle(numBox2.Text);
                    answer.Text = ((num2 * 100) / (num1 * 1)).ToString()+"%";
                }
                if(numBox1.Text.Length <= 0)
                {
                    MessageBox.Show("Please write NUMBER 1");
                }
                if (numBox2.Text.Length <= 0)
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }
        }
        private void piButton_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(numBox1.Text);

                if (numBox2.Text.Length > 0)
                {
                    numBox2.Text = "";
                }
                answer.Text = (num1 * 3.14159).ToString();
                if (numBox1.Text.Length <= 0)
                {
                    MessageBox.Show("Please write NUMBER 2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write only numbers!");
            }   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {    
                if(numBox1.Text.Length > 0)
                {
                    float num1 = Convert.ToSingle(numBox1.Text);
                    answer.Text = Math.Sqrt(num1).ToString();
                }
                if(numBox2.Text.Length >= 0)
                {
                    numBox2.Text = "";
                }
                if (numBox1.Text.Length <= 0)
                {
                    MessageBox.Show("Please write NUMBER 1");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Write only numbers!");
            }
        }
    }
}