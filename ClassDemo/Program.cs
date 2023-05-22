using ClassDemo;

//Dot Notation
var seth = new Person();
seth.Name = "Seth";
seth.Age = 29;
seth.IsMarried = true;
seth.Weight = 155.55;

seth.Greet();

//Object Initializer Syntax
var john = new Person() 
{ 
    Name = "John",
    Age = 32 
};

john.Greet();

//Using a custom constructor
var monica = new Person("Monica", 27, true, "brown", 100);
monica.Greet();