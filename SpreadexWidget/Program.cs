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

            var widgetFactory = new WidgetFactory();

            // Create widgets
            var rectangle = widgetFactory.CreateRectangle(10, 10, 30, 40);
            var square = widgetFactory.CreateSquare(15, 30, 35);
            var ellipse = widgetFactory.CreateEllipse(100, 150, 300, 200);
            var circle = widgetFactory.CreateCircle(1, 1, 300);
            var textbox = widgetFactory.CreateTextbox(5, 5, 200, 100, "sample text");

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
