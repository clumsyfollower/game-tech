// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("您考了多少分？");
string str=Console.ReadLine();
int score=Convert.ToInt32(str);
if(score>=90)
{
    Console.WriteLine("优秀");
}else if(score>=80&&score<=89)
{
    Console.WriteLine("良");
}else if(score>=60 &&score<=79)
{
    Console.WriteLine("中");
}else
{
    Console.WriteLine("继续努力");
}
Console.ReadKey();