using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata3
{
    public class Kata
    {

        public static bool ValidParentheses(string input)
        {
            int a = 0;

            int c = input.Length;
            if (0 <= c && c <= 100)
            {

                foreach (var item in input)
                {

                    if (a < 0)
                    {
                        return false;
                    }
                    if (item == '(')
                    {
                        a++;
                    }
                    if (item == ')')
                    {
                        a--;
                    }

                }
                if (a == 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
