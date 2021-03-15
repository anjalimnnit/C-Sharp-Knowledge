using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLINQ
{
   public  static class ExtensionMethod
    {
        /* C# extension method is a static method of a static class, 
         where the "this" modifier is applied to the first parameter */
        public static string ToDeviceFormat(this DateTime date)
        {
            string result = date.ToString("yyyyMMddhhmmss");
            return date.Year >= 2000 ? result : result.Substring(2);
        }
    }
}
