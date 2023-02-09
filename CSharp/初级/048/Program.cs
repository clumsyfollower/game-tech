// See https://aka.ms/new-console-template for more information

static void Write()
{
    Console.WriteLine("Hello, World!");
    return;
}

static int Plus(int num1, int num2)
{
    int sum=num1 + num2;
    return sum;
}

Write();
int num1 = 45;
int num2 = 90;
int res = Plus(num1, num2);
int res1 = Plus(45, 23);
Console.WriteLine(res+","+res1);
Console.ReadKey();
