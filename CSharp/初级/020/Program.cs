// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//bool var = true;
//if (var==false) 
//    Console.WriteLine("-----");
//Console.WriteLine("if语句后面的语句");
string str=Console.ReadLine();
int score= Convert.ToInt32(str);
//if (score > 50)
//    Console.WriteLine("您输入的分数大于50分");
//if (score <= 50)
//    Console.WriteLine("您输入的分数小于等于50");
if (score > 50)
{
    score++;
    Console.WriteLine("您输入的分数大于50"+score);
}
else
{
    score--;
    Console.WriteLine("您输入的分数小于等于50" + score);
}
Console.ReadKey();

