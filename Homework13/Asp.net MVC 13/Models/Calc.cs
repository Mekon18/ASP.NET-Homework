using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.net_MVC_13.Models
{
    public class Calc
    {
        public double Arg1 { get; set; }
        public double Arg2 { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }

        public static Calc Create()
        {
            Calc c = new Calc();
            Random rnd = new Random();
            c.Arg1 = rnd.Next(1, 10);
            c.Arg2 = rnd.Next(1, 10);
            switch (rnd.Next(1, 3))
            {
                case 1: c.Operation = "+"; break;
                case 2: c.Operation = "-"; break;
                case 3: c.Operation = "*"; break;
            }
            return c;
        }
        public override string ToString()
        {
            return $"{Arg1} {Operation} {Arg2} = {Result}";
        }
    }
}