//Type casting
//1. implicit casting = converting a smaller type to a larger type
//2. explicit casting = converting a larger type to a smaller type

//implicit casting
using System.Diagnostics;

//int number = 789;

//double doublenumber = number;

//Console.WriteLine(number);
//Console.WriteLine(doublenumber);

////explicit casting

double newvalue = 567.1223;
int intnumber = (int)newvalue;
Console.WriteLine(newvalue);
Console.WriteLine(intnumber);

//type convertion method
int stringvalue = 50;
Console.WriteLine(Convert.ToString(stringvalue));

MyMethod();
MyMthod2();
Console.ReadKey();



static void MyMethod()
{
    Console.WriteLine("Enter your fullname:");

    string fullname = Console.ReadLine();

    Console.WriteLine(" welcome"+ " " + fullname);
}


static void MyMthod2()
{
    Console.WriteLine("Enter your years of experience");

    int experience = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("your years of experience is:" + experience);
}