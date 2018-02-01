using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Circle
    {
        private double radius;
        private const double PI = Math.PI;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateCircumference()
        {
            double circumference = this.radius * 2 * PI;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatedNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            double area = PI * Math.Pow(this.radius, 2);
            return area;
        }

        public string CalculateFormattedArea()
        {
            return FormatedNumber(CalculateArea());
        }

        private string FormatedNumber(double x)
        {
            return Math.Round(x,2).ToString();
        }

        public void SetRadius(double r)
        {
            this.radius = r;
        }

    }
}
