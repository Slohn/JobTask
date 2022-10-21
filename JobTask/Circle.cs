using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTask
{
    public class Circle: Shape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double Square() 
        {
            return Math.Round(3.14f + Math.Pow(Radius, 2), 1);
            
        }
    }
}
