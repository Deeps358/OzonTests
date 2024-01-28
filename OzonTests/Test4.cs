using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OzonTests
{
    public class Test4
    {
        public void Solution()
        {
            string rows = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(rows); i++)
            {
                string colWorkers = Console.ReadLine();
                int[] temperature = { 15, 30 };
                for (int j = 0; j < Convert.ToInt32(colWorkers); j++)
                {
                    string neededTemp = Console.ReadLine(); // ввели требуемую температуру (например ">= 30")

                    MatchCollection matchedNums = new Regex(@"\d\d?").Matches(neededTemp);
                    int temp = Convert.ToInt32(matchedNums[0].Value);
                    if (neededTemp.Contains(">") && temp >= temperature[0])
                    {
                        temperature[0] = temp;
                    }
                    if (neededTemp.Contains("<") && temp <= temperature[1])
                    {
                        temperature[1] = temp;
                    }

                    if (temperature[0] <= temperature[1])
                    {
                        Console.WriteLine(new Random().Next(temperature[0], temperature[1]));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
