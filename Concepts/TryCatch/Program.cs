/*try
{
    Console.WriteLine("Enter x value:");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter y value:");
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine(x / y);
}
catch (FormatException ex)
{
    Console.WriteLine("Input string was not in a correct format.");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Not a valid numbers to perform operation");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Cannot Divide By Zero");
}
catch (Exception e) {
    Console.WriteLine(e.Message);
}



//try catch 

int age = 20;
bool cal(int age) {
    if (age > 20)
    {
        return false;
    }
    else
        return true;
}
try {
    int b = int.Parse(Console.ReadLine());
    bool a = cal(b);
    Console.WriteLine(a);
}
catch (Exception e) {
    Console.WriteLine("age is invalid");
}
*/



static void Main(string[] args)
{
    try
    {
        Method1();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.StackTrace);
    }
}

static void Method1()
{
    try
    {
        Method2();
    }
    catch (Exception ex)
    {
        throw;
    }
}

static void Method2()
{
    string str = null;
    try
    {
        Console.WriteLine(str[0]);
    }
    catch (Exception ex)
    {
        throw;
    }
}