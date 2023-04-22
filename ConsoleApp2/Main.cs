using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Main
    {
        public abstract void Function();
        
    }

    class secondClass : Main
    {
        public override void Function()
        {
            Console.WriteLine("Power Ranger");
        }
    }
}
