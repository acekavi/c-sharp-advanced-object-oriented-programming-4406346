// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog {
    Name = "Luka",
    Age = 2
};

Cat cat = new Cat {
    Name = "Lily",
    Age = 3,
    IsDeclawed = true
};

Console.WriteLine($"{dog.GetType()} {dog.Name} is {dog.Age} years old");
Console.WriteLine($"{cat.GetType()} {cat.Name} is {cat.Age} years old");

// TODO: Initializers can be used on anonymous types
var pet = new {
    Name = "Cameo",
    Age = 5
};

// TODO: Collections can also be initialized this way
int[] numbers = new int[] { 1,5,6,7,8};
Console.WriteLine($"{numbers.Length}");

// TODO: Initialize a collection with a set of objects

PetOwner ace = new PetOwner{
    Name = "Ace",
    Pets = new List<Pet>{
        new Dog{
            Name = "Lilly",
            Age = 4
        }, dog, cat
    }
};

Console.WriteLine($"{ace}");
foreach (Pet thisPet in  ace.Pets){
    Console.WriteLine($"{thisPet.GetType()} {thisPet.Name} is {thisPet.Age} years old");
}