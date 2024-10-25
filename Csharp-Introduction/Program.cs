
//delegate
//delegate is type safe(datatype) function(method) pointer

using Csharp_Introduction;

List<Student> studlist = new List<Student>();
studlist.Add(new Student() { Id = 201, Name = "joy", Level = 200, Salary = 400000 });
studlist.Add(new Student() { Id = 202, Name = "Grace", Level = 300, Salary = 450000 });
studlist.Add(new Student() { Id = 203, Name = "Shola", Level = 100, Salary = 300000 });
studlist.Add(new Student() { Id = 204, Name = "Lola", Level = 400, Salary = 200000 });
studlist.Add(new Student() { Id = 205, Name = "Meeday", Level = 500, Salary = 470000 });
studlist.Add(new Student() { Id = 206, Name = "Ebuka", Level = 500, Salary = 490000 });
studlist.Add(new Student() { Id = 207, Name = "Ada", Level = 400, Salary = 500000 });
                                //anonymous method
Student.StudentStatus(studlist, x => x.Level >= 300);
Student.StudentStatus(studlist, x => x.Level == 400);

var totalsalary = studlist.Sum(x => x.Salary);
Console.WriteLine("Totalsalary = " + totalsalary);



static bool checkstudlevel(Student student)
{
   if(student.Level == 200)
    {
        return true;
    }
   else
    {
        return false;
    }

}



static bool studlevelcheck(Student student)
{
    if (student.Level == 300)
    {
        return true;
    }
    else
    {
        return false;
    }

}


