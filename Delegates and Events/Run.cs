using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    public delegate void Func(string str);

    class Run
    {
        MyClass obj = new MyClass();
        public void RunFunc()
        {
            Console.Write("Enter Word:"); string word = Console.ReadLine();
            Func func = obj.Space;
            func += obj.Reverse;
            func.Invoke(word);
        }
    }
}
