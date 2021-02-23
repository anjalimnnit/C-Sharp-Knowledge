/* Encapsulates a method that has one parameter and returns a value of the type specified by the second parameter. */

using System;
using System.Collections.Generic;
public class FuncDeletegateExample
    {
        public static void Main(string[] args)
        {
            string[] names = { "patient", "monitoring", "analytics","MA","anjali" };
            Func<string,bool> _handler = new Func<string, bool>(CheckStringStartWitha);
            List<string> _resultList = Iterator(names,_handler);
			foreach(string str in _resultList)
			{
				Console.WriteLine(str);
			}
            _handler = new Func<string, bool>(CheckStringLengthGreaterThan5);
            _resultList = Iterator(names, _handler);
			foreach(string name in _resultList)
			{
				Console.WriteLine(name);
			}
            int[] numbers = { 23, 4, 5, 6, 77, 88 };
            Func<int,bool> _intHandler = new Func<int,bool>(CheckForOddNumbers);
          List<int> intResult=  Iterator<int>(numbers, _intHandler);
			foreach(int number in intResult)
			{
				Console.WriteLine(number);
			}
			
        }

        static bool CheckForOddNumbers(int item)
        {
            return item % 2 != 0;
        }
        static bool CheckStringStartWitha(string item)
        {
            return item.StartsWith("a");
        }
        static bool CheckStringLengthGreaterThan5(string item)
        {
            return item.Length > 5;
        }
        public static List<T> Iterator<T>(T[] input, Func<T,bool> predicate )
        {
            List<T> result = new List<T>();

            for (int i = 0; i < input.Length; i++)
            {
                if (predicate(input[i]))
                {
                    result.Add(input[i]);
                }
            }

            return result;
        }
    }
