using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    public class Calc
    {
        /// <summary>
        /// 整数 a + b の結果を返します。
        /// </summary>
        /// <returns></returns>
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 整数 a - b の結果を返します。
        /// </summary>
        /// <returns></returns>
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// 整数 a * b の結果を返します。
        /// </summary>
        /// <returns></returns>
        public static long Multiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// 整数 a ÷ b の結果を返します。
        /// </summary>
        /// <returns></returns>
        public static double Division(int a, int b, int digit)
        {
            try
            {
                return System.Math.Round((double)a / b, digit);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// a の b乗の結果を返します。
        /// </summary>
        /// <returns></returns>
        public static double Power(double a, double b)
        {
            try
            {
                return System.Math.Pow(a, b);
            }
            catch
            {
                throw;
            }

        }
        
        /// <summary>
        /// aの平方根を返します。
        /// </summary>
        public static double Sqrt(double a)
        {
            try
            {
                return System.Math.Sqrt(a);
            }
            catch
            {
                throw;
            }
        }

    }
}
