using System;
using System.Collections.Generic;
namespace basic13
{
    public class Program
    {
        public static void BasicNumCount()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void OddNumCount()
        {
            for (int i = 1; i < 255; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void NumCountSum()
        {   
            int sum = 0;
            for (int i = 1; i < 255; i++)
            {
                sum = sum + i;
                Console.Write("New Number: {0} Sum {1}\n",i,sum);
            }
            
        }
        public static void ItrArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\n");
            }
        }
        public static void MaxArr(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        public static void AvgArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            int avg = sum/arr.Length;
            Console.WriteLine(avg);
        }
        public static int[] OddNumArr()
        {
            int[] y = new int[127];
            int counter = 0;
            for (int i = 0; i < 255; i++)
            {
                if (i % 2 != 0)
                {
                    y[counter] = i;
                    counter += 1;
                }
            }
            // foreach (int num in y)
            // {
            //     Console.WriteLine(num);
            // }
            return y;
        }
        public static int GreaterThanY(int[] arr, int y)
        {
            int GrtCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > y)
                GrtCount += 1;
            }
            Console.WriteLine("There are {0} numbers in the array greater than {1}.",GrtCount,y);
            return GrtCount;
        }
        public static int[] SqrArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            // foreach (int num in arr)
            // {
            //     Console.WriteLine(num);
            // }
            return arr;
        }        
        public static int[] NoNegNumsArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            // foreach (int num in arr)
            // {
            //     Console.WriteLine(num);
            // }
            return arr;
        }
        public static void MinMaxAvg(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int avg = sum/arr.Length;
            Console.WriteLine("Min: {0} Max: {1}, Avg: {2}",min,max,avg);
        }
        public static int[] ArrShift(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[arr.Length-1])
                {
                    arr[i] = 0;
                }
                else
                {
                    arr[i] = arr[i+1];
                }
            }
            // foreach (int num in arr)
            // {
            //     Console.WriteLine(num);
            // }
            return arr;
        }
        public static object[] NumToString(int[] arr)
        {
            object[] NewArr = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    NewArr[i] = "Dojo";
                }
                else
                {
                    NewArr[i] = arr[i];
                }
            }
            // foreach (var value in NewArr)
            // {
            //     Console.WriteLine(value);
            // }
            return NewArr;
        }
        static void Main(string[] args)
        {
            BasicNumCount();
            OddNumCount();
            NumCountSum();
            ItrArr(new int[] {1,3,5,7,9,13});
            MaxArr(new int[] {-3,-5,-7});
            AvgArr(new int[] {2,10,3});
            OddNumArr();
            GreaterThanY(new int[] {1,3,5,7}, 3);
            SqrArr(new int[] {1,5,10,-2});
            NoNegNumsArr(new int[] {1,5,10,-2});
            MinMaxAvg(new int[] {1,5,10,-2});
            ArrShift(new int[] {1,5,10,7,-2});
            NumToString(new int[] {-1,-3,2});
        }
    }
}
