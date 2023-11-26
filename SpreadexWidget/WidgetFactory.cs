using SpreadexWidget.Widgets;

namespace SpreadexWidget
{
    public class WidgetFactory
    {
        public Rectangle CreateRectangle(int x, int y, int width, int height)
        {
            return new Rectangle(x, y, width, height);
        }

        public Square CreateSquare(int x, int y, int size)
        {
            return new Square(x, y, size);
        }

        public Ellipse CreateEllipse(int x, int y, int diameterH, int diameterV)
        {
            return new Ellipse(x, y, diameterH, diameterV);
        }

        public Circle CreateCircle(int x, int y, int diameter)
        {
            return new Circle(x, y, diameter);
        }

        public Textbox CreateTextbox(int x, int y, int width, int height, string text)
        {
            return new Textbox(x, y, width, height, text);
        }
    }
}


