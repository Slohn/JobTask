using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTask
{
    public class Triangle : Shape
    {
        public int EdgeA { get; set; }
        public int EdgeB { get; set; }
        public int EdgeC { get; set; }

        public Triangle(int a, int b , int c) 
        {
            if(IsValid(a,b,c))
            EdgeA = a;
            EdgeB = b;
            EdgeC = c;
        }
        public override double Square()
        {
            var p = (EdgeA + EdgeB + EdgeC) / 2;
            var square = Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
            return square;
        }

        public bool isStraightTriangle() 
        {
            bool isStraight = (EdgeA == Math.Sqrt(Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2))
                               || EdgeB == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2))
                               || EdgeC == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2)));

            return isStraight;
        }

        public bool IsValid(int a, int b, int c) 
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Такого треугольника не существует(сторона меньше 0)");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new Exception("Такого треугольника не существует(сторона больше суммы двух других)");
            }

            return true;
        }

    }
}
