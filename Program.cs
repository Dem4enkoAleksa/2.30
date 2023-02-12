using System;
using System.Linq;

namespace задание_2._30
{
    class Program
    {
        private static void Main(string[] args)
        {
            int g = 465;
            var h = g.ToString().ToList();
            char ch2 = h[1];
            h.Remove(ch2);
            h.Add(ch2);
            string resultStr = String.Join("", h);
            int resultInt = int.Parse(resultStr);
            Console.WriteLine(resultInt);

        }
    }
}