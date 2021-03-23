using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class B
    {
        private int _r;
        public Action PowHandler { get; set; }
        public Predicate<int> Calc(Func<int, int, int> func, int i, int j)
        {
            _r = func(i, j);
            Predicate<int> predic = IsDivisible;
            return predic;
        }

        public bool Result(int i)
        {
            A a = new A();
            a.Pow(3, 5);
            return true;
        }

        public bool IsDivisible(int i)
        {
            if (_r % i == 0)
            {
                return true;
            }

            return false;
        }
    }
}
