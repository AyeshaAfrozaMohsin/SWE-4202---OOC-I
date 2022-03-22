using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Processing_System__RPS__for_IUT__Sem2_Lab_Final_
{
    internal class Student
    {
        public string ID;
        public string Name;
        public double Attendance;
        public double[] Quizes = new double[] { 0.0, 0.0, 0.0, 0.0 };
        public double Mid = 0;
        public double Final= 0;
        public double Viva = 0;

        public Student()
        {
            
        }

        public static string SpecificLength(string alpha, int count )
        {
            var builder = new StringBuilder();
            foreach (var c in alpha)
            {
                builder.Append(c);
                count--;
            }
            for(; count>0 ; count--)
            {
                builder.Append(" ");
            }

            return builder.ToString();
        }

        public double CalculateTotal()
        {
            double total = Attendance + Mid + Final + Viva;
            Array.Sort(Quizes);
            Array.Reverse(Quizes);
            foreach ( double Quiz in Quizes)
            {
                total += Quiz;
            }
            return total;
        }

        public double CalculatePercentage()
        {
            return (double)System.Math.Round(CalculateTotal() / 3, 2);
        }

        public string CalculateGrade()
        {
            double percent = CalculatePercentage();
            if (percent <= 100 && percent >= 80)
                return  "A+";
            if (percent < 80 && percent >= 75)
                return  "A";
            if (percent < 75 && percent >= 70)
                return  "A-";
            if (percent < 70 && percent >= 65)
                return  "B+";
            if (percent < 65 && percent >= 60)
                return  "B";
            if (percent < 60 && percent >= 55)
                return  "B-";
            if (percent < 55 && percent >= 50)
                return  "C+";
            if (percent < 50 && percent >= 45)
                return  "C";
            if (percent < 45 && percent >= 40)
                return  "D";
            if (percent < 40 && percent >= 0)
                return "F";
            else return "Ya Allah";
        }

    }
}
