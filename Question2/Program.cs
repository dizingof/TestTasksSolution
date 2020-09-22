using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringsOne = new[] { "aaa", "bbb", "ccc" };
            var sb = new StringBuilder();
            stringsOne.Select(p => p).ToList().ForEach(q => sb.Append(q + " "));
            Console.WriteLine(sb);
            Console.ReadKey();

        }
    }
}
