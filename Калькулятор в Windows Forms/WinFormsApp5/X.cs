using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp5;

namespace ConsoleApp6
{
    public class X
    {
        public double sect(string[] err)
        {
            Skobki skobki = new Skobki();
            ArrayTools tools = new ArrayTools();
            DelUmn tool = new DelUmn();
            Корень sqr = new Корень();
            

            
            

            for (int g = 0; g < err.Length; g++)
            {
                skobki.skobi(err);
            }
            var arra = err.EachDistinct().ToArray();




            tools.CosSin(arra);
            string[] arra34 = arra.EachDistinct().ToArray();

            sqr.Sqrt(arra34);
            string[] arra35 = arra34.EachDistinct().ToArray();

            

            tool.delumn(arra35);
            string[] arra2 = arra35.EachDistinct().ToArray();




            double y = 0;
            for (int g = 0; g < arra2.Length; g++)
            {
                if (arra2[g] == "+")
                {
                    double a = Convert.ToDouble(arra2[g - 1]);
                    double b = Convert.ToDouble(arra2[g + 1]);

                    if (g - 2 < 0)
                    {
                        y = a + b;
                    }
                    else
                    {
                        y += b;
                    }
                }
                if (arra2[g] == "-")
                {
                    double a = Convert.ToDouble(arra2[g - 1]);
                    double b = Convert.ToDouble(arra2[g + 1]);

                    if (g - 2 < 0)
                    {
                        y = a - b;
                    }
                    else
                    {
                        y -= b;
                    }
                }
            }
            return y;
        }
    }
}
