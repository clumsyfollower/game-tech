// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//当在字符串前面加上一个@字符的时候，我们就可以把一个字符串定义在多行
//编译器不会再去识别字符串中的转义字符
//如果需要在字符串中表示一个引号的话需要使用两个双引号
string str1 = @"i am a good man
you are bad girl";//使用两个引号表示一个引号
Console.WriteLine(str1);
//使用@字符的第二个好处
string path = "c:\\xxx\\xx\\xxx.doc";
string path2 = @"c:\xxx\xx\xxx.doc";
Console.WriteLine(path);
Console.WriteLine(path2);
Console.ReadKey();