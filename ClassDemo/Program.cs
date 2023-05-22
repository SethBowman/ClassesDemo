using ClassDemo;

//Instance of the Classroom class so we can use the list it holds as a property
var classroom = new Classroom();

//Dot Notation
var seth = new Person();
seth.Name = "Seth";
seth.Age = 29;
seth.IsMarried = true;

//Adding to the list
classroom.OurClass.Add(seth);

//Object Initializer Syntax
var john = new Person()
{
    Name = "John",
    Age = 32
};

//Adding to the list
classroom.OurClass.Add(john);

//Using a custom constructor
var monica = new Person("Monica", 27, true, "brown");

//Adding to the list
classroom.OurClass.Add(monica);

//Since all the instances are now in our list and the GetDetails method calls the Greet method from person
//We will now see every persons greeting
classroom.GetDetails();


