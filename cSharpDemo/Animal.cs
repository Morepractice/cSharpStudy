using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    internal class Animal
    {
        static Animal()
        {
            Console.WriteLine("Animal initialized");
        }

        public Animal()
        {
            Console.WriteLine("Yawn");
        }

        ~Animal()
        {
            Console.WriteLine("animal finalized");
        }
    }
}
