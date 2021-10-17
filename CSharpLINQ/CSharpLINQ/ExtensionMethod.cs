using System;

namespace CSharpLINQ
{
   public  static class ExtensionMethod
    {
        /* C# extension method is a static method of a static class, 
         where the "this" modifier is applied to the first parameter 
        We use extension method to add new functionality to existing class which we do not have access to */

        public static string ToDeviceFormat(this DateTime date)
        {
            string result = date.ToString("yyyyMMddhhmmss");
            return date.Year >= 2000 ? result : result.Substring(2);
        }
    }
}
