using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public interface Ishape
    {

    }
    public interface I2DShape : Ishape
    {
        double GetArea();
    }
    public interface I3DShape : Ishape
    {
        double GetVolume();
    }

    public class Circle : I2DShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double GetArea()
        {

            return Math.PI * Radius * Radius; ;
        }


    }

    public class Rectangle : I2DShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double GetArea()
        {
            return Breadth * Length;
        }
    }


    public class Square : I2DShape
    {
        public double Side { get; set; }
        public double GetArea()
        {
            return Side * Side;
        }
    }

    public class Cube : I3DShape
    {
        public double Side { get; set; }

        public double GetVolume()
        {
            return Side * Side * Side;
        }
    }
}
