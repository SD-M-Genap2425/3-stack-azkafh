using System;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string text)
        {
            if(text == null)
            {
                return false;
            }

            string normalizedText = new string(text.ToLower().Where(char.IsLetter).ToArray());

            if (string.IsNullOrEmpty(normalizedText))
            {
                return true;
            }

            Stack<char> stack = new Stack<char>();
            foreach(char data in normalizedText)
            {
                stack.Push(data);
            }

            foreach (char data in normalizedText)
            {
                if (data != stack.Pop())
                {
                    return false;
                }
            }
            return true;

        } 
    }
}
