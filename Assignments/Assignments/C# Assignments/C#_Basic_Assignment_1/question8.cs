using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class question8
    {
        public static void Main()
        {
            //Write an algorithm for accepting third character of the given string and then display whether it is vowel or constant
            Console.WriteLine("Enter the Word :");
            string word = Console.ReadLine();
            char ch = word[2];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("It is an Vowel");
            }
            else {
                Console.WriteLine("It is Constant");
            }
    
        }
    }
}
