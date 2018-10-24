using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Data
    {
        public Data(DateTime dt, double temp)
        {
            Time = dt;
            Temperature = temp;
        }

        public DateTime Time { get; }
        public double Temperature { get; }
    }

    class LinqDemo
    {
        static private Random random = new Random();

        static private List<Data> GetRandomDataList(int length = 20)
        {
            List<Data> data_list = new List<Data>();

            DateTime start_time = DateTime.Now.Subtract(new TimeSpan(72, 0, 0));
            for (int i = 0; i < length; i++)
            {
                double temp = 25 + random.NextDouble() * 5;
                DateTime time = start_time.Add(new TimeSpan(0, i * 5, 0));
                data_list.Add(new Data(time, temp));
            }

            return data_list;
        }

        static public void Demo1()
        {
            List<Data> data_list = GetRandomDataList();

            IEnumerable<Data> datas =
                data_list.Where((d) => { return d.Temperature >= 27; });
            Console.WriteLine($"{datas.Count()} temperatures are >= 27");
            foreach(var d in datas)
            {
                Console.Write($"{d.Temperature.ToString("0.0")} ");
            }
            Console.Write("\n\n");

            IEnumerable<Data> datas2 =
                data_list.Where(d => d.Temperature < 27);
            Console.WriteLine($"{datas2.Count()} temperatures are < 27");
            foreach (var d in datas2)
            {
                Console.Write($"{d.Temperature.ToString("0.0")} ");
            }
            Console.Write("\n");
        }

        static public void Demo2()
        {
            List<Data> data_list = GetRandomDataList();

            Action<IEnumerable<Data>, string> display =
                (IEnumerable<Data> list, string condition) =>
                {
                    Console.WriteLine($"{list.Count()} temperatures are {condition}");
                    foreach (var d in list)
                    {
                        Console.Write($"{d.Temperature.ToString("0.0")} ");
                    }
                    Console.Write("\n\n");
                };

            display(data_list.Where(d => d.Temperature >= 27), ">= 27");
            display(data_list.Where(d => d.Temperature < 27), "< 27");
        }

        static public void Demo3()
        {
            List<Data> data_list = GetRandomDataList();

            foreach(var t in data_list.Select(d => d.Temperature))
            {
                Console.Write($"{t.ToString("0.0")} ");
            }
            Console.WriteLine("");

            var first = data_list.FirstOrDefault();
            Console.WriteLine($"First element: {first.Temperature.ToString("0.0")} @ {first.Time}");
        }

        static public void Demo4()
        {
            List<Data> data_list = GetRandomDataList(50);

            foreach (var t in data_list.Where(d => Math.Abs(d.Temperature - 27.5) < 0.5).Select(d => d.Temperature))
            {
                Console.Write($"{t.ToString("0.0000")}\t");
            }
            Console.WriteLine("");

            var single = data_list.SingleOrDefault(d => Math.Floor(d.Temperature * 10) == 275);
            if (single == null)
            {
                Console.WriteLine("Single element is not found");
            }
            else
            {
                Console.WriteLine($"Single element: {single.Temperature.ToString("0.0")} @ {single.Time}");
            }
        }
    }
}
