using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return false;
        }
        var reversed = new string(input.ToLower().Reverse().ToArray());
        
        if(input.ToLower() != reversed)
        {
            return false;
        }

        return true;
    }
}