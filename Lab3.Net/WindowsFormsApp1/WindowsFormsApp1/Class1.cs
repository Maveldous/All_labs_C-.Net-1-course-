using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ComplexNum
    {
        private double x, y;
        private int pr;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public int PR { get => pr; set => pr = value; }

        public ComplexNum()
        {
            X = 0;
            Y = 0;
        }

        public ComplexNum(int pr, double x, double y)
        {
            PR = pr;
            X = x;
            Y = y;
        }

        public static ComplexNum operator +(ComplexNum xfirst, ComplexNum yfirst)
        {
            return new ComplexNum { X = xfirst.X + yfirst.X, Y = xfirst.Y + yfirst.Y };
        }

        public static ComplexNum operator -(ComplexNum xfirst, ComplexNum yfirst)
        {
            return new ComplexNum { X = xfirst.X - yfirst.X, Y = xfirst.Y - yfirst.Y };
        }

        public static ComplexNum operator *(ComplexNum xfirst, ComplexNum yfirst)
        {
            return new ComplexNum { X = (xfirst.X * yfirst.X - xfirst.Y * yfirst.Y), Y = (xfirst.X * yfirst.Y + xfirst.Y * yfirst.X) };
        }

        public static ComplexNum operator /(ComplexNum xfirst, ComplexNum yfirst)
        {
            return new ComplexNum
            {
                X = (xfirst.X * yfirst.X + xfirst.Y * yfirst.Y) / (yfirst.X * yfirst.X + yfirst.Y * yfirst.Y),
                Y = (xfirst.Y * yfirst.X - xfirst.X * yfirst.Y) / (yfirst.X * yfirst.X + yfirst.Y * yfirst.Y)
            };
        }

        public string Showresult()
        {
            string result;
            double p;
            if (X >= 0 && Y >= 0)
            {
                p = Math.Atan(Y / X);
            }
            else if (X < 0 && Y > 0)
            {
                p = Math.PI + Math.Atan(Y / X);
            }
            else
            {
                p = -Math.PI + Math.Atan(Y / X);
            }
            result = $"Тригонометрическая форма вывода: |{Math.Round(Math.Sqrt(X * X + Y * Y), 2)}" +
                    $"|*(cos({Math.Round(p, 2)})+isin({Math.Round(p, 2)})\n" +
                    $"Алгебраическая форма вывода: {X} + {Y}i";
            return result;
        }
    }
}
