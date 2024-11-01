//stack&queue
//queue = first-in first-out

using Csharp_Introduction;

Student stud1 = new Student()
{
    Gender = "Male",
    Id = 1,
    Name = "Ben"
};

Student stud2 = new Student()
{
    Gender = "Male",
    Id = 2,
    Name = "Shola"
};

Student stud3 = new Student()
{
    Gender = "Female",
    Id = 3,
    Name = "Joy"
};

Student stud4 = new Student()
{
    Gender = "Female",
    Id = 4,
    Name = "Grace"
};

Student stud5 = new Student()
{
    Gender = "Male",
    Id = 5,
    Name = "Todd"
};


//stack = last-in, first-out 

Stack<Student> stackstud = new Stack<Student>();
stackstud.Push(stud1);
stackstud.Push(stud2);
stackstud.Push(stud3);
stackstud.Push(stud4);
stackstud.Push(stud5);

//Student std = stackstud.Pop();
//Console.WriteLine(std.Name + " - " + std.Gender);
//Console.WriteLine("total item in the queue list = " + stackstud.Count());

//Student std2 = stackstud.Pop();
//Console.WriteLine(std2.Name + " - " + std2.Gender);
//Console.WriteLine("total item in the queue list = " + stackstud.Count());
Student std2 = stackstud.Peek();
Console.WriteLine(std2.Name + " - " + std2.Gender);
Console.WriteLine("total item in the queue list = " + stackstud.Count());




////queue
//Queue<Student> queuestud = new Queue<Student>();
//queuestud.Enqueue(stud1);
//queuestud.Enqueue(stud2);
//queuestud.Enqueue(stud3);
//queuestud.Enqueue(stud4);
//queuestud.Enqueue(stud5);


//Student std = queuestud.Dequeue();
//Console.WriteLine(std.Name + " - " + std.Gender);
//Console.WriteLine("total item in the queue list = " + queuestud.Count());
//Student std2 = queuestud.Dequeue();
//Console.WriteLine(std2.Name + " - " + std2.Gender);
//Console.WriteLine("total item in the queue list = " + queuestud.Count());
//Student std3 = queuestud.Dequeue();
//Console.WriteLine(std3.Name + " - " + std3.Gender);
//Console.WriteLine("total item in the queue list = " + queuestud.Count());
//Student std4 = queuestud.Dequeue();
//Console.WriteLine(std4.Name + " - " + std4.Gender);
//Console.WriteLine("total item in the queue list = " + queuestud.Count());

//foreach(Student studs in queuestud)
//{
//    Console.WriteLine(studs.Name + " - " + studs.Gender);
//    Console.WriteLine("total item in the queue list = " + queuestud.Count());

//}

//Student std4 = queuestud.Peek();
//Console.WriteLine(std4.Name + " - " + std4.Gender);
//Console.WriteLine("total item in the queue list = " + queuestud.Count());