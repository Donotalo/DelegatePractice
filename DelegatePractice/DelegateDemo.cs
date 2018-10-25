using System.Collections.Generic;

namespace DelegatePractice
{
    class DelegateDemo
    {
        public delegate double DoIt(List<double> data);
        public DoIt TheAction;

        public DelegateDemo(DoIt doIt)
        {
            TheAction = doIt;
        }
    }

    class FunctionLibrary
    {
        static public double AddAll(List<double> data)
        {
            double ans = 0;
            foreach (var x in data) ans += x;
            return ans;
        }

        static public double Median(List<double> data)
        {
            data.Sort();

            if (data.Count % 2 == 1)
            {
                return data[data.Count / 2];
            }

            return (data[data.Count / 2] + data[(data.Count / 2) - 1]) / 2;
        }
    }
}
