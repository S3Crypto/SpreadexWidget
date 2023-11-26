Drawing Application README
Overview
This Drawing Application is a console-based C# project that simulates a basic drawing package. It supports a variety of drawing primitives, known as widgets, which include Rectangles, Squares, Ellipses, Circles, and Textboxes.

Design Decisions

Widget Interface and Classes
IWidget Interface: Implemented to define a standard Draw method for all widgets, adhering to the Interface Segregation and Liskov Substitution principles of SOLID.
Widget Classes: Separate classes for each widget type (Rectangle, Square, etc.) ensure adherence to the Single Responsibility Principle, allowing for easy extension and maintenance.

Canvas Class
Composite Pattern: The Canvas class acts as a composite, holding a collection of IWidget objects. This design facilitates the management and rendering of widgets, demonstrating the Composite Design Pattern.
StringBuilder: Utilized in OutputDrawing for efficient string concatenation, enhancing performance when rendering multiple widgets.

WidgetFactory (Factory Pattern)
Factory Pattern: A WidgetFactory class is implemented to create instances of widgets. This centralized factory simplifies object creation and enhances extensibility by isolating the instantiation logic.
Unit Tests

Comprehensive unit tests ensure the reliability and correctness of each class’s core functionalities. These tests also serve as documentation for the expected behavior of each component.

Further Work

Additional Features
Widget Interactivity: Adding interactive features like moving or resizing widgets.
UI/UX Enhancements: Transitioning to a GUI would significantly improve the user experience.
Advanced Rendering: Incorporating graphical libraries for improved rendering, including potential hardware acceleration.

Design Pattern Utilization
Extension of Factory Pattern: Further refinement or introduction of additional factory types (like Abstract Factory) for more complex widget creation scenarios.

Additional Widget Types
Expanding the range of widgets to include lines, polygons, or custom shapes.

Asynchronous Operations
Implementing asynchronous operations for resource-intensive tasks like loading or rendering.