
//delegate
//delegate is type safe(datatype) function(method) pointer

using Csharp_Introduction;

List<Student> studlist = new List<Student>() { 
new Student{ Id = 201, Name = "joy", Level = 200, Salary = 400000 },
new Student{ Id = 202, Name = "Grace", Level = 300, Salary = 450000 },
new Student{ Id = 203, Name = "Shola", Level = 100, Salary = 300000 },
new Student{ Id = 204, Name = "Lola", Level = 400, Salary = 200000 },
new Student{ Id = 205, Name = "Meeday", Level = 500, Salary = 470000 },
new Student{ Id = 206, Name = "Ebuka", Level = 500, Salary = 490000 },
new Student{ Id = 207, Name = "Ada", Level = 400, Salary = 500000 },
};


//List<int> intlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10, 11, 12, 13, 14, 15 };

//                    //anonymous method
//var evenumbers = intlist.FindAll(x => (x % 2) ==0);

//foreach(var e in evenumbers)
//{
//    Console.WriteLine(e);
//}


//var names = studlist.Select(y => y.Name);
var details = studlist.Select(x => new { studsalary = x.Salary, studname = x.Name });
foreach(var student in details)
{
    Console.WriteLine(student.studname);
}


//foreach(var name in names)
//{
//    Console.WriteLine(name);
//}

Console.Read();


