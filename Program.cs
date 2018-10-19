using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        // public static int[] RandomArray1()
        // {
        //     int[] arr = new int[10];
        //     Random rand = new Random();
        //     for (int i = 0; i<arr.Length; i++)
        //     {
        //         arr[i] = rand.Next(5,26);
        //     }
        //     return arr;
        // }

        // public static int[] RandomArray2()
        //     {
        //         int[] arr = new int[10];
        //         Random rand = new Random();
        //         for (int i = 0; i<arr.Length; i++)
        //         {
        //             arr[i] = rand.Next(5,26);
        //         }
        //         int max = arr[0];
        //         int min = arr[0];
        //         int sum = arr[0];
        //         for (int i = 1; i<arr.Length; i++)
        //         {
        //             if (arr[i]>max)
        //             {
        //                 max = arr[i];
        //             }
        //             if (arr[i]<min)
        //             {
        //                 min = arr[i];
        //             }
        //             sum += arr[i];
        //         }
        //         System.Console.WriteLine(max);
        //         System.Console.WriteLine(min);
        //         System.Console.WriteLine(sum);
        //         return arr;
        //     }

        // public static string TossCoin()
        // {
        //     System.Console.WriteLine("Tossing a Coin!");
        //     Random rand = new Random();
        //     int coin = rand.Next(0,2);
        //     if (coin==0)
        //     {
        //         System.Console.WriteLine("Heads");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Tails");
        //     }
        //     return coin.ToString();
        // }

        // public static double TossCoin2(int num)
        // {
        //     System.Console.WriteLine("Tossing Coin(s)!");
        //     double sumCount = 0;
        //     double headCount = 0;
        //     Random rand = new Random();
        //     for(int i =0; i<num; i++)
        //     {    
        //         int coin = rand.Next(0,2);
        //         if (coin==0)
        //         {
        //             System.Console.WriteLine("Heads");
        //             headCount++;
        //             sumCount++;
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("Tails");
        //             sumCount++;
        //         }
        //     }
        //     double ratio = headCount/sumCount;
        //     return ratio;
        // }

        public static string[] Names(string[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i<arr.Length; i++)
            {
                int name = rand.Next(arr.Length);
                string temp = arr[i];
                arr[i] = arr[name];
                arr[name] = temp;
            }
            List<string> names = new List<string>();
            for (int i = 0; i<arr.Length; i++)
            {
                if(arr[i].Length>=5)
                {
                    names.Add(arr[i]);
                }
            }
            string[] newarr = names.ToArray();
            return newarr;
        }

        public static void Main(string[] args)
        {
            // Names: Array of Strings with 5 names that shuffles and only returns names longer than 5
            string[] arr = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            foreach (var item in Names(arr))
            {
                System.Console.WriteLine(item);
            }
            // // Coin2: Toss coins multiple times and return a double based on head to total ratio
            // int num = 5;
            // System.Console.WriteLine(TossCoin2(num));
            // // Coin1: Have a function print "Tossing a Coin!"
            // System.Console.WriteLine(TossCoin());
            // // RandomArray3: Print the sum of all the values
            // // RandomArray2: Print Min and Max of the array
            // foreach (var item in RandomArray2())
            // {
            //     System.Console.WriteLine(item);
            // }

            // // RandomArray1: Place 10 random int values between 5-25 into the array
            // foreach (var item in RandomArray1())
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
