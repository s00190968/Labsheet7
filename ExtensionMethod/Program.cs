using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            string txt = "This a sentence for testing method.";
            Console.WriteLine("Number of words in \"{0}\" is {1}.",txt, txt.wordCount());
        }
        public static int wordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
