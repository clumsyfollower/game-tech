using System.Text;
using System.Threading.Tasks;
namespace text
{
    struct Student
    {
        public string number;
        public string name;
        public bool isGirl;
        public int score;
        public void Show()
        {
            Console.WriteLine(name + " " + number + " " + (isGirl ? "女" : "男") + " " + score);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int k = 0;
            //while(sum<2000)
            //{
            //    k++;
            //    sum += k * k;
            //}
            //Console.WriteLine(k-1);
            for(int i = 0; i < 100/5; i++)
            {
                for(int j = 0; j <(100-i*5)/3; j++)
                {
                    int remainMoney = 100 - i * 5 - 3 * j;
                    int number = remainMoney * 3;
                    if((i+j+number)==100)
                    {
                        Console.WriteLine(i + " " + j + " " + number);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


