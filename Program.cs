using System;
using Delegate;

namespace T
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new A();
            var b = new B();

            a.ShowHandler = Show;
            a.ShowHandler(b.Calc(a.PowHandler, 2, 3).Invoke(2));
            static void Show(bool isVisible)
            {
                Console.WriteLine($"isVisible{isVisible}");
            }
        }
    }
}
