
using SpreadexWidget.Widgets;
namespace WidgetTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Draw_WhenCalled_ReturnsEmptyString()
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act
            var result = rectangle.Draw();

            // Assert
            Assert.AreEqual("", result);
        }
    }

    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void Draw_WhenCalled_ReturnsEmptyString()
        {
            // Arrange
            var square = new Square();

            // Act
            var result = square.Draw();

            // Assert
            Assert.AreEqual("", result);
        }
    }

    [TestClass]
    public class EllipseTests
    {
        [TestMethod]
        public void Draw_WhenCalled_ReturnsEmptyString()
        {
            // Arrange
            var ellipse = new Ellipse();

            // Act
            var result = ellipse.Draw();

            // Assert
            Assert.AreEqual("", result);
        }
    }

    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Draw_WhenCalled_ReturnsEmptyString()
        {
            // Arrange
            var circle = new Circle();

            // Act
            var result = circle.Draw();

            // Assert
            Assert.AreEqual("", result);
        }
    }

    [TestClass]
    public class TextboxTests
    {
        [TestMethod]
        public void Draw_WhenCalled_ReturnsEmptyString()
        {
            // Arrange
            var textbox = new Textbox();

            // Act
            var result = textbox.Draw();

            // Assert
            Assert.AreEqual("", result);
        }
    }
}

