using Csharp_Introduction;
using System.Text;

Student[] stud = new Student[3];

stud[0] = new Student();
stud[1] = new Studentinfo();
stud[2] = new StudentList();

foreach(Student stt in stud)
{
    stt.PrintFullName();
}





    
