using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp5;

namespace ConsoleApp6
{
    public class Skobki
    {
        public string[] skobi(string[] array)
        {
            var result = new string[array.Length];
            Skobki skobki = new Skobki();
            ArrayTools tools = new ArrayTools();
            DelUmn tool = new DelUmn();
            Корень sqr = new Корень();
            


            int aa = 0;
            int bb = 0;
            int p = 0;

            for (int i = bb; i < array.Length; i++)
            {
                if (array[i] == "(")
                {
                    if (p == 0)
                    {
                        aa = i+1;
                    }
                    p++;
                }
                if (array[i] == ")")
                {                    
                    p--;
                    if(p == 0)
                    {
                        bb = i;
                        break;
                    }
                }
            }            
            if(aa==0)
            {
                return result;
            }


            string[] s = array[aa..bb].ToArray(); 


            string[] err = new string[s.Length + 4];
            for (int i = 0; i < err.Length; i++)
            {
                if (i < 2 || i > s.Length + 1)
                    err[i] = "0";
                else
                    err[i] = s[i - 2];
            }

            err[0] = "0";
            err[1] = "+";
            err[err.Length - 1] = "0";
            err[err.Length - 2] = "+";

            for (int g = 0; g < err.Length; g++)
            {
                skobki.skobi(err);
            }
            tools.CosSin(err);    
            var err1 = err.EachDistinct().ToArray();

            sqr.Sqrt(err1);
            var err34 = err1.EachDistinct().ToArray();

            

            tool.delumn(err34);
            var err2 = err34.EachDistinct().ToArray();


            double result2 = 0;
            for (int g = 0; g < err2.Length; g++)
            {
                if (err2[g] == "+")
                {
                    double a = Convert.ToDouble(err2[g - 1]);
                    double b = Convert.ToDouble(err2[g + 1]);

                    if (g - 2 == 0)
                    {
                        result2 = a + b;
                    }
                    else
                    {
                        result2 += b;
                    }
                }
                if (err2[g] == "-")
                {
                    double a = Convert.ToDouble(err2[g - 1]);
                    double b = Convert.ToDouble(err2[g + 1]);

                    if (g - 2 == 0)
                    {
                        result2 = a - b;
                    }
                    else
                    {
                        result2 -= b;
                    }
                }
            }
            

            for (int i = aa-1; i < array.Length; i++)
            {
                array[i] = Convert.ToString(result2);
                if (i == bb)
                {
                    break;
                }
            }
            
            return result;
        }
    }
}
