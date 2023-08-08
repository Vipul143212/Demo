using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Circle
    {
        private readonly double _radius;
        public Circle(double Radius)
        {
            _radius = Radius;
        }
        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 4);
        }
        public double GetCircumference()
        {
            return Math.Round(2 * Math.PI + _radius, 4);
        }
    }
}
