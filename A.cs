using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class A
    {
        public A()
        {
            PowHandler = Pow;
        }

        public Action<bool> ShowHandler { get; set; }
        public Func<int, int, int> PowHandler { get; }
        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
