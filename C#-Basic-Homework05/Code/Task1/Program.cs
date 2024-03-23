//Create a class Shape that has:
//Name
//Color
//Position, array of x and y coordinates (int[])
//getArea - method that will only write in the console that there is no special implementation for area
//getPerimeter - method that will only write in the console that there is no special implementation for perimeter
//*add method move that is shared among all instances and can be accessed through the class name.
//It updates the position of the input, by increasing the coordinates for 5.

//create a setter and getter for the color and name property. The setter/getter will log a corresponding message. The setter should do validation.

//Add class Rectangle, that inherits from Shape. It should have properties sideA and sideB.
//Override the getArea and getPerimeter methods correspondingly for a rectangle.

//Add class Circle, that inherits from Shape. It should have property radius.
//Override the getArea and getPerimeter methods correspondingly for a circle.

//Test with few objects.

using Task1.Models;

Rectangle rectangleBig = new Rectangle("Big Rectangle", "Red", new int[] { 2, 5 }, 20, 10);
Rectangle rectangleSmall = new Rectangle("Small Rectangle", "Blue", new int[] { 20, 50 }, 10, 5);
rectangleBig.GetArea();
rectangleBig.GetPerimeter();
Console.WriteLine($"The {rectangleBig.GetName()} new coordinates are: ");
rectangleBig.Move();
rectangleSmall.GetArea();
rectangleSmall.GetPerimeter();
Console.WriteLine($"The {rectangleSmall.GetName()} new coordinates are: ");
rectangleSmall.Move();

Circle circleBig = new Circle("Big Circle", "Pink", new int[] { -5, -10 }, 30);
Circle circleSmall = new Circle("Small Circle", "Violet", new int[] { -50, -150 }, 10);
circleBig.GetArea();
circleBig.GetPerimeter();
Console.WriteLine($"The {circleBig.GetName()} new coordinates are: ");
circleBig.Move();
circleSmall.GetArea();
circleSmall.GetPerimeter();
Console.WriteLine($"The {circleSmall.GetName()} new coordinates are: ");
circleSmall.Move();

