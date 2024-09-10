// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myObj = new {
    Name = "Saman",
    Age = 45,
    Address = new {
        House = "2132",
        City = "Galle"
    }
};

Console.WriteLine(myObj.Address.City);

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error
// myObj.Name = "Ace";
// TODO: To change a value, use non-destructive mutation and "with" clause
var myObj2 = myObj with {Name = "Ace"};
Console.WriteLine($"{myObj2.Name}, {myObj2.Address.City}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myObj2.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myObj2.GetType().GetProperty("Sex") != null}");
