using System;

namespace WindowsFormsApp1
{
    internal class Triangle
    {
        double firstside, secondside, thirdside;

        public double Firstside { get => firstside; set => firstside = ( value > 0 ? value : -1); }
        public double Secondside { get => secondside; set => secondside = (value > 0 ? value : -1); }
        public double Thirdside { get => thirdside; set => thirdside = (value > 0 ? value : -1); }
        public string Title { get; set; }

        public Triangle()
        {
            Console.WriteLine("New triangle was created!");
        }

        public Triangle(double firstside, double secondside, double thirdside, string title)
        {
            Firstside = firstside;
            Secondside = secondside;
            Thirdside = thirdside;
            Title = title;
        }

        public bool Existence()
        {
            bool result = false;
            if (Firstside + Secondside > Thirdside && Firstside + Thirdside > Secondside && Secondside + Thirdside > Firstside)
            {
                result = true;
            }
            return result;
        }

        public void Angle(out double frstangle, out double secangle, out double thrdangle)
        {
            double Pow1 = Math.Pow(Firstside, 2);
            double Pow2 = Math.Pow(Secondside, 2);
            double Pow3 = Math.Pow(Thirdside, 2);
            frstangle = (180 / Math.PI) * Math.Acos((Pow1 + Pow3 - Pow2) / (2 * Firstside * Thirdside));
            secangle = (180 / Math.PI) * Math.Acos((Pow1 + Pow2 - Pow3) / (2 * Firstside * Secondside));
            thrdangle = 180 - (frstangle + secangle);
        }

        public double Perimeter()
        {
            return Firstside + Secondside + Thirdside;
        }

        public double Area()
        {
            double halfper = Perimeter() / 2;
            return Math.Sqrt(halfper * (halfper - Firstside) * (halfper - Secondside) * (halfper - Thirdside));
        }

        public void Results()
        {
            Console.WriteLine($"The lengths of the sides of the triangle: {Firstside}, {Secondside} and {Thirdside}");
            Console.WriteLine(Existence() ? "This is triangle" : "This is not triangle");
            Angle(out double frstangle, out double secangle, out double thrdangle);
            Console.WriteLine($"First angle: {frstangle}, second angle: {secangle}, third angle {thrdangle} ");
            Console.WriteLine(Perimeter());
            Console.WriteLine(Area());
        }
    }

    internal class Triangleright : Triangle
    {
        public Triangleright(double Firstside, double Secondside, double Thirdside, string Title)
           : base(Firstside, Secondside, Thirdside, Title)
        {
        }

        public bool Check()
        {
            if (Firstside == Math.Sqrt(Math.Pow(Secondside, 2) + Math.Pow(Thirdside, 2)) ||
                Secondside == Math.Sqrt(Math.Pow(Firstside, 2) + Math.Pow(Thirdside, 2)) ||
                Thirdside == Math.Sqrt(Math.Pow(Secondside, 2) + Math.Pow(Firstside, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Hypotenuse()
        {
            double H = 0;
            if (Firstside > Secondside && Firstside > Thirdside)
            {
                return Firstside;
            }
            else if (Secondside > Firstside && Secondside > Thirdside)
            {
                return Secondside;
            }
            else
            {
                return Thirdside;
            }
        }
    }
}