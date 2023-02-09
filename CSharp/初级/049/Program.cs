// See https://aka.ms/new-console-template for more information

static int[] GetDivisor(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        if(number%i==0)
        {
            count++;
        }
    }
    int[] array = new int[count];
    int index = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            array[index]=i;
            index++;
        }
    }
    return array;
}

static int Max(int[] array)
{
    int max=array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        { 
            max=array[i];
        }
    }
    return max;
}

Console.WriteLine("Hello, World!");
//int num = Convert.ToInt32(Console.ReadLine());
//int[] array=GetDivisor(num);
//foreach(int temp in array)
//{
//    Console.WriteLine(temp+" ");
//}
int[] array = { 2, 5, 3, 1, 0 };
Console.WriteLine(Max(array));
Console.ReadKey();