using System.Text;
using System.Threading.Tasks;
namespace text
{
    class Program
    {
        static int MaxValue(params int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        static double MaxValue(params double[] array)
        {
            double maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            int res = MaxValue(23, 22, 4);
            double res2 = MaxValue(23.1, 22.1, 4.1);
            Console.WriteLine(res+" "+res2);
            Console.ReadKey();
        }
    }
}


