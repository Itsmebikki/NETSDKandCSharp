//class Program
//{
//   public static void Main()
//   {
//     Console.WriteLine("Hello, World!");  
//   }
//}
//creating object for student
// Student s1 = new();
// Student s2 = new();
// Student s3 = new();
// Student s4 = new();
// Student s5 = new();
// Student s6 = new();

// s1.name = "Ram";
// s1.address="KTM";
// s1.roll=22;
// s1.dateOfBirth= new DateTime(2000,09,24);

// Console.WriteLine($"{s1.name} {s1.address} {s1.roll} {s1.dateOfBirth}");

//Creating object for Animal class

// using System.Runtime.InteropServices.Marshalling;

// Animal a1 = new();
// Animal a2 = new();
// Animal a3 = new();

// a1.name = "Dog";
// a1.type = "Land animal";
// a1.legs = 4;
// a1.weight = 15;
// a1.color = "Black";

// a2.name = "Lizard";
// a2.type = "Reptile";
// a2.legs = 4;
// a2.weight = 10;
// a2.color = "Grey";

// Console.WriteLine($"Name:{a1.name} \nType:{a1.type}\nLegs:{a1.legs}\nWeight:{a1.weight}\nColor: {a1.color}");
// Console.WriteLine("\n");
// Console.WriteLine($"Name:{a2.name} \nType:{a2.type}\nLegs:{a2.legs}\nWeight:{a2.weight}\nColor: {a2.color}");


//Day10 example
Rectangle r=new(3.5,2.3);
var P=r.GetPerimeter();
var  A=r.GetArea();

Square sq1=new(7);
P=sq1.GetPerimeter();
A=sq1.GetArea();

Circle c1 = new(5);
var  PC = c1.GetPerimeter();
var AC = c1.GetArea();
Console.WriteLine("The perimeter of cirle is"+PC);
Console.WriteLine("The area of cirle is"+AC);

Sphere sp1 = new(23.5);
var Sa = c1.GetArea();
sp1.PrintSphereInfo();