using SpreadexWidget.Widgets;
using System.Text;

namespace SpreadexWidget
{
    public class Canvas
    {
        private List<IWidget> widgets;

        public Canvas()
        {
            widgets = new List<IWidget>();
        }

        public void AddWidget(IWidget widget)
        {
            if (widget == null)
            {
                throw new ArgumentNullException(nameof(widget));
            }
            widgets.Add(widget);
        }

        public string OutputDrawing()
        {
            var output = new StringBuilder();
            output.AppendLine("----------------------------------------------------------------");
            output.AppendLine("Requested Drawing");
            output.AppendLine("----------------------------------------------------------------");

            foreach (var widget in widgets)
            {
                output.AppendLine(widget.Draw());
            }

            output.AppendLine("----------------------------------------------------------------");
            return output.ToString();
        }
    }

}

