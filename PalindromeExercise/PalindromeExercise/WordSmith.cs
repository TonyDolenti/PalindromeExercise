using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            str = str.ToLower();
            var reversed = "";

            if (str == null || str.Length == 0)
            {
                return false;
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            
            if (reversed == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
