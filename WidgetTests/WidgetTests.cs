
using SpreadexWidget.Widgets;
namespace WidgetTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Constructor_ValidParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            int x = 10, y = 20, width = 30, height = 40;

            // Act
            var rectangle = new Rectangle(x, y, width, height);

            // Assert
            Assert.AreEqual(x, rectangle.X);
            Assert.AreEqual(y, rectangle.Y);
            Assert.AreEqual(width, rectangle.Width);
            Assert.AreEqual(height, rectangle.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NegativeWidth_ThrowsArgumentException()
        {
            // Arrange & Act
            var rectangle = new Rectangle(10, 20, -30, 40);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NegativeHeight_ThrowsArgumentException()
        {
            // Arrange & Act
            var rectangle = new Rectangle(10, 20, 30, -40);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ZeroWidth_ThrowsArgumentException()
        {
            // Arrange & Act
            var rectangle = new Rectangle(10, 20, 0, 40);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ZeroHeight_ThrowsArgumentException()
        {
            // Arrange & Act
            var rectangle = new Rectangle(10, 20, 30, 0);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void Draw_WhenCalled_ReturnsCorrectStringFormat()
        {
            // Arrange
            var rectangle = new Rectangle(10, 20, 30, 40);
            var expectedOutput = "Rectangle (10,20) width=30 height=40";

            // Act
            var result = rectangle.Draw();

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }

    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void Constructor_ValidParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            int x = 15, y = 30, size = 35;

            // Act
            var square = new Square(x, y, size);

            // Assert
            Assert.AreEqual(x, square.X);
            Assert.AreEqual(y, square.Y);
            Assert.AreEqual(size, square.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NegativeSize_ThrowsArgumentException()
        {
            // Arrange & Act
            var square = new Square(15, 30, -35);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ZeroSize_ThrowsArgumentException()
        {
            // Arrange & Act
            var square = new Square(15, 30, 0);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void Draw_WhenCalled_ReturnsCorrectStringFormat()
        {
            // Arrange
            var square = new Square(15, 30, 35);
            var expectedOutput = "Square (15,30) size=35";

            // Act
            var result = square.Draw();

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }

    [TestClass]
    public class EllipseTests
    {
        [TestMethod]
        public void Constructor_ValidParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            int x = 100, y = 150, diameterH = 300, diameterV = 200;

            // Act
            var ellipse = new Ellipse(x, y, diameterH, diameterV);

            // Assert
            Assert.AreEqual(x, ellipse.X);
            Assert.AreEqual(y, ellipse.Y);
            Assert.AreEqual(diameterH, ellipse.DiameterH);
            Assert.AreEqual(diameterV, ellipse.DiameterV);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NegativeHorizontalDiameter_ThrowsArgumentException()
        {
            // Arrange & Act
            var ellipse = new Ellipse(100, 150, -300, 200);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NegativeVerticalDiameter_ThrowsArgumentException()
        {
            // Arrange & Act
            var ellipse = new Ellipse(100, 150, 300, -200);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ZeroHorizontalDiameter_ThrowsArgumentException()
        {
            // Arrange & Act
            var ellipse = new Ellipse(100, 150, 0, 200);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ZeroVerticalDiameter_ThrowsArgumentException()
        {
            // Arrange & Act
            var ellipse = new Ellipse(100, 150, 300, 0);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void Draw_WhenCalled_ReturnsCorrectStringFormat()
        {
            // Arrange
            var ellipse = new Ellipse(100, 150, 300, 200);
            var expectedOutput = "Ellipse (100,150) diameterH = 300 diameterV = 200";

            // Act
            var result = ellipse.Draw();

            // Assert
            Assert.AreEqual(expectedOutput, result);
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

