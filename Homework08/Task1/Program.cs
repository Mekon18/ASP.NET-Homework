using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var words = text.Split(' ', ',', '.', ';', ':');
            foreach (var word in words)
            {
                if (word != "")
                {
                    var devidedWord = word.DevideWord();
                    text = text.Replace(word, devidedWord);
                }
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
