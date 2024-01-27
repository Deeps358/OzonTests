using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonTests
{
    public class Test2
    {
        public void Solution()
        {
            string rows = Console.ReadLine();
            var months = new Dictionary<string, int>()
            {
                ["1"] = 31, // январь
                ["2"] = 28, // февраль
                ["3"] = 31, // март
                ["4"] = 30, // апрель
                ["5"] = 31, // май
                ["6"] = 30, // июнь
                ["7"] = 31, // июль
                ["8"] = 31, // август
                ["9"] = 30, // сентябрь
                ["10"] = 31, // октябрь
                ["11"] = 30, // ноябрь
                ["12"] = 31 // декабрь
            };
            for (int i = 0; i < Convert.ToInt32(rows); i++)
            {
                bool visgod = false;
                string[] inputData = Console.ReadLine().Split(' ');
                if (inputData[1] == "2")
                {
                    int year = Convert.ToInt32(inputData[2]);
                    if (year % 4 == 0 && year % 100 != 0) // високосный
                        visgod = true;
                    if (year % 400 == 0) // високосный
                        visgod = true;
                }
                if (inputData[1] == "2" && inputData[0] == "29" && visgod)
                {
                    Console.WriteLine("YES\n");
                    continue;
                }
                if (Convert.ToInt32(inputData[0]) <= months[inputData[1]])
                {
                    Console.WriteLine("YES\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("NO\n");
                }
            }
        }
    }
}
