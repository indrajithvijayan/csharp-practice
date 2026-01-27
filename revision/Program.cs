
//class Person
//{
//    public string Name;
//    public int age;

//    public void speak()
//    {
//        Console.WriteLine($"{Name} is {age} years old");

//    }
//}

//class Progarm
//{
//    public static void Main(string[] args)
//    {
//        Person p = new Person();
//        p.Name = "kulsuboy";
//        p.age = 22;
//        p.speak();
//    }
//}

//class car
//{
//    public string brand;

//    public car(string brand)
//    {
//        brand = brand;
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        car c = new car("bmw");
//        Console.WriteLine(c.brand);
//    }
//}

//OOPS AND CLASS AND OBJECTS FROM SCRATCH

//class Person
//{
//    public string Name;
//    public int age;
//    public void speak()
//    {
//        Console.WriteLine("i am speaking");
//    }
//}

//      LINQ
//string[] names = { "dhanysh", "arun", "vishnu", "akhil" };
//var shortnames = from n in names
//                 where n.Length < 6
//                 select n;
//Console.WriteLine("short Names");

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("please enter your name");
//        string Name = Console.ReadLine();
//        // dat type variable name = "value of variable"
//        Console.WriteLine("hello"  +   Name);
//    }
//}

//int day = 7;

//switch (day)
//{
//    case 1: Console.WriteLine("monday");break;
//    case 2: Console.WriteLine("tuesday");break;
//    case 3: Console.WriteLine("wendsday"); break;
//    case 4: Console.WriteLine("thursday"); break;
//    case 5: Console.WriteLine("friday"); break;
//    default:Console.WriteLine("invalid day");break;
//}

//   LOOPS

//for (int i = 1; i <= 5; i++) 
//{
//    Console.WriteLine(i);
//}

//class Program
//{
//    public static void Main() 
//    {  /// relational & logical
//        int age = 22;
//        bool haslicence = true;
//        bool candrive = (age>18) && haslicence;

//        //bitwise
//        int x = 5;
//        int y = 3;
//        int bitResult = x & y;

//        string driverstatus = candrive ? "authorise driver" : "not authorised ";

//        int score = 10;
//        score += 5;

//        Console.WriteLine("status"  +  driverstatus);
//        Console.WriteLine("bitwise and"+ bitResult);
//        Console.WriteLine("final score"+ score);




//    }


//}

//class Human
//{
//    public string Name;
//    public int Age;
//    public void Speak()
//    {
//        Console.WriteLine(Name + "  is speaking.and the age is " + Age);
//    }

//}

//class Program
//{
//    static void Main()
//    {
//        Human H = new Human();
//        H.Age = 25;
//        H.Name = "ajay";

//        Human h2 = new Human();
//        h2.Name = "indran";
//        h2.Age = 22;

//        H.Speak();
//        h2.Speak();

//    }

//}

//  inheritance

//class Animal
//{
//    public string Name;

//    public string breed;

//    public void Eat()
//    {

//        Console.WriteLine(Name + "EATOMG");
//    }

//}

//class Dog:Animal
////{

//    public void Bark()
//    {
//        Console.WriteLine(breed + " is the type of that");

//    }
//}

//class Program
//{
//    public static void Main() {

//        Dog d = new Dog();
//        d.Name = "tuttu";
//        d.breed = "lab";
//        d.Eat();
//        d.Bark();

//        Dog d2 = new Dog();
//        d2.Name = "siya";
//        d2.breed = "pitbull";
//        d2.Bark();
//        d2.Eat();

//    }

//}

//    ENCAPSULATION

//class Bnakaccount
//{
//    private double Balance;
//    public double balance;
//    {
//        get { return Balance; }
//        set
//        {

//            if (value >= 0)
//                balance = value;
//        }
//    }


//}
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        student s = new ();
//        s.age = 20;

//        s.age = -10;


//        Console.WriteLine("sudent age " + s.age);
//    }
//}lass student
//{
//    private int Age;
//    public int age
//    {
//        get { return age; }

//        set
//        {
//            if (value > 0)
//            {
//               _age = value;
//            }
//            else
//            {
//                Console.WriteLine("only ente valid value ");
//            }
////        }

//using System;

//class Student
//{
//    // 1. Data Hide cheyyunnu (Private Field)
//    private int age;

//    // 2. Access cheyyaan ulla vazhi (Public Property)
//    public int Age
//    {
//        get { return age; } // Value vaayikkaan
//        set
//        {
//            // Ivide namukku logic check cheyyaam
//            if (value > 0 && value < 100)
//            {
//                age = value;
//            }
//            else
//            {
//                Console.WriteLine("Dayaayi valid aaya age mathram enter cheyyuka!");
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s1 = new Student();

//        // s1.age = -5; // Ithu nadakkilla (Private aaya nala)

//        s1.Age = 20;    // Ithu work aakum
//        s1.Age = -10;   // "Dayaayi valid aaya age..." ennu print aakum

//        Console.WriteLine("Student Age: " + s1.Age);
//    } 
//} 
//class StudentDetails
//{
//    public void StudentAge()
//    {
//        int Age = 10;    // local variable
//        Age = Age + 10;
//        Console.WriteLine(Age);
//    }
//    public static void Main(string[] args)
//    {
//        StudentDetails obj = new StudentDetails();
//        obj.StudentAge();
//    }
//}

//class Program
//{
//    static void Main() {
//        string[] Names = { "rahul", "anjali", "sree", "amit" };

//        var aNames = Names.Where(n => n.StartsWith("a"));

//        Console.WriteLine("names start with A:");
//        foreach (var Name in aNames) {
//            Console.WriteLine(Name);
//        }

//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Employee
//{
//    public string Name { get; set; }
//    public string City { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "abhi", City = "kochi" },
//            new Employee { Name = "snaha", City = "banglore" },
//            new Employee { Name = "anu", City = "kochi" }
//        };

//        var cityGroups = employees
//            .GroupBy(e => e.City)
//            .Select(g => new
//            {
//                CityName = g.Key,
//                Count = g.Count()
//            });

//        Console.WriteLine("City-wise Employee Count:");
//        foreach (var item in cityGroups)
//        {
//            Console.WriteLine($"{item.CityName}: {item.Count}");
//        }
//    }
//}

//using System;

//public class Person{ 
//    public string Name { get; set; }
//    public int Age { get; set; }

//    class Program {
//        static void Main() {
//           List<Person>per = new List<Person> {
//        new Person{ Name="indran",Age=22},
//        new Person{ Name="gokul",Age=23 },
//        new Person{ Name="ajmal",Age=40 },
//        new Person{ Name="jithin",Age=28 },


//        };

//            var Top3 = per
//                .OrderByDescending(a =>a.Age)
//                .Take(3)
//                .ToList();

//            Console.WriteLine("the are the top three old peoples");
//            foreach (var p in Top3) {
//                Console.WriteLine($"{p.Name} is aged {p.Age}");
//            }
//        }
//    }
//}



public class Person {

    public string Name;
    public int Age;

}
public class Program {

     static void Main() {

        var person = new List<Person> { 
        
        new Person{Name="indran", Age=22},
        new Person{Name="ajay", Age=22},
        new Person{Name="amal", Age=22},
        new Person{Name="indran", Age=22},
        new Person{Name="anas", Age=22},
        };

        var aNames = person
                    .Where(n => n.Name.StartsWith("a"));
        Console.WriteLine("the names start with a is:");
        foreach (var h in aNames)
        {
            Console.WriteLine($"{h.Name} and their age is {h.Age}");
        }



    }

}
