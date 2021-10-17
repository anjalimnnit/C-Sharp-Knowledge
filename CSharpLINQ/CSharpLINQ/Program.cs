using System;

namespace CSharpLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extension Method example 
            MethodTypes method = new MethodTypes();
            method.Function();
            DateTime date1 = new DateTime(2003, 12, 23, 04, 12, 34);
            string result = date1.ToDeviceFormat();
            Console.WriteLine(result);
            DateTime date2 = new DateTime(1999, 12, 23, 03, 12, 34);
            result = date2.ToDeviceFormat();
            Console.WriteLine(result);

            // GUID
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);
            //
            StringBuilderVsString str = new StringBuilderVsString();
            str.Differnce();
        }
    }
}
