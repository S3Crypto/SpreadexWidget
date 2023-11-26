using System;
using SpreadexWidget;
using SpreadexWidget.Widgets;
using System.Text;

namespace WidgetTests
{
    [TestClass]
    public class CanvasTests
    {
        private Canvas canvas;
        private IWidget rectangle;
        private IWidget circle;

        [TestInitialize]
        public void TestInitialize()
        {
            canvas = new Canvas();
            rectangle = new Rectangle(10, 20, 30, 40);
            circle = new Circle(1, 1, 50);
        }

        [TestMethod]
        public void AddWidget_WidgetAdded_CanvasContainsWidget()
        {
            // Act
            canvas.AddWidget(rectangle);

            // Assert
            var output = canvas.OutputDrawing();
            StringAssert.Contains(output, rectangle.Draw());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddWidget_NullWidget_ThrowsArgumentNullException()
        {
            // Act
            canvas.AddWidget(null);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void OutputDrawing_MultipleWidgets_ReturnsCorrectStringFormat()
        {
            // Arrange
            canvas.AddWidget(rectangle);
            canvas.AddWidget(circle);

            var expectedOutput = new StringBuilder();
            expectedOutput.AppendLine("----------------------------------------------------------------");
            expectedOutput.AppendLine("Requested Drawing");
            expectedOutput.AppendLine("----------------------------------------------------------------");
            expectedOutput.AppendLine(rectangle.Draw());
            expectedOutput.AppendLine(circle.Draw());
            expectedOutput.AppendLine("----------------------------------------------------------------");

            // Act
            var output = canvas.OutputDrawing();

            // Assert
            Assert.AreEqual(expectedOutput.ToString(), output);
        }
    }
}

