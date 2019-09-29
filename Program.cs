using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            Console.Write("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last name:");
            string lastName = Console.ReadLine();
            Console.Write("Enter your city name:");
            string city = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = " ";

            foreach(char item in firstNameArray)
            {
                result += item;
            }
            result += " ";

            foreach (char item in lastNameArray)
            {
                result += item;
            }
            result += " ";

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Result :" + result);
            char[] result1 = result.ToCharArray();
            Array.Reverse(result1);
            Console.WriteLine(result1);
            Console.ReadLine();
            */


            //Console.Write("Result :");
            //string reversedFirstName = ReverseString(firstName);
            //string reversedLastName = ReverseString(lastName);
            //string reversedcity = ReverseString(city);
            //Console.Write(string.Format("{0} {1} {2}",reversedFirstName,reversedLastName,reversedcity));

            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
            Console.WriteLine();
            DisplayResult(ReverseString(firstName) + " " + ReverseString(lastName) + " " + ReverseString(city));
            Console.ReadLine();

        }

        public static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);

            //foreach(char item in messageArray)
            //{
            //    Console.Write(item);
            //}
            //Console.Write(" ");
        }

        public static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedcity)
        {
            Console.Write("Result :");
            Console.Write(string.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedcity));
        }

        public static void DisplayResult(string message)
        {
            Console.Write("Result :");
            Console.Write(message);
        }

    }
}
