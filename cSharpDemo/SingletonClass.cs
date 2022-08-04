using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    internal class SingletonClass
    {
        public static Animal Animal { get; } = new ();

        private SingletonClass()
        {

        }
    }
}
