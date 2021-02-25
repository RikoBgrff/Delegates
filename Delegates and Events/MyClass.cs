using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{

    class MyClass
    {
        public void Space(string word)
        {
            char[] cArray = word.ToCharArray();
            string resultString = String.Join("_", cArray);
            Console.WriteLine($"Spaced:{resultString}");
        }
        public void Reverse(string word)
        {
            char[] cArray = word.ToCharArray();
            Array.Reverse(cArray);
            Console.Write("Reversed:"); Console.WriteLine(cArray);
        }
    }
}
