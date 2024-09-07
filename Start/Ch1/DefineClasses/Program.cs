// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle rect1 = new Rectangle(10, 20);
Rectangle sq1 = new Rectangle(25);

Console.WriteLine($"Rectangle Area : {rect1.GetArea()}");
Console.WriteLine($"Square Area : {sq1.GetArea()}");
// TODO: Change the values of width and height

// rect1.width = 5;
// sq1.width = 10;

Console.WriteLine($"Rectangle Area : {rect1.GetArea()}");
Console.WriteLine($"Square Area : {sq1.GetArea()}");