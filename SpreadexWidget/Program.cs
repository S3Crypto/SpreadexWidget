using SpreadexWidget;
using SpreadexWidget.Widgets;

namespace SpreadexWidget
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new canvas
            var canvas = new Canvas();

            // Create widgets
            var rectangle = new Rectangle(10, 10, 30, 40);
            var square = new Square(15, 30, 35);
            var ellipse = new Ellipse(100, 150, 300, 200);
            var circle = new Circle(1, 1, 300);
            var textbox = new Textbox(5, 5, 200, 100, "sample text");

            // Add widgets to the canvas
            canvas.AddWidget(rectangle);
            canvas.AddWidget(square);
            canvas.AddWidget(ellipse);
            canvas.AddWidget(circle);
            canvas.AddWidget(textbox);

            // Output the canvas drawing
            Console.WriteLine(canvas.OutputDrawing());
        }
    }
}
