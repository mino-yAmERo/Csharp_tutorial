// C# Tutorial 
/*
Console.WriteLine("Hello, World!");
Console.WriteLine(3 + 3);
Console.WriteLine("Is It good ?");
Console.Write("Hello World! ");
Console.WriteLine("I will print this on the same line");

string name = "John";
string lastname = "Doe";
Console.WriteLine("Hello "+name+" "+lastname+" !");
*/



// Type Casting 
/*
int myInt = 37;
Console.WriteLine("int : " + myInt);
double myDouble = myInt;
Console.WriteLine("double : " + myDouble);

double doubleNum = 37.28;
Console.WriteLine("double : " + doubleNum);
int intNum = (int)doubleNum;
Console.WriteLine("int : " + intNum);
bool stat = true;

Console.WriteLine(Convert.ToString(myInt));
Console.WriteLine(Convert.ToDouble(myInt));
Console.WriteLine(Convert.ToInt32(myDouble));
Console.WriteLine(Convert.ToString(stat));
*/



// Input 
/*
Console.Write("Enter your name : ");
string userName = Console.ReadLine();
Console.WriteLine("Your name is " + userName);
*/


/*
int x1, x2, y1, y2;
Console.Write("x1 : ");
x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("x2 : ");
x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("y1 : ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("y2 : ");
y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x1 +" > " + x2 + " ? => " +Math.Max(x1, x2));
Console.WriteLine(y1 + " < " + y2 + " ? => " + Math.Min(y1, y2));
*/



// String + Input 
/*
string name;
int length;
Console.Write("Please insert your name : ");
name = Console.ReadLine();

while (true)
{
    Console.Write("How many character of this name ? ");
    length = Convert.ToInt32(Console.ReadLine());
    if (length == name.Length)
    {
        Console.WriteLine("******************************");
        Console.WriteLine("Your answer is correct");
        Console.WriteLine($"Your name is {name} and length is {name.Length} ");
        Console.WriteLine("******************************");
        break;
    }
    else
    {
        Console.WriteLine("Your answer is incorrect, Please try again!");
    }
}
while (true) 
{
    Console.Write("What is the first letter of this name ? ");
    char firstLetter = Convert.ToChar(Console.ReadLine());
    if ( firstLetter == name[0])
    {
        Console.WriteLine("******************************");
        Console.WriteLine("Your answer is correct");
        Console.WriteLine($"The first letter of {name} is {name[0]} ");
        Console.WriteLine("******************************");
        break;
    }
    else
    {
        Console.WriteLine("Your answer is incorrect, Please try again!");
    }
}
*/



// Ternary Operator 
/*
Console.Write("Please insert a number that greater than 5 => ");
int num = Convert.ToInt32(Console.ReadLine());
string result = (num > 5) ? "correct." : "incorrect.";
Console.WriteLine("Your answer is " + result);
*/



// Array
// Foreach (array) + Special Chars (string)
/*
string[] arr = { "Off", "Mino", "yAmERo", "Minor", Convert.ToString(5) };
foreach (string x in arr)
{
    Console.WriteLine(x);
    if (x == "Mino")
    {
        Console.WriteLine("I FOUND \"Mino\"!!");
        break;
    }
}
*/

