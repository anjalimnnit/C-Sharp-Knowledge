using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpLINQ
{
    class StringBuilderVsString
    {
        /*
         If a string is going to remain constant throughout the program, then use String class object because a String object is immutable.
If a string can change (example: lots of logic and operations in the construction of the string) then using a StringBuilder is the best option.
         */
        public void Differnce()
        {
            Stopwatch watch = new Stopwatch();
            string s = "Anjali";
            StringBuilder sb = new StringBuilder();
            watch.Start();
            for(int i=0;i<100000;i++)
            {
                s = s + i;
            }
            watch.Stop();
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb = sb.Append(i);
            }
            watch1.Stop();
           
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(watch1.ElapsedMilliseconds);
        }
        }
}
