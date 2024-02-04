using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonTests
{
    internal class Test5
    {
        public void Solution()
        {
            string rows = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(rows); i++)
            {
                string inputLength = Console.ReadLine();
                string finalOutput = string.Empty; // то, что выведется в конце
                string[] input = Console.ReadLine().Split(' '); // вводимая последовательность
                int c = Convert.ToInt32(input[0]);

                if (inputLength == "1")
                {
                    finalOutput = input[0] + " 0";
                }

                for (int j = 1; j < input.Length; j++)
                {
                    int howMany = 0;
                    finalOutput += c + " ";
                    if (Convert.ToInt32(input[j]) > c)
                    {
                        bool increase = true;
                        while (increase)
                        {
                            if (Convert.ToInt32(input[j]) - c == 1)
                            {
                                c = Convert.ToInt32(input[j]);
                                howMany++;
                                if (j != input.Length - 1)
                                    j++;
                                else // если упираемся в конец последовательности
                                {
                                    finalOutput += howMany.ToString();
                                    increase = false;
                                }
                            }
                            else
                            {
                                c = Convert.ToInt32(input[j]);
                                finalOutput += howMany.ToString() + " ";
                                increase = false;
                                if (j == input.Length - 1)
                                {
                                    finalOutput += c + " 0";
                                }
                            }
                        }
                    }
                    else if (Convert.ToInt32(input[j]) < c)
                    {
                        bool decrease = true;
                        while (decrease)
                        {
                            if (c - Convert.ToInt32(input[j]) == 1)
                            {
                                c = Convert.ToInt32(input[j]);
                                howMany++;
                                if (j != input.Length - 1)
                                    j++;
                                else // если упираемся в конец последовательности
                                {
                                    finalOutput += "-" + howMany.ToString();
                                    decrease = false;
                                }
                            }
                            else
                            {
                                c = Convert.ToInt32(input[j]);
                                if (howMany == 0)
                                    finalOutput += howMany.ToString() + " ";
                                else
                                    finalOutput += "-" + howMany.ToString() + " ";
                                decrease = false;
                                if (j == input.Length - 1)
                                {
                                    finalOutput += c + " 0";
                                }
                            }
                        }
                    }
                    else if (Convert.ToInt32(input[j]) == c)
                    {
                        finalOutput += "0 ";
                        if (j == input.Length - 1)
                        {
                            finalOutput += c + " 0";
                        }
                    }
                }
                Console.WriteLine(finalOutput.Split(' ').Length.ToString());
                Console.WriteLine(finalOutput);
            }
        }
    }
}
