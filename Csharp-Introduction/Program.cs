//statement
//conditional statement
//conditional looping

//conditional statement 
//if/else
//switch case


//conditional looping
//for
//foreach
//while
//dowhile


//if/else
int v = 45;
int x = 45;
int r = 2;
int g = 5;

if(x == v || r > 5)
{
    Console.WriteLine("you won");
}
else if (x < v && r ==5)
{
    Console.WriteLine("almost there please try again");
}
else
{
    Console.WriteLine("you loose");
}

Console.WriteLine("pick your lucky number from 1-7");
int month = int.Parse(Console.ReadLine());

switch (month)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
        default:
        Console.WriteLine("the value does not exist");
        break;
}