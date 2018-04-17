using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        /*public Angle ReadForFunctions1Angle(CalcForm f1) //Считывание угла для работы
        {
            int deg, min, sec;
            Angle temp = new Angle();
            Int32.TryParse(f1.Degree1.Text, out deg);
            Int32.TryParse(f1.Minute1.Text, out min);
            Int32.TryParse(f1.Second1.Text, out sec);
            return temp;
        }
        public Degrees ReadForFunctions2Angle(Form1 f1) //Считывание угла для работы
        {
            //Возможно 2 варианта обработки:
            //1)Строки из текстбоксов превращаются в класс угол еще в самой форме
            //2)Они превращаются в данном методе
            //Решайте как удобнее
            Degrees temp = new Degrees();
            Int32.TryParse(f1.Degree2.Text, out temp.gradus);
            Int32.TryParse(f1.Minute2.Text, out temp.minute);
            Int32.TryParse(f1.Second2.Text, out temp.seconds);
            return temp;
        }*/
        public Angle ToAngle(string input)
        {
            int degree = 0, minute = 0, second = 0;
            int deg = input.IndexOf('°');
            if (deg != -1)
            {
                string degrees = input.Substring(0, deg);
                Int32.TryParse(degrees, out degree);
            }
            int min = input.IndexOf('′');
            if (min != -1)
            {
                string minut = input.Substring(deg + 1, min - deg - 1);
                Int32.TryParse(minut, out minute);
            }
            int sec = input.IndexOf("″");
            if (sec != -1)
            {
                string seconds = input.Substring(min + 1, sec - min - 2);
                Int32.TryParse(seconds, out second);
            }
            return new Angle(degree, minute, second);
        }
        public Angle Summa(Angle a, Angle b)
        {
            Angle sum = new Angle();
            sum = a + b;//Перегруженная операция
            return sum;
        }
        public Angle Raznost(Angle a, Angle b)
        {
            Angle raz = new Angle();
            raz = a - b;//Перегруженная операция
            return raz;
        }
        public Angle Multiply(int a, Angle b)
        {
            Angle mp = new Angle();
            mp = a * b;//Перегруженная операция
            return mp;
        }
        public Angle Multiply(Angle a, int b)
        {
            Angle mp = new Angle();
            mp = a * b;//Перегруженная операция
            return mp;
        }
        public Angle Division(Angle a, int b)
        {
            Angle dv = new Angle();
            dv = a / b;//Перегруженная операция
            return dv;
        }
        public string Sinus(Angle inp)
        {
            double rad = inp.ToRadian();//Перегрузка ToRadians - для перевода в радианы
            return Math.Sin(rad).ToString();
        }
        public string Cosinus(Angle inp)
        {
            double rad = inp.ToRadian();//Перегрузка ToRadians - для перевода в радианы
            return Math.Cos(rad).ToString();
        }
        public string Tangens(Angle inp)
        {
            double rad = inp.ToRadian();//Перегрузка ToRadians - для перевода в радианы
            return Math.Tan(rad).ToString();
        }
        public string Cotangens(Angle inp)
        {
            double rad = inp.ToRadian();//Перегрузка ToRadians - для перевода в радианы
            return (Math.Cos(rad) / Math.Sin(rad)).ToString();
        }
        /*public void OutputResult(CalcForm f1, Angle res)//Вывод итогового угла
            //Не подходит для тригонометр. операций
        {
            f1.AnswerD.Text = res.gradus.ToString();
            f1.AnswerM.Text = res.minute.ToString();
            f1.AnswerS.Text = res.seconds.ToString();
        }*/
    }
}