using System;
namespace SpreadexWidget.Widgets
{
    public class Circle : IWidget
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Diameter { get; private set; }

        public Circle(int x, int y, int diameter)
        {
            if (diameter <= 0)
            {
                throw new ArgumentException("Diameter must be positive.");
            }

            X = x;
            Y = y;
            Diameter = diameter;
        }

        public string Draw()
        {
            return $"Circle ({X},{Y}) size={Diameter}";
        }
    }

}

