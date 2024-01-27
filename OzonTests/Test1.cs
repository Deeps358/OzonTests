using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonTests
{
    public class Test1
    {
        public void Solution()
        {
            string rows = Console.ReadLine();
            var ethalon = new Dictionary<string, int>()
            {
                ["1"] = 4,
                ["2"] = 3,
                ["3"] = 2,
                ["4"] = 1
            };
            for (int i = 0; i < Convert.ToInt32(rows); i++)
            {
                bool okay = true;
                string[] input = Console.ReadLine().Split(' ');
                foreach (var number in ethalon)
                {
                    int counter = 0;
                    foreach (string currentNum in input)
                    {
                        if (currentNum == number.Key)
                            counter++;
                    }
                    if (counter != number.Value)
                    {
                        okay = false;
                        break;
                    }
                }
                if (okay)
                    Console.WriteLine("YES\n");
                else
                    Console.WriteLine("NO\n");

            }
        }
    }
}
