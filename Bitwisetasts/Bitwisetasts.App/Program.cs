using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwisetasts.App
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = Convert.ToInt32(Console.ReadLine()); // Q19
            int o = i & 1;
            Debug.Assert(o == 1);

            int i2 = Convert.ToInt32(Console.ReadLine()); // Q23
            int o2 = i >> 1;
            Console.WriteLine(o2);
            
            int i3 = Convert.ToInt32(Console.ReadLine()); // Q30
            countbits(i3);
            */
            int i4 = Convert.ToInt32(Console.ReadLine());
            int basenum = Convert.ToInt32(Console.ReadLine());
            baseinator(i4, basenum);
        }
        static void countbits(int i3)
        {

            int i = 0;
            while (i3 != 0)
            {
                i3 = i3 >> 1;
                i += 1;
            }
            Console.WriteLine(i);
            string _ = Console.ReadLine();
        }
        static void baseinator (int i4, int basenum)
        {
            /* So this method would only work if the base is a base that C# uses or something like that...*/
            // That is if I have no list of characters to assign to for C#
            // string output = Convert.ToInt32(i4 basenum);
            // Console.WriteLine(output);
            int holder = Convert.ToInt32(Math.Log(i4) / Math.Log(basenum));
            int length = Convert.ToInt32(Math.Pow(basenum, holder));

            List<int> outputlist = new List<int>();


            do
            {
                
                {
                    if(i4>=length)
                    {
                        int output = i4 / length;
                        outputlist.Add(output);
                        i4 -= length*output;
                    }
                    else
                    {
                        outputlist.Add(0);
                    }
                    
                    Console.WriteLine(i4);
                    length = length / basenum;
                    Console.WriteLine(length);

                }
            }
            while (length != 0);
            string final = string.Join(" "/*Environment.NewLine */, outputlist);

            Console.WriteLine(final);



            
            
            string _ = Console.ReadLine();
        }
    }
}
