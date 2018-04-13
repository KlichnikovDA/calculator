﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        public Regex rgx = new Regex(@"^([0-9\s+\-*/°′″]{1,})$");

        public CalcForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            InputTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "1";   }

        private void button2_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "2";   }

        private void button3_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "3";   }

        private void button4_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "4";   }

        private void button5_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "5";   }

        private void button6_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "6";   }

        private void button7_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "7";   }

        private void button8_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "8";   }

        private void button9_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "9";   }

        private void button0_Click(object sender, EventArgs e)
        {   InputTextBox.Text += "0";   }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += " + ";
            TextBox.Text += InputTextBox.Text;
            InputTextBox.Clear();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += " - ";
            TextBox.Text += InputTextBox.Text;
            InputTextBox.Clear();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += " * ";
            TextBox.Text += InputTextBox.Text;
            InputTextBox.Clear();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += " / ";
            TextBox.Text += InputTextBox.Text;
            InputTextBox.Clear();
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text != "")
                InputTextBox.Text = InputTextBox.Text.Remove(InputTextBox.Text.Length - 1, 1);
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {

            if (!rgx.IsMatch(TextBox.Text) || !rgx.IsMatch(InputTextBox.Text))
            {
                MessageBox.Show("Введены недопустимые символы", "Ошибка!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox.Clear();
                InputTextBox.Clear();
            }

            else      //разделение строки из текстбокса на 2 операнда
            {
                TextBox.Text += InputTextBox.Text;
                InputTextBox.Clear();

                //it will need later
                char plus = '+';
                char minus = '-';
                char division = '/';
                char multiplication = '*';
                

                char[] signs = { '+', '-', '*', '/' };
                int op1, op2;

                int ind;

                ind = TextBox.Text.IndexOfAny(signs);
                string buf = String.Empty;
                for (int i = 0; i < ind - 1; i++)
                {
                    buf += TextBox.Text[i];
                }

                op1 = Int32.Parse(buf);  //здесь должен быть перевод, организованный свойством класса Data
                buf = String.Empty;
                for (int i = ind + 2; i < TextBox.Text.Length; i++)
                {
                    buf += TextBox.Text[i];
                }

                op2 = Int32.Parse(buf);   //и здесь тоже
            }

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void DegreeButton_Click(object sender, EventArgs e)
        {   InputTextBox.Text += " ° ";   }

        private void MunuteButton_Click(object sender, EventArgs e)
        {   InputTextBox.Text += " ′ ";   }

        private void SecondButton_Click_1(object sender, EventArgs e)
        {   InputTextBox.Text += " ″ ";   }

    }
}
