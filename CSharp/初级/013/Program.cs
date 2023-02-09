// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int hp;
//float x, y, z;
//float speed = 12;
string str1 = Console.ReadLine();
int num1=Convert.ToInt32(str1);
string str2=Console.ReadLine();
int num2=Convert.ToInt32(str2);
int temp = num1;
num1 = num2;
num2 = temp;
Console.WriteLine(num1 + ":" + num2);
Console.ReadKey();