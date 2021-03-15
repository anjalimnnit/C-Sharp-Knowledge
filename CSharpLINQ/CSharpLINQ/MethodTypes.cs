using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLINQ
{
    class MethodTypes
    {
        public  void Function()
        {
            List<int> ratings = new List<int>()
        {
            200, 300, 250, 360};

//Lambda method
            var newRating = ratings.Where(r => r > 250);
//Anonymous method
            var newRating3 = ratings.Where(delegate (int rating)
                {
                    return rating > 250;
                });

           foreach(var rating in newRating)
            {
                Console.WriteLine(rating);
            }
            foreach (var rating in newRating3)
            {
                Console.WriteLine(rating);
            }

        }
    }
}

