using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    class Printer
    {
        public void iAmPrinting(IRealizable obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }
}
