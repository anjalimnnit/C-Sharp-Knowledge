using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // < data_type> ? <variable_name> = null; We cannot assign null value to int so use nullable int to do so.
            int? n = null;
            n = 10;
            int p = n ?? 5; // The Null Coalescing Operator (??) Asign 5 to p if n is null.
           
            Console.WriteLine(p);
        }
    }
}
