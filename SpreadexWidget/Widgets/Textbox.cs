using System;
namespace SpreadexWidget.Widgets
{
    public class Textbox : IWidget
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Text { get; private set; }

        public Textbox(int x, int y, int width, int height, string text)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Width and Height must be positive.");
            }

            X = x;
            Y = y;
            Width = width;
            Height = height;
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public string Draw()
        {
            return $"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"";
        }
    }

}

