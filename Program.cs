﻿using System;
using System.Globalization;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example array for test cases
            int[] array = {1, 7, 89};

            // Use the Main method to test your functions.
            Console.WriteLine(Add(2,3));
            Console.WriteLine(IsEven(6));
            Console.WriteLine(IsEven(5));
            Console.WriteLine(MaxOfThree(3,1,1));
            Console.WriteLine(StringLength("So Cool!"));
            Console.WriteLine(ReverseString("Hello!"));
            Console.WriteLine(Factorial(6));
            Console.WriteLine(IsPrime(925223));
            Console.WriteLine(Fibonacci(6));
            Console.WriteLine(LargestInArray(array));
            Console.WriteLine(IsPalindrome("raceca"));
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(ArraySum(array));
            Console.WriteLine(CharCount("NNnNnooo Way", 'n'));
            Console.WriteLine(ConcatenateStrings("Yes", "No"));
            Console.WriteLine(SwapEnds("Doctor"));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            // TODO: Implement this method.
            int result = a + b;
            return result;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            // TODO: Implement this method.
            bool evenCheck = false;
            //if number is divisble by two pass true
            if (number % 2 == 0) {
                evenCheck = true;
            }
            return evenCheck;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int hightestNumber;
            //Compares each number to two others to find which is greatest
            if( a >= b && a >= c) {
                hightestNumber = a;
            } else if( b >= a && b >= c) {
                hightestNumber = b;
            } else {
                hightestNumber = c;
            }
            return hightestNumber;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            // TODO: Implement this method.
            int numberOfChar = 0;
            //Iterates through every character in a string incrementing numberOfChar each time
            foreach (char character in s) {
                numberOfChar++;
            }
            return numberOfChar;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.
            bool helloCheck;
            //checks if the string starts with hello and returns the valid value
            if (s.StartsWith("Hello")) {
                helloCheck = true;
            } else {
                helloCheck = false;
            }
            return helloCheck;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            // TODO: Reverse the charArray.
            int index = charArray.Length - 1;
            string result = "";
            //iterate from the end of the string to the start adding a character each time. 
            for (int  i = index; i >= 0; i--) {
                result += charArray[i];
            }
            return result;
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            int result = n;
            // TODO: Calculate the factorial.
            //for every number less than n multiply n by that number
            for (int i = n- 1; i > 0; i--) {
                result *= i;
            }
            return result;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            //Checks every number greater than one and less than the input to see if its divisble with the orignal input
            for (int i = number - 1; i > 1; i--) {
                if (number % i == 0) {
                    return false;
                } else { 
                }
            }
            // TODO: Return the correct boolean value.
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            // TODO: Calculate the nth Fibonacci number.
            int currentFib = 0;
            int twoAgoFib = 0;
            int previousFib = 1 ;
            //Loops through the sequence starting on 2 up until the sequence at the inputs value
            for (int i = 2; i <= n; i++) {
                currentFib = twoAgoFib + previousFib;
                twoAgoFib = previousFib;
                previousFib = currentFib;
            }
            return currentFib;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {

            int max = 0;
            //Holds a max variable that constanstly checks in the loop if anything is greater than it
            for (int i = 1; i < numbers.Length; i++)
            {
                // TODO: Find the largest number in the array.
                if(numbers[i] > max) {
                    max = numbers[i];
                }
            }
            return max;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            // TODO: Determine if the string is a palindrome.
            string orignal = s;
            char[] charArray = s.ToCharArray();
            int index = charArray.Count() - 1;
            string reversedString = "";
            // reverse the string given and then compare that to the input
            for (int  i = index; i >= 0; i--) {
                reversedString += charArray[i];
            }
            if (reversedString == orignal) {
                return true;
            }
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // TODO: Calculate the sum of the array's elements.
            //Loops through the array and adds the elements value to sum
            foreach (int num in numbers) {
                sum += num;
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            s = s.ToLower();
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            //loops through the string to see if any of the characters are equal to the input
            foreach (char character in s) {
                if  (character == c) {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            //Adds str 1 and str 2 together with a space between
            string result = str1 + " " + str2;
            return result;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.
            //Create a charArray to be able to swap individual characters in the string
            char[] charArray = s.ToCharArray();
            charArray[0] = lastChar;
            charArray[s.Length - 1] = firstChar;
            return new string(charArray);
        }
    }
}
