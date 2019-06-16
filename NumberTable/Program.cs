using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "数  表";
            Console.WriteLine();
            Console.WriteLine("　数　　二乗　　　三乗　　　四乗　　　平方根");
            Console.WriteLine(" ----　-------　--------　--------　-----------　");
            for(int a = 0; a <= 10; a++)
            {
                string row = String.Format("{0,2}　　{1,5}　　　{2,5}　　{3,5}　　　　{4:F4}", a, Calc.Power(a, 2), Calc.Power(a, 3), Calc.Power(a, 4), Calc.Sqrt(a));
                Console.WriteLine(row);
            }
            Console.WriteLine();
            Console.WriteLine("終了するには、何かキーを押してください。");
            Console.ReadLine();
        }
    }
}
