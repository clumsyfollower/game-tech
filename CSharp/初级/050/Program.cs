// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static int Sum(int[] array)
{
    int sum=0;
    for(int i=0; i<array.Length; i++)
    {
        sum+=array[i];
    }
    return sum;
}
static int Plus(params int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
int sum = Sum(new int[] { 23, 1, 2, 3 });
int sum2 = Plus(23, 3, 4);
Console.WriteLine(sum+" "+sum2);
Console.ReadKey();