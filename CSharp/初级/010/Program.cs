// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("请输入第一个数字");
string str1=Console.ReadLine();
int num1=Convert.ToInt32(str1);
Console.WriteLine("请输入第一个数字");
string str2 =Console.ReadLine();
int num2=Convert.ToInt32(str2);
int sum = num1 + num2;
Console.WriteLine("您输入的两个数字的和为");
Console.WriteLine(sum);
Console.ReadKey();