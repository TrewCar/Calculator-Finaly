using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Корень
    {
        public string[] Sqrt(string[] array)
        {
            var result = new string[array.Length];
            for (int g = 0; g < array.Length; g++)
            {


                if (array[g] == "sqrt")
                {
                    double a = double.Parse(array[g + 1]);
                    try
                    {
                        double c = double.Parse(array[g + 2]);

                        double b = Math.Pow(c, 1 / a);
                        array[g] = Convert.ToString(b);
                        array[g + 1] = Convert.ToString(b);
                        array[g + 2] = Convert.ToString(b);
                    }
                    catch
                    {
                        double b = Math.Sqrt(a);
                        array[g] = Convert.ToString(b);
                        array[g + 1] = Convert.ToString(b);
                    }
                }
            }
            return result;
        }

    }
}
