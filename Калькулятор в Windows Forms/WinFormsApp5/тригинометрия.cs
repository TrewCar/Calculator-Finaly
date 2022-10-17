using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class  ArrayTools
    {
        public string[] CosSin(string[] array)
        {
            var result = new string[array.Length];
            for (int g = 0; g < array.Length; g++)        
            {
                
                if (array[g] == "abs")
                {
                    double a = double.Parse(array[g + 1]);

                    a = Math.Abs(a);
                    array[g] = Convert.ToString(a);
                    array[g + 1] = Convert.ToString(a);
                }
                if(array[g] == "log")
                {
                    double a = double.Parse(array[g + 1]);
                    double c = double.Parse(array[g + 2]);
                    double b = Math.Log(c, a);

                    array[g] = Convert.ToString(b);
                    array[g + 1] = Convert.ToString(b);
                    array[g + 2] = Convert.ToString(b);
                }
                if (array[g] == "cos")
                {
                    double a = double.Parse(array[g + 1]);

                    double b = Math.Cos(a);

                    array[g] = Convert.ToString(b);
                    array[g + 1] = Convert.ToString(b);
                }
                if (array[g] == "sin")
                {
                    double a = double.Parse(array[g + 1]);

                    double b = Math.Sin(a);

                    array[g] = Convert.ToString(b);
                    array[g + 1] = Convert.ToString(b);
                }
                if (array[g] == "tg")
                {
                    double a = double.Parse(array[g + 1]);

                    double b = Math.Tan(a);

                    array[g] = Convert.ToString(b);
                    array[g + 1] = Convert.ToString(b);
                }
                if (array[g] == "ctg")
                {
                    double a = double.Parse(array[g + 1]);

                    double b = 1 / Math.Tan(a);

                    array[g] = Convert.ToString(b);
                    array[g + 1] = Convert.ToString(b);
                }
                
            }
            return result;
        }
    }
}
