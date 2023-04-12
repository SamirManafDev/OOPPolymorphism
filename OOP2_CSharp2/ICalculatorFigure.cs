using System;

namespace OOP2_CSharp
{
    public interface ICalculateable
    {
        void CalculteArea();
        void CalculatePerimetr();
    }
    class Square : ICalculateable
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public void CalculteArea()
        {
            Console.WriteLine($"Square Area:{Side * Side}");
        }
        public void CalculatePerimetr()
        {
            Console.WriteLine($"Square Perimetr:{4 * Side}");
        }
    }

    class Circle : ICalculateable
    {   
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void CalculteArea()
        {
            Console.WriteLine($"Area:{Math.PI * (Radius * Radius)}");
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr:{2 * (Math.PI * Radius)}");
        }
    }
        public class Triangle : ICalculateable
        {
            public double Side { get; set; }
            public double Height { get; set; }
            public Triangle(double side, double height)
            {
                Side = side;
                Height = height;
            }


            public void CalculatePerimetr()
            {
                Console.WriteLine($"Triangle Perimetr:{3 * Side}");
            }

            public void CalculteArea()
            {
                Console.WriteLine($"Triangle Area:{0.5 * Side * Height}");
            }
        }
    
}