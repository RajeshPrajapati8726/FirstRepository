using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class Class1
    {
        public  void PassingDelegateAsAArgs(displayDelegate del)
        {
            del("Hello");
        }
    }
}
