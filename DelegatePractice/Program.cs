using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Delegate
    {
        public delegate void DoIt(int a, int b, out int c);
        public DoIt TheAction;

        public Delegate(DoIt doIt)
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

    class Program
    {
        static public void DelegateDemo()
        {
            Delegate dlg = new Delegate(FunctionLibrary.AddThem);

            int result;
            dlg.TheAction(35, 37, out result);
            Console.WriteLine(result);

            dlg.TheAction = FunctionLibrary.SubThem;
            dlg.TheAction(35, 37, out result);
            Console.WriteLine(result);
        }

        

        static void Main(string[] args)
        {
            //            DelegateDemo();

            //new EventsDemo();
            new LambdaUser();
        }
    }
}
