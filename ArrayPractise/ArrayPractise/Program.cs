using System;

namespace ArrayPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4]; //creating array  
            arr[0] = 10; 
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }

            int[] arr1 = new int[] { 100,200,300,400};
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            int[] arr2 = {10,20,30,40};
            foreach (int i in arr2) {
                Console.WriteLine(i);
            }

            //Multi dimention array
            int[,] marr = new int[4,2];
            int[,,] marr1 = new int[4,2,3];
            // Two-dimensional array.
            int[,] array2D = new int[,] { {1, 2}, {3, 4}, {5,6} };
            Console.WriteLine(array2D[0, 0]);
            Console.WriteLine(array2D[0, 1]);

            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };

            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine(array3Da[1, 0, 1]);
            Console.WriteLine(array3D[1, 1, 2]);

            //You can also initialize the array without specifying the rank.
            int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //If you choose to declare an array variable without initialization, you must use the new operator
            //to assign an array to the variable. The use of new is shown in the following example.
            int[,] array5 = new int[4,5];

            //A jagged array is an array whose elements are arrays, possibly of different sizes.

            //single-dimensional array that has three elements
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            //You can also initialize the array upon declaration like this:
            int[][] jaggedArray2 = new int[][]
            {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 0, 2, 4, 6 },
            new int[] { 11, 22 }
            };


            int[][] jaggedArray3 =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            //A jagged array is an array of arrays, and therefore its elements are reference types and are
            //initialized to null

            // Assign 77 to the second element ([1]) of the first array ([0]):
            jaggedArray3[0][1] = 77;

            // Assign 88 to the second element ([1]) of the third array ([2]):
            jaggedArray3[2][1] = 88;


            int[][,] jaggedArray4 = new int[3][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };

            Console.Write("{0}", jaggedArray4[0][1, 0]);

        }
    }
}
