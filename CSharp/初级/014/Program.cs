// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//string str1 = Console.ReadLine();
//int num1=Convert.ToInt32(str1);
//string str2=Console.ReadLine();
//int num2=Convert.ToInt32(str2);
//string str3=Console.ReadLine();
//int num3 =Convert.ToInt32(str3);
//string str4 = Console.ReadLine();
//int num4=Convert.ToInt32(str4);
//int res = num1 * num2 * num3 * num4;
//Console.WriteLine(res);
string str = Console.ReadLine();
int num=Convert.ToInt32(str);
int ge = num % 10;
int shi=(num / 10) % 10;
int bai = (num / 100) % 10;
Console.WriteLine(ge +""+ shi +""+ bai);
Console.ReadKey();