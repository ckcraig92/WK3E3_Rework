using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace WK3E3_Rework
{
    internal class Program
    {
        //creating methods
        public static void ReverseString(string userInput)
        {
            char[] charArray = userInput.ToCharArray(); //convert the string to an array
            Array.Reverse(charArray); //reversing the array
            Console.WriteLine("The reversed string is: " + new string(charArray)); //print for user to view

        }

        //creating methods
        public static void CountVowels(string userInput)
        {
            int vowelCount = 0; //starting the count at 0
            foreach (char c in userInput.ToLower()) //looping through each character
            {
                if ("aeiou".Contains(c)) //listing the vowels
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The vowel count in the string is: " + vowelCount); //print for user to view
        }

        public static void IsPalindrome(string userInput)
        {
            char[] charArray = userInput.ToCharArray(); //create array
            Array.Reverse(charArray);// reversing
            string reveresed = new string(charArray); //new string

            if (userInput == reveresed) //testing
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        static void Main(string[] args)
        {
            //declaration
            string userInput;


            //input
            Console.WriteLine("Input a string");
            userInput = Console.ReadLine();

            {
                //menu
                Console.WriteLine("Operations Menu:");
                Console.WriteLine(" 1. Reverse String");
                Console.WriteLine(" 2. Count Vowels");
                Console.WriteLine(" 3. Is Palindrome");
                Console.WriteLine("Select an option from the menu above");


            }
            //process
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ReverseString(userInput);
                    break;
                case 2:
                    CountVowels(userInput);
                    break;
                case 3:
                    IsPalindrome(userInput);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    }