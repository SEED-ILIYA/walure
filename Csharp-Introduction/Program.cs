//Generics
using Csharp_Introduction;

Student.Studentdetails("cup","jug");

Student.StudentCourse<int>(5,6);
Student.StudentCourse<double>(5.89, 666.7);
Student.StudentCourse<string>("alter", "ego");

Calculate<int> calculate = new Calculate<int>();
calculate.Add(3);
calculate.Add(5);
calculate.Add(6);
calculate.Add(9);
calculate.Add(4);



var result = calculate.values;
foreach(var value in result)
    Console.WriteLine(value);