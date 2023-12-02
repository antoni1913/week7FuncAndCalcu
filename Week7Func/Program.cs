string hello = "Hello world!";
string panic = "dont panic!";



PrintStringFiveTime(panic);

static void PrintStringFiveTime(string someString)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(someString);
    }
}