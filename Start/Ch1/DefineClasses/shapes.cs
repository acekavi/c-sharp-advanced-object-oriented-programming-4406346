// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
class Rectangle {
    // TODO: member variables hold data
    int width;
    int height;

    // TODO: The constructor accepts parameters used to create the object
    public Rectangle(int width, int height){
        this.height = height;
        this.width = width;
    }

    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size

    public Rectangle(int side){
        this.height = this.width = side;
    }

    // TODO: Classes can define methods that return values
    public int GetArea(){
        return width * height;
    }
}
