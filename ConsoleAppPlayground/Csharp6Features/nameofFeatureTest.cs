using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Csharp6Features
{
    static class nameofFeatureTest
    {
        public static void Execute()
        {
            string fileName = "TestFileName.abc";
            Console.WriteLine(nameof(fileName));
        }
    }
}
