using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring an array of length 5, initialized by default to all zeroes
            int[] numArray = new int[5];
            // Declaring an array with pre-populated values
            // For Arrays initialized this way, the length is determined by the size of the given data
            int[] numArray2 = {1,2,3,4,6};
            // It is possible to declare an array without initialization, but you must use the "new" operator once you do define the array's values
            int[] array3;
            array3 = new int[] {1,3,5,7,9};
            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray2[0]);
            Console.WriteLine(array3[0]);
            Console.WriteLine("*********");

            //accessing arrays
            int[] arrayOfInts = {1, 2, 3, 4, 5};
            Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
            Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
            Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
            Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
            Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.
            Console.WriteLine("*********");

            int[] arr = {1, 2, 3, 4};
            Console.WriteLine("The first number of the arr is " + arr[0]); 
            arr[0] = 8;
            Console.WriteLine("The first number of the arr is now " + arr[0]);   // The array has now changed!
            Console.WriteLine("*********");

            // iterating through an array
            string[] myCars = new string[4] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // The 'Length' property tells us how many values are in the Array (4 in our example here). copy
            // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            for (int idx = 0; idx < myCars.Length; idx++)
            {
                Console.WriteLine("I own a {0}", myCars[idx]);
            }
            Console.WriteLine("*********");

            // Foreach
            //string[] myCars = new string[4] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
            foreach (string car in myCars)
            {
                // We no longer need the index, because variable 'car' already contains each indexed value
                Console.WriteLine("I own a {0}", car);
            }


        }
    }
}
