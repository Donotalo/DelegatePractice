using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Program
    {
        static public void DelegateDemo()
        {
            DelegateDemo dlg = new DelegateDemo(FunctionLibrary.AddThem);
            dlg.TheAction(35, 37, out int result);
            Console.WriteLine(result);

            dlg.TheAction = FunctionLibrary.SubThem;
            dlg.TheAction(35, 37, out result);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            //DelegateDemo();

            //new EventsDemo1();
            //new EventsDemo2();

            //new LambdaUser();

            //LinqDemo.LinqDemoV1();
            //LinqDemo.DemoV2();
            //LinqDemo.Demo3();
            //LinqDemo.Demo4();
        }
    }
}
