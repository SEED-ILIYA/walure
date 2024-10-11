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


//for
    //initializer, condition, iterator
//for(int i = 0; i<10; i++)
//{
//    Console.WriteLine(i);
//}

int[] number = { 5, 6, 7, 8, 9, 0, 10, 2, 3, 3, 4, 4 };
string[] Words = { "chalk", "board", "pen", "bin", "gate" };
//foreach
foreach(string x in Words)
{
    Console.WriteLine(x);
}

//while
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

//do while
int y = 0;
do
{
    Console.WriteLine(y);
    y+=2;
}while(y<10);
