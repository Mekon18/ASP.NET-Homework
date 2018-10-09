using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(Factorial(Console.ReadLine()));
            Console.ReadKey();
        }
        static long Factorial(long n)
        {
            if (n > 1)
                return Factorial(n - 1) * n;
            else
                return 1;
        }
        static string Factorial(string str)
        {
            string str2 = str;
            if (int.Parse(str) > 1)
            {
                str2 = StringMinusOne(str2);
                return MultiplyStr(str, Factorial(str2));
            }
            else
            {
                return "1";
            }
        }

        static string MultiplyStr(string str1, string str2)
        {
            int b;
            string result = "0";
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                b = int.Parse(str2[i].ToString());
                string c = MultiplyStringAndNumber(str1, b);
                for (int j = 0; j < str2.Length - i - 1; j++)
                {
                    c = c.Insert(c.Length, "0");
                }
                result = SumStrings(result, c);
            }
            return result;
        }

        static string MultiplyStringAndNumber(string str1, int b)
        {
            int a;
            int n;
            string result = "";
            int nbuf = 0;
            for (int j = str1.Length - 1; j >= 0; j--)
            {
                a = int.Parse(str1[j].ToString());
                n = a * b;
                n = n + nbuf;
                result = result.Insert(0, (n % 10).ToString());
                nbuf = n / 10;
            }
            if (nbuf > 0)
                result = result.Insert(0, nbuf.ToString());
            return result;
        }

        static string SumStrings(string str1, string str2)
        {
            int a;
            int b;
            int n;
            string result = "";
            int nbuf = 0;
            if (str1.Length < str2.Length)
            {
                string buf = str1;
                str1 = str2;
                str2 = buf;
            }
            while (str1.Length != str2.Length)
            {
                str2 = str2.Insert(0, "0");
            }
            result = str2;
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                b = int.Parse(str2[i].ToString());
                a = int.Parse(str1[i].ToString());
                n = a + b;
                n = n + nbuf;
                result = result.Remove(i, 1);
                result = result.Insert(i, (n % 10).ToString());
                nbuf = n / 10;
            }
            if (nbuf > 0)
                result = result.Insert(0, nbuf.ToString());
            return result;
        }

        static string StringMinusOne(string str)
        {
            int n = int.Parse(str[str.Length - 1].ToString());
            str = str.Remove(str.Length - 1, 1);
            if (n == 0)
            {
                str = StringMinusOne(str);
                if (str == "0")
                    str = str.Remove(0);
                str = str.Insert(str.Length, "9");
            }
            else
            {
                str = str.Insert(str.Length, (n - 1).ToString());
            }
            return str;
        }
    }
}
