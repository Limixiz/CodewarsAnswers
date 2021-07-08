using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    
    public static class Kata
    {
        
        public static string Order(string words)
        {

            //return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));

            string[] stringArray = new string[10];
            //StringBuilder stringBuilder = new StringBuilder();

            foreach (string word in words.Split(' '))
            {
                foreach (char item in word)
                {
                    if (Char.IsDigit(item))
                    {
                        var newplaceinarray = Convert.ToInt32(Char.ToString(item));

                            stringArray[newplaceinarray] = word;
 
                    }
                }
                
            }
            
            //foreach (var item in stringArray)
            //{
            //    stringBuilder.Append(item);
            //    stringBuilder.Append(" ");
            //}
            string newords = String.Join(" ", stringArray).Trim();
            var end = ($"{words} -----> {newords}");
            return end;


        }

    }
}
