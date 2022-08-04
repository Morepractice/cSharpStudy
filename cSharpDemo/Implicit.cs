using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    /// <summary>
    /// implicit--用于类型的隐式转换 operator--重写操作符或默有方法 explicit--显示转换
    /// </summary>
    public class A
    {
        public double P { get; set; }

        public A(double p)
        {
            P = p;
        }

        public static implicit operator double(A a)
        {
            return a.P;
        }

        public static explicit operator A(double p)
        {
            return new A(p);
        }
    }
}
