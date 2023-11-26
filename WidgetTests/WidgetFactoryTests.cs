using System;
using SpreadexWidget;
using SpreadexWidget.Widgets;

namespace WidgetTests
{
    [TestClass]
    public class WidgetFactoryTests
    {
        [TestMethod]
        public void CreateRectangle_ReturnsRectangleInstance()
        {
            // Arrange
            var factory = new WidgetFactory();

            // Act
            var rectangle = factory.CreateRectangle(10, 10, 30, 40);

            // Assert
            Assert.IsInstanceOfType(rectangle, typeof(Rectangle));
        }

        [TestMethod]
        public void CreateSquare_ReturnsSquareInstance()
        {
            // Arrange
            var factory = new WidgetFactory();

            // Act
            var square = factory.CreateSquare(15, 30, 35);

            // Assert
            Assert.IsInstanceOfType(square, typeof(Square));
        }

        [TestMethod]
        public void CreateEllipse_ReturnsEllipseInstance()
        {
            // Arrange
            var factory = new WidgetFactory();

            // Act
            var ellipse = factory.CreateEllipse(100, 150, 300, 200);

            // Assert
            Assert.IsInstanceOfType(ellipse, typeof(Ellipse));
        }

        [TestMethod]
        public void CreateCircle_ReturnsCircleInstance()
        {
            // Arrange
            var factory = new WidgetFactory();

            // Act
            var circle = factory.CreateCircle(1, 1, 300);

            // Assert
            Assert.IsInstanceOfType(circle, typeof(Circle));
        }

        [TestMethod]
        public void CreateTextbox_ReturnsTextboxInstance()
        {
            // Arrange
            var factory = new WidgetFactory();

            // Act
            var textbox = factory.CreateTextbox(5, 5, 200, 100, "sample text");

            // Assert
            Assert.IsInstanceOfType(textbox, typeof(Textbox));
        }
    }
}

