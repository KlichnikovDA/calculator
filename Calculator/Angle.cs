using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Angle
    {
        // Поля класса
        int Degree, Minute, Second;

        // Конструктор без параметров
        public Angle()
        {
            Degree = Minute = Second = 0;
        }

        // Конструктор с параметрами
        public Angle(int Deg, int Min, int Sec)
        {
            Degree = Deg;
            Minute = Min;
            Second = Sec;
        }

        // Перевод в строковый вид
        public override string ToString()
        {
            return this.Degree + "°" + this.Minute + "'" + this.Second + "''";
        }

        // Перегрузка оператора +
        public static Angle operator +(Angle A1, Angle A2)
        {
            Angle Result = new Angle();

            Result.Second = A1.Second + A2.Second;
            Result.Minute = A1.Minute + A2.Minute + Result.Second / 60;
            Result.Second %= 60;
            Result.Degree = A1.Degree + A2.Degree + Result.Minute / 60;
            Result.Minute %= 60;
            return Result;
        }

        // Перегрузка оператора -
        public static Angle operator -(Angle A1, Angle A2)
        {
            Angle Result = new Angle();

            Result.Second = A1.Second - A2.Second;
            if (Result.Second < 0)
            {
                Result.Second += 60;
                A1.Minute--;
            }
            Result.Minute = A1.Minute - A2.Minute;
            if (Result.Minute < 0)
            {
                Result.Minute += 60;
                A1.Degree--;
            }
            Result.Degree = A1.Degree - A2.Degree;
            return Result;
        }

        // Перегрузка оператора *
        public static Angle operator *(Angle A1, int Mult)
        {
            int Result = (A1.Degree * 3600 + A1.Minute * 60 + A1.Second) * Mult;
            return new Angle(Result / 3600, Result % 3600 / 60, Result % 60);            
        }

        // Перегрузка оператора *
        public static Angle operator *(int Mult, Angle A1)
        {
            int Result = (A1.Degree * 3600 + A1.Minute * 60 + A1.Second) * Mult;
            return new Angle(Result / 3600, Result % 3600 / 60, Result % 60);
        }

        // Перегрузка оператора /
        public static Angle operator /(Angle A1, int Div)
        {
            int Result = (A1.Degree * 3600 + A1.Minute * 60 + A1.Second) / Div;
            return new Angle(Result / 3600, Result % 3600 / 60, Result % 60);
        }

        // Перегрузка оператора /
        public static Angle operator /(int Div, Angle A1)
        {
            int Result = (A1.Degree * 3600 + A1.Minute * 60 + A1.Second) / Div;
            return new Angle(Result / 3600, Result % 3600 / 60, Result % 60);
        }
    }
}