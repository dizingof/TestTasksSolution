using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = CreateString("ObjectName", "Value");
           Console.WriteLine(result);
           Console.ReadKey();
        }

        public static string CreateString(object x, object  y)
        {
            var stringResult = string.Format(" \"{0}\":\"{1}\" ", x, y );
            return stringResult;
        }
    }
}
