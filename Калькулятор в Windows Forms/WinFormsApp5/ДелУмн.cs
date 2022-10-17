using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class DelUmn
    {
        public string[] delumn(string[] array)
        {
            var result = new string[array.Length];

            

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "^")
                {
                    double a = double.Parse(array[i - 1]);
                    double b = double.Parse(array[i + 1]);

                    double res = Math.Pow(a, b);

                    array[i - 1] = Convert.ToString(res);
                    array[i + 1] = Convert.ToString(res);

                }
                if (array[i] == "*")
                {
                    double a = double.Parse(array[i-1]);
                    double b = double.Parse(array[i+1]);

                    double res = a * b;

                    array[i - 1] = Convert.ToString(res);
                    array[i + 1] = Convert.ToString(res);
                }
                       
                if (array[i] == "/")
                {
                    double a = double.Parse(array[i - 1]);
                    double b = double.Parse(array[i + 1]);

                    double res = a / b;
                  
                    array[i - 1] = Convert.ToString(res);
                    array[i + 1] = Convert.ToString(res);
                }
                


            }
            
            int aa = 0;
            int bb = 0;
            
            repeat:
            for (int i = bb+1; i < array.Length; i++)
            {
                if ((array[i] == "*"|| array[i] == "/" || array[i] == "^") && (array[i-2] == "+" || array[i - 2] == "-"))
                {
                    aa = i - 1;
                }
                if (array[i] == ")")
                {

                }
                if ((array[i] == "*" || array[i] == "/" || array[i] == "^") && (array[i + 2] == "+" || array[i + 2] == "-"))
                {
                    
                    bb = i + 1;
                    break;
                }
                if(i == array.Length - 1)
                {
                    return result;
                }
            }
            
            double p = Convert.ToDouble(array[bb]);

            for(int i = aa; i <bb+1 ; i++ )
            {
                array[i] = Convert.ToString(p);
            }
            goto repeat;
            
            
        }
    }
}
