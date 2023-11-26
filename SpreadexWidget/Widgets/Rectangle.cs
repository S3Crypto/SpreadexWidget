using System;
namespace SpreadexWidget.Widgets
{
    public class Rectangle : IWidget
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int x, int y, int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Width and Height must be positive.");
            }

            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string Draw()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }

}

