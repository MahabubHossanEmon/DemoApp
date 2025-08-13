using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public interface IPrinter
    {
        void Print(Ishape circle);
    }

    public class Printer : IPrinter
    {
        public void Print(Ishape circle)
        {
            Console.WriteLine(circle);
        }
    }
}
