using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OzonTests
{
    public class Test3
    {
        public void Solution()
        {
            string rows = Console.ReadLine();

            var examples = new List<string> { @"^\D\d{2}\D{2}", @"^\D\d\D{2}" }; // буква−цифра−цифра−буква−буква, буква−цифра−буква−буква
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Convert.ToInt32(rows); i++)
            {
                sb.Clear();
                string inputData = Console.ReadLine();

                if (inputData.Length < 4)
                {
                    Console.WriteLine("-");
                    continue;
                }
                bool checker = true;

                while (checker)
                {
                    checker = false;
                    foreach (string exam in examples)
                    {
                        MatchCollection matchedAuthors = new Regex(exam).Matches(inputData);
                        if (matchedAuthors.Count == 0)
                            continue;
                        else
                        {
                            checker = true;
                            sb.Append(matchedAuthors[0].Value + " ");
                            inputData = inputData.Remove(0, matchedAuthors[0].Value.Length);
                        }
                    }
                }
                if (inputData.Length == 0)
                    Console.WriteLine(sb.ToString());
                else
                    Console.WriteLine("-");
            }
        }
    }
}
