﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double h; // Высота
        public int status;
        public bool _exists = false;
        

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
            
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }

        public string outputB()
        {
            return Convert.ToString(b);
        }

        public string outputC()
        {
            return Convert.ToString(c);
        }

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }

        public double perimeterforh()
        {
            return Perimeter() * 0.5; // Формула для вычисления
        }

        public double Height() // Вычисление высоту треугольника
        {

            double p = perimeterforh();
            double h = Math.Round(2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a); // Формула для вычисления

            return h; // Выводим высоту

        }

        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Round(Math.Sqrt((p * (p - a) * (p - b) * (p - c))), 3);
            return s;
        }

        public double GetAplha()
        {
            double alpha = 0;
            alpha = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
            return alpha;
        }

        public double GetBeta()
        {
            double beta = 0;
            beta = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI);
            return beta;
        }

        public double GetGamma()
        {
            double gamma = 0;
            gamma = Math.Acos((b * b + c * c - a * a) / (2 * c * b)) * (180 / Math.PI);
            return gamma;
        }

        public double GetSetA
        {
            get { return a; }
            set { a = value; }
        }

        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }

        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }

        public bool ExistTriangle()
        {
            if((a + b > c) && (b + c > a) && (c + a > b))
            {
                _exists = true;
            }
            else
            {
                _exists = false;
            }
            return _exists;
        }
        
}
}
