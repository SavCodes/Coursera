using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Disobedient : Kid
    {
        override public void PrintMessage()
        {
            Console.WriteLine("This is a disobedient child class method");
        }
    }
}
