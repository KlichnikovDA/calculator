using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Degrees//Временный класс, просто для удобства создания операций + как я его себе представляю
    {
        public int gradus, minute, seconds;
        //Перегруженные методы (для самого класса)
        //Знак сложения (+)
        //Знак умножения (*) !Без понятия как вообще требуется реализовать умножение, потом обсудим
        //Просто может имется в виду угол на угол, так и угол на const
        //Знак деления (/) !Деление аналогично умножению
        //Знак разности (-) с учетом получения отрицательного угла
        //Его таже можно использовать для инвертирования знака
        //Эффективно было бы сделать перевод в радианы (для тригонометр. операций)

    }
    
    class Calculator
    {
        public Degrees ReadForFunctions1Angle(Form1 f1) //Считывание угла для работы
        {
            //Возможно 2 варианта обработки:
            //1)Строки из текстбоксов превращаются в класс угол еще в самой форме
            //2)Они превращаются в данном методе
            //Решайте как удобнее
            Degrees temp = new Degrees();
            Int32.TryParse(f1.Degree1.Text, out temp.gradus);
            Int32.TryParse(f1.Minute1.Text, out temp.minute);
            Int32.TryParse(f1.Second1.Text, out temp.seconds);
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
        }
        public Degrees Summa(Degrees a, Degrees b)
        {
            Degrees sum = new Degrees();
            sum = a + b;//Перегруженная операция
            return sum;
        }
        public Degrees Raznost(Degrees a, Degrees b)
        {
            Degrees raz = new Degrees();
            raz = a - b;//Перегруженная операция
            return raz;
        }
        public Degrees Multiply(Degrees a, Degrees b)
        {
            Degrees mp = new Degrees();
            mp = a*b;//Перегруженная операция
            return mp;
        }
        public Degrees Division(Degrees a, Degrees b)
        {
            Degrees dv = new Degrees();
            dv = a / b;//Перегруженная операция
            return dv;
        }
        public string Sinus(Degrees inp)
        {
            double rad = inp.ToRadians;//Перегрузка ToRadians - для перевода в радианы
            return Math.Sin(rad).ToString();
        }
        public string Cosinus(Degrees inp)
        {
            double rad = inp.ToRadians;//Перегрузка ToRadians - для перевода в радианы
            return Math.Cos(rad).ToString();
        }
        public string Tangens(Degrees inp)
        {
            double rad = inp.ToRadians;//Перегрузка ToRadians - для перевода в радианы
            return Math.Tan(rad).ToString();
        }
        public string Cotangens(Degrees inp)
        {
            double rad = inp.ToRadians;//Перегрузка ToRadians - для перевода в радианы
            return (Math.Cos(rad)/Math.Sin(rad)).ToString();
        }
        public void OutputResult(Form1 f1,Degrees res)//Вывод итогового угла
            //Не подходит для тригонометр. операций
        {
            f1.AnswerD.Text = res.gradus.ToString();
            f1.AnswerM.Text = res.minute.ToString();
            f1.AnswerS.Text = res.seconds.ToString();
        }
    }
}
