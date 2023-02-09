using System.Text;
using System.Threading.Tasks;
namespace text
{
    class Program
    {
        static int Factorial(int n)
        {
            int res = 1;
            for(int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
        static void Main(string[] args)
        {
            //float height = 100;
            //float distance = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    distance += height;
            //    height /= 2;
            //}
            //Console.WriteLine(distance+" "+height);
            int sum = 0;
            for (int i = 0; i <=20; i++)
            {
                sum+=Factorial(i);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}


