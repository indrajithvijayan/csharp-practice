//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace revision
//{
//    internal class LINQ
//    {
//        class Student
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }
//            public int Age { get; set; }
//            public string Dept { get; set; }
//            public int Marks { get; set; }
//        }

//        class program
//        {
//            static void Main() 
//            {

//                List<Student> students = new List<Student>()
//                {
//            new Student{ Id=1, Name="Arun", Age=21, Dept="CS", Marks=85 },
//            new Student{ Id=2, Name="Maya", Age=22, Dept="IT", Marks=92 },
//            new Student{ Id=3, Name="Ravi", Age=20, Dept="CS", Marks=70 },
//            new Student{ Id=4, Name="Nila", Age=23, Dept="EC", Marks=88 },
//            new Student{ Id=5, Name="Kiran", Age=21, Dept="IT", Marks=60 }


//                };
//                var secondlargest = students
//                        .OrderDescending(s => s.Marks)
//                        .Skip(1)
//                        .First();

//            }
//        }
//    }
//}
//return students whose marks are greater than the average marks of their own department

//class Student { 
// public int Id { get; set; }
// public string Name { get; set; }
// public int Age{ get; set; }
// public string Dept { get; set; }
//  public int Marks { get; set; }

//}
//class program
//{
//    static void Main()
//    {
//        List<Student> student = new List<Student>()
//        {
//            new Student{ Id=1, Name="siyad",Age=24,Dept="cs",Marks =88},
//            new Student{ Id=2, Name="indran",Age=24,Dept="it",Marks =98},
//            new Student{ Id=3, Name="siyad",Age=24,Dept="it",Marks =68},
//            new Student{ Id=4, Name="siyad",Age=24,Dept="ec",Marks =70},
//            new Student{ Id=5, Name="siyad",Age=24,Dept="cs",Marks =85},
//        };

//        var result = student
//            .GroupBy(s => s.Dept)
//            .SelectMany(g =>
//              g.Where(s => s.Marks >= g.Average(x => x.Marks))
//            );
//        foreach (var s in result)
//        {
//            Console.WriteLine($"{s.Name} from {s.Dept} scored {s.Marks}");
//        }
//    }
//}