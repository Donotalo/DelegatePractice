using System;
using System.Collections.Generic;

namespace DelegatePractice
{
    class Program
    {
        static public void DelegateDemo()
        {
            DelegateDemo dlg = new DelegateDemo(FunctionLibrary.AddAll);
            double result = dlg.TheAction(new List<double> { 1, -1, -3, -5 });
            Console.WriteLine(result);

            dlg.TheAction = FunctionLibrary.Median;
            result = dlg.TheAction(new List<double> { 7, -1, 5, -5 });
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            //DelegateDemo();

            //new EventsDemo1();
            //new EventsDemo2();

            //new LambdaUser();

            //LinqDemo.Demo1();
            //LinqDemo.Demo2();
            //LinqDemo.Demo3();
            //LinqDemo.Demo4();
        }
    }
}
