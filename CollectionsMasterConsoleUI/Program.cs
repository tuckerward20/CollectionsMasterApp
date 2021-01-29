using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50

            var myArray = new int[50];
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(myArray);
            //Print the first number of the array
            Console.WriteLine($"The first number in the array is: {myArray[0]}");
            //Print the last number of the array            
            Console.WriteLine($"The last number in the array is: {myArray[(myArray.Length - 1)]}");
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            //NumberPrinter();
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            int[] revArray1 = myArray;
            Array.Reverse(revArray1);
            NumberPrinter(revArray1);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            int[] revArray2 = myArray;
            ReverseArray(revArray2);
            NumberPrinter(revArray2);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            int[] threeArray = myArray;
            ThreeKiller(threeArray);
            NumberPrinter(threeArray);
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(threeArray);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List

            List<int> myList = new List<int>();
            //Print the capacity of the list to the console

            Console.WriteLine(myList.Count);
            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(myList);
            //Print the new capacity

            Console.WriteLine(myList.Count);
            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            
            
            Console.WriteLine("What number will you search for in the number list?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            if (myList.Contains(userInput))
            {
                Console.WriteLine($"{userInput} is in the list.");
            }
            else if ((myList.Contains(userInput)) == false)
            {
                Console.WriteLine($"{userInput} is not in the list.");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            NumberPrinter(myList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(myList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            myList.Sort();
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] myListArray = myList.ToArray();

            //Clear the list
            myList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 3 == 0)
                {  
                    numbers[Array.IndexOf(numbers,item)] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 1)
                {
                    numberList[i] = 0;
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i <= 50; i++)
            {
                numberList.Add(rng.Next(50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            foreach (int item in array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[(array.Length - 1) - i];
                }
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
