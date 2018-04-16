using System;
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
        public Regex rgx = new Regex(@"^(([0-9\s+\-*/()°′″]|(sin)|(cos)|(tg)|(ctg)){0,})$");

        public CalcForm()
        {
            InitializeComponent();
        }

        //цифры
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

        //значки углов: градус, минута, секунда
        private void DegreeButton_Click(object sender, EventArgs e)
        { InputTextBox.Text += " ° "; }

        private void MunuteButton_Click(object sender, EventArgs e)
        { InputTextBox.Text += " ′ "; }

        private void SecondButton_Click_1(object sender, EventArgs e)
        { InputTextBox.Text += " ″ "; }

        //операции: сложение, вычитание, умножение, деление, тригонометрические функции
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (!rgx.IsMatch(InputTextBox.Text))
            {
                MessageBox.Show("Введены недопустимые символы", "Ошибка!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTextBox.Clear();
            }

            else 
            {
                InputTextBox.Text += " + ";
                TextBox.Text += InputTextBox.Text;
                InputTextBox.Clear();
                PlusButton.Enabled = MinusButton.Enabled = MultiplyButton.Enabled = DivideButton.Enabled = SinButton.Enabled =
                    CosButton.Enabled = TgButton.Enabled = CtgButton.Enabled = false;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (!rgx.IsMatch(InputTextBox.Text))
            {
                MessageBox.Show("Введены недопустимые символы", "Ошибка!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTextBox.Clear();
            }

            else
            {
                InputTextBox.Text += " - ";
                TextBox.Text += InputTextBox.Text;
                InputTextBox.Clear();
                PlusButton.Enabled = MinusButton.Enabled = MultiplyButton.Enabled = DivideButton.Enabled = SinButton.Enabled =
                    CosButton.Enabled = TgButton.Enabled = CtgButton.Enabled = false;
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (!rgx.IsMatch(InputTextBox.Text))
            {
                MessageBox.Show("Введены недопустимые символы", "Ошибка!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTextBox.Clear();
            }

            else
            {
                InputTextBox.Text += " * ";
                TextBox.Text += InputTextBox.Text;
                InputTextBox.Clear();
                PlusButton.Enabled = MinusButton.Enabled = MultiplyButton.Enabled = DivideButton.Enabled = SinButton.Enabled =
                    CosButton.Enabled = TgButton.Enabled = CtgButton.Enabled = false;
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (!rgx.IsMatch(InputTextBox.Text))
            {
                MessageBox.Show("Введены недопустимые символы", "Ошибка!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTextBox.Clear();
            }

            else
            {
                InputTextBox.Text += " / ";
                TextBox.Text += InputTextBox.Text;
                InputTextBox.Clear();
                PlusButton.Enabled = MinusButton.Enabled = MultiplyButton.Enabled = DivideButton.Enabled = SinButton.Enabled =
                    CosButton.Enabled = TgButton.Enabled = CtgButton.Enabled = false;
            }
        }     

        private void SinButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "sin(" + InputTextBox.Text + ")";
            InputTextBox.Clear();
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "cos(" + InputTextBox.Text + ")";
            InputTextBox.Clear();
        }

        private void TgButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "tg(" + InputTextBox.Text + ")";
            InputTextBox.Clear();
        }

        private void CtgButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "ctg(" + InputTextBox.Text + ")";
            InputTextBox.Clear();
        }

        //очистить текстбоксы
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            InputTextBox.Clear();
            PlusButton.Enabled = MinusButton.Enabled = MultiplyButton.Enabled = DivideButton.Enabled = SinButton.Enabled =
                CosButton.Enabled = TgButton.Enabled = CtgButton.Enabled = true;
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text != "")
                InputTextBox.Text = InputTextBox.Text.Remove(InputTextBox.Text.Length - 1, 1);
        }

        //нажатие знака "равно"
        private void ResultButton_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();

            if (!rgx.IsMatch(TextBox.Text) || !rgx.IsMatch(InputTextBox.Text))
            {
                MessageBox.Show("Введены недопустимые символы", "Ошибка!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox.Clear();
                InputTextBox.Clear();
                PlusButton.Enabled = MinusButton.Enabled = MultiplyButton.Enabled = DivideButton.Enabled = SinButton.Enabled =
                    CosButton.Enabled = TgButton.Enabled = CtgButton.Enabled = true;
            }

            else      //разделение строки из текстбокса на 2 операнда
            {
                TextBox.Text += InputTextBox.Text;
                InputTextBox.Clear();
                PlusButton.Enabled = MinusButton.Enabled = MultiplyButton.Enabled = DivideButton.Enabled = SinButton.Enabled =
                    CosButton.Enabled = TgButton.Enabled = CtgButton.Enabled = true;

                char[] signs = { '+', '-', '*', '/' };
                int op1=0, op2=0;
                Angle Oper1=new Angle();
                //Если требуется найти только синус, косинус и т.д. - то операнд только 1
                if (TextBox.Text.Contains("sin") || TextBox.Text.Contains("cos") || TextBox.Text.Contains("tg") || TextBox.Text.Contains("ctg"))
                {
                    string arg = TextBox.Text.Substring(TextBox.Text.IndexOf('(') + 1, TextBox.Text.IndexOf(')') - TextBox.Text.IndexOf('(') - 1);
                    Oper1 = calc.ToAngle(arg);
                    string Result;
                    if (TextBox.Text.Contains("sin"))
                        Result = calc.Sinus(Oper1);
                    else if (TextBox.Text.Contains("cos"))
                        Result = calc.Cosinus(Oper1);
                    else if (TextBox.Text.Contains("tg"))
                        Result = calc.Tangens(Oper1);
                    else Result = calc.Cotangens(Oper1);
                    //вывод результата
                    TextBox.Text += Result;
                }
                else
                {
                    Angle Oper2 = new Angle();//Операнды должны быть ИЛИ класса Angle ИЛИ инт
                                              //Т.к. может быть как сумма углов, так и const*угол
                    int ind;

                    ind = TextBox.Text.IndexOfAny(signs);
                    string buf = String.Empty;
                    for (int i = 0; i < ind - 1; i++)
                    {
                        buf += TextBox.Text[i];
                    }
                    if (buf.Contains("°")|| buf.Contains("′") || buf.Contains("″"))
                    {
                        Oper1 = calc.ToAngle(buf);
                    }
                    else
                    {
                        op1 = Int32.Parse(buf);
                    }

                    buf = String.Empty;
                    for (int i = ind + 2; i < TextBox.Text.Length; i++)
                    {
                        buf += TextBox.Text[i];
                    }
                    if (buf.Contains("°") || buf.Contains("′") || buf.Contains("″"))
                    {
                        Oper2 = calc.ToAngle(buf);
                    }
                    else
                    {
                        op2 = Int32.Parse(buf);
                    }

                    Angle result = new Angle();
                    if (TextBox.Text.Contains("+"))
                    {
                        //операция сложения
                        result = calc.Summa(Oper1, Oper2);
                        
                    }
                    else
                    if (TextBox.Text.Contains("-"))
                    {
                        //операция вычитания
                        result = calc.Raznost(Oper1, Oper2);
                    }
                    else
                    if (TextBox.Text.Contains("*"))
                    {
                        //операция умножения
                        if (op1 == 0 && Oper1.ToRadian() != 0)
                        {
                            result = calc.Multiply(op2, Oper1);
                        }
                        else
                        {
                            result = calc.Multiply(op1, Oper2);
                        }
                    }
                    int res;
                    if (TextBox.Text.Contains("/"))
                        //операция деления
                    {
                        if (Oper2.ToRadian() == 0 && op2 == 0)
                        {
                            res = Int32.MaxValue;
                            TextBox.Text += res;
                        }
                        else
                        {
                            if (op1 == 0 && Oper1.ToRadian() != 0)
                            {
                                result = calc.Division(Oper1, op2);
                            }
                        }
                    }
                    //результат
                    TextBox.Text += " = " + result.ToString();
                }
            }
        }
    }
}
