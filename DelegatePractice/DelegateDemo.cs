using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class DelegateDemo
    {
        public delegate void DoIt(int a, int b, out int c);
        public DoIt TheAction;

        public DelegateDemo(DoIt doIt)
        {
            TheAction = doIt;
        }
    }

    class FunctionLibrary
    {
        static public void AddThem(int a, int b, out int c)
        {
            c = a + b;
        }

        static public void SubThem(int a, int b, out int c)
        {
            c = a - b;
        }
    }
}
