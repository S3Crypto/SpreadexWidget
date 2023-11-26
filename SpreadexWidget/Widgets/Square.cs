using System;
namespace SpreadexWidget.Widgets
{
    public class Square : IWidget
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Size { get; private set; }

        public Square(int x, int y, int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size must be positive.");
            }

            X = x;
            Y = y;
            Size = size;
        }

        public string Draw()
        {
            return $"Square ({X},{Y}) size={Size}";
        }
    }

}

