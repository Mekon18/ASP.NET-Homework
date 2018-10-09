using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class BigInt
    {
        public string Value;

        public BigInt(string num)
        {
            Value = num;
        }
        public BigInt(int num)
        {
            Value = num.ToString();
        }
        public BigInt(long num)
        {
            Value = num.ToString();
        }
        public BigInt(byte num)
        {
            Value = num.ToString();
        }

        public static BigInt operator +(BigInt b1, BigInt b2)
        {
            string str1 = b1.Value;
            string str2 = b2.Value;
            bool Minus = false;

            int countOfMinuses = 0;
            if (b1.Value[0] == '-')
            {
                countOfMinuses++;
                str1 = str1.Remove(0, 1);
            }
            if (b2.Value[0] == '-')
            {
                countOfMinuses++;
                str2 = str2.Remove(0, 1);
            }
            int a;
            int b;
            int n;
            string result = "";
            int nbuf = 0;
            if (b1.Abc() < b2.Abc())
            {
                var buf = str1;
                str1 = str2;
                str2 = buf;
                if (b1 > b2)
                {
                    Minus = true;
                }
            }
            else
            {
                if (b1 < b2)
                {
                    Minus = true;
                }
            }

            while (str1.Length != str2.Length)
            {
                if (str1.Length > str2.Length)
                {
                    str2 = str2.Insert(0, "0");
                }
                else
                {
                    str1 = str1.Insert(0, "0");
                }
            }
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                a = int.Parse(str1[i].ToString());
                b = int.Parse(str2[i].ToString());
                if (countOfMinuses == 1)
                {
                    n = a - b;
                    n = n - nbuf;
                    nbuf = 0;
                    if (n < 0)
                    {
                        nbuf = 1;
                        n += 10;
                    }
                }
                else
                {
                    n = a + b;
                    n = n + nbuf;
                    nbuf = n / 10;
                }
                result = result.Insert(0, (n % 10).ToString());
            }
            if (nbuf > 0)
                result = result.Insert(0, nbuf.ToString());
            if (countOfMinuses == 2)
            {
                result = result.Insert(0, "-");
            }
            else
            {
                if (Minus)
                {
                    result = result.Insert(0, "-");
                }
            }

            return new BigInt(result);
        }
        public static BigInt operator +(BigInt b, string str)
        {
            BigInt b2 = new BigInt(str);
            return b + b2;
        }
        public static BigInt operator +(string str, BigInt b)
        {
            BigInt b2 = new BigInt(str);
            return b + b2;
        }
        public static BigInt operator +(BigInt b, long num)
        {
            return b + new BigInt(num.ToString());
        }
        public static BigInt operator +(long num, BigInt b)
        {
            return new BigInt(num.ToString()) + b;
        }
        public static BigInt operator +(BigInt b, int num)
        {
            return b + new BigInt(num.ToString());
        }
        public static BigInt operator +(int num, BigInt b)
        {
            return new BigInt(num.ToString()) + b;
        }
        public static BigInt operator +(BigInt b, byte num)
        {
            return b + new BigInt(num.ToString());
        }
        public static BigInt operator +(byte num, BigInt b)
        {
            return new BigInt(num.ToString()) + b;
        }

        public static BigInt operator *(BigInt b1, BigInt b2)
        {
            string str1 = b1.Value;
            string str2 = b2.Value;
            BigInt result = new BigInt("0");
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                string c = (new BigInt(str1) * str2[i]).Value;
                for (int j = 0; j < str2.Length - i - 1; j++)
                {
                    c = c.Insert(c.Length, "0");
                }
                result = result + c;
            }
            return result;
        }
        public static BigInt operator *(string str, BigInt b)
        {
            BigInt b2 = new BigInt(str);
            return b * b2;
        }
        public static BigInt operator *(BigInt b, string str)
        {
            BigInt b2 = new BigInt(str);
            return b * b2;
        }
        public static BigInt operator *(BigInt b, long num)
        {
            return b * new BigInt(num.ToString());
        }
        public static BigInt operator *(long num, BigInt b)
        {
            return new BigInt(num.ToString()) * b;
        }
        public static BigInt operator *(BigInt b, int num)
        {
            return b * new BigInt(num.ToString());
        }
        public static BigInt operator *(int num, BigInt b)
        {
            return new BigInt(num.ToString()) * b;
        }
        public static BigInt operator *(BigInt b, byte num)
        {
            return b * new BigInt(num.ToString());
        }
        public static BigInt operator *(byte num, BigInt b)
        {
            return new BigInt(num.ToString()) * b;
        }
        public static BigInt operator *(BigInt b, char ch)
        {
            string str1 = b.Value;
            int a;
            int n;
            string result = "";
            int nbuf = 0;
            for (int j = str1.Length - 1; j >= 0; j--)
            {
                a = int.Parse(str1[j].ToString());
                n = a * int.Parse(ch.ToString());
                n = n + nbuf;
                result = result.Insert(0, (n % 10).ToString());
                nbuf = n / 10;
            }
            if (nbuf > 0)
                result = result.Insert(0, nbuf.ToString());
            return new BigInt(result);
        }

        public static BigInt operator -(BigInt b1, BigInt b2)
        {
            return b1 + -b2;
        }
        public static BigInt operator -(BigInt b, int num)
        {
            return b - new BigInt(num.ToString());
        }
        public static BigInt operator -(int num, BigInt b)
        {
            return new BigInt(num.ToString()) - b;
        }
        public static BigInt operator -(BigInt b, long num)
        {
            return b - new BigInt(num.ToString());
        }
        public static BigInt operator -(long num, BigInt b)
        {
            return new BigInt(num.ToString()) - b;
        }
        public static BigInt operator -(BigInt b, byte num)
        {
            return b - new BigInt(num.ToString());
        }
        public static BigInt operator -(byte num, BigInt b)
        {
            return new BigInt(num.ToString()) - b;
        }
        public static BigInt operator -(BigInt b, string str)
        {
            return b - new BigInt(str);
        }
        public static BigInt operator -(string str, BigInt b)
        {
            return new BigInt(str) - b;
        }
        public static BigInt operator -(BigInt b)
        {
            string result = b.Value;
            result = result.Insert(0, "-");
            return new BigInt(result);
        }

        public static bool operator >(BigInt b1, BigInt b2)
        {
            string str1 = b1.Value;
            string str2 = b2.Value;
            bool b1HadMinus = false;
            bool b2HadMinus = false;

            if (b1.Value[0] == '-')
            {
                str1 = str1.Remove(0, 1);
                b1HadMinus = true;
            }
            if (b2.Value[0] == '-')
            {
                str2 = str2.Remove(0, 1);
                b2HadMinus = true;
            }

            if (!b1HadMinus && b2HadMinus)
            {
                return true;
            }
            if ((b1HadMinus && b2HadMinus) || (!b1HadMinus && !b2HadMinus))
            {
                while (str1.Length != str2.Length)
                {
                    if (str1.Length > str2.Length)
                    {
                        str2 = str2.Insert(0, "0");
                    }
                    else
                    {
                        str1 = str1.Insert(0, "0");
                    }
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    if (!b1HadMinus && !b2HadMinus)
                    {

                        if (str1[i] > str2[i])
                        {
                            return true;
                        }
                        if (str1[i] < str2[i])
                        {
                            return false;
                        }
                    }
                    if (b1HadMinus && b2HadMinus)
                    {
                        if (str1[i] < str2[i])
                        {
                            return true;
                        }
                        if (str1[i] > str2[i])
                        {
                            return false;
                        }
                    }
                }
            }


            return false;
        }
        public static bool operator <(BigInt b1, BigInt b2)
        {
            string str1 = b1.Value;
            string str2 = b2.Value;
            bool b1HadMinus = false;
            bool b2HadMinus = false;

            if (b1.Value[0] == '-')
            {
                str1 = str1.Remove(0, 1);
                b1HadMinus = true;
            }
            if (b2.Value[0] == '-')
            {
                str2 = str2.Remove(0, 1);
                b2HadMinus = true;
            }

            if (b1HadMinus && !b2HadMinus)
            {
                return true;
            }
            if ((b1HadMinus && b2HadMinus) || (!b1HadMinus && !b2HadMinus))
            {
                while (str1.Length != str2.Length)
                {
                    if (str1.Length > str2.Length)
                    {
                        str2 = str2.Insert(0, "0");
                    }
                    else
                    {
                        str1 = str1.Insert(0, "0");
                    }
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    if (!b1HadMinus && !b2HadMinus)
                    {

                        if (str1[i] < str2[i])
                        {
                            return true;
                        }
                        if (str1[i] > str2[i])
                        {
                            return false;
                        }
                    }
                    if (b1HadMinus && b2HadMinus)
                    {
                        if (str1[i] > str2[i])
                        {
                            return true;
                        }
                        if (str1[i] < str2[i])
                        {
                            return false;
                        }
                    }
                }
            }


            return false;
        }

        public static bool operator >=(BigInt b1, BigInt b2)
        {
            string str1 = b1.Value;
            string str2 = b2.Value;
            bool b1HadMinus = false;
            bool b2HadMinus = false;

            if (b1.Value[0] == '-')
            {
                str1 = str1.Remove(0, 1);
                b1HadMinus = true;
            }
            if (b2.Value[0] == '-')
            {
                str2 = str2.Remove(0, 1);
                b2HadMinus = true;
            }

            if (!b1HadMinus && b2HadMinus)
            {
                return true;
            }
            if ((b1HadMinus && b2HadMinus) || (!b1HadMinus && !b2HadMinus))
            {
                while (str1.Length != str2.Length)
                {
                    if (str1.Length > str2.Length)
                    {
                        str2 = str2.Insert(0, "0");
                    }
                    else
                    {
                        str1 = str1.Insert(0, "0");
                    }
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    if (!b1HadMinus && !b2HadMinus)
                    {

                        if (str1[i] >= str2[i])
                        {
                            return true;
                        }
                        if (str1[i] < str2[i])
                        {
                            return false;
                        }
                    }
                    if (b1HadMinus && b2HadMinus)
                    {
                        if (str1[i] <= str2[i])
                        {
                            return true;
                        }
                        if (str1[i] > str2[i])
                        {
                            return false;
                        }
                    }
                }
            }


            return false;
        }
        public static bool operator <=(BigInt b1, BigInt b2)
        {
            string str1 = b1.Value;
            string str2 = b2.Value;
            bool b1HadMinus = false;
            bool b2HadMinus = false;

            if (b1.Value[0] == '-')
            {
                str1 = str1.Remove(0, 1);
                b1HadMinus = true;
            }
            if (b2.Value[0] == '-')
            {
                str2 = str2.Remove(0, 1);
                b2HadMinus = true;
            }

            if (b1HadMinus && !b2HadMinus)
            {
                return true;
            }
            if ((b1HadMinus && b2HadMinus) || (!b1HadMinus && !b2HadMinus))
            {
                while (str1.Length != str2.Length)
                {
                    if (str1.Length > str2.Length)
                    {
                        str2 = str2.Insert(0, "0");
                    }
                    else
                    {
                        str1 = str1.Insert(0, "0");
                    }
                }
                for (int i = 0; i < str1.Length; i++)
                {
                    if (!b1HadMinus && !b2HadMinus)
                    {

                        if (str1[i] <= str2[i])
                        {
                            return true;
                        }
                        if (str1[i] > str2[i])
                        {
                            return false;
                        }
                    }
                    if (b1HadMinus && b2HadMinus)
                    {
                        if (str1[i] >= str2[i])
                        {
                            return true;
                        }
                        if (str1[i] < str2[i])
                        {
                            return false;
                        }
                    }
                }
            }


            return false;
        }

        public override string ToString()
        {
            return Value;
        }

        public BigInt Abc()
        {
            string result = this.Value;
            if (result[0] == '-')
                result = result.Remove(0, 1);
            return new BigInt(result);
        }
    }
}
