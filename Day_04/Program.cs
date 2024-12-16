using System.Globalization;
using System.Text;

namespace Day_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region for each and for
            ////int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////for (int i = 0; i < numbers.Length; i++) {

            ////    Console.WriteLine(numbers[i]);

            ////}
            ////foreach(int number in numbers)
            ////{
            ////    Console.WriteLine(number);
            ////}
            #endregion

            #region while and dowhile

            //int number=2;
            //bool flag=true;

            //while (number % 2 == 0|| !flag)
            //{
            //    Console.WriteLine("enter odd number");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //Console.WriteLine($" {number} is odd");


            #endregion


            #region string

            //string name="alaa";
            //string name2 = "alaa";
            //string name3 = "alaa";
            //Console.WriteLine($"name is {name}");
            //Console.WriteLine($"name ha: {name.GetHashCode()}");
            //Console.WriteLine($"name is {name2}");
            //Console.WriteLine($"name ha: {name2.GetHashCode()}");
            //Console.WriteLine($"name is {name3}");
            //Console.WriteLine($"name ha: {name3.GetHashCode()}");


            #endregion

            #region string builder
            //StringBuilder message ;
            //message = new StringBuilder("Hello");

            //message.Append(" abo ");
            //Console.WriteLine(message);

            //message.AppendLine("To");
            //Console.WriteLine(message);

            //message.Insert(0, "ko");
            //Console.WriteLine(message);

            //string name = "mano";
            //int age = 21;

            //message.AppendFormat(" {0} your age is {1}", name, age);
            //Console.WriteLine(message);

            #endregion

            #region araay

            #region 1D
            //int[] number = new int[3];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine($"enter the number of {i}");
            //    number[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Clear();
            //for (int i = 0; i < number.Length; i++)
            //{

            //    Console.WriteLine(number[i]);
            #endregion

            #region 2D
            //int[,] marks = new int[3,5] { {1,2,3,4,5 }, {3,4,5,6,7 }, {6,7,8,9,10}};
            //bool flag;
            //for(int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"marks of student number {i+1}");
            //    for(int k = 0; k < marks.GetLength(1); k++)
            //    {
            //        Console.Write($"marks of subject{k+1} ");
            //       flag=int.TryParse(Console.ReadLine(), out marks[i, k]);
            //    }

            //}

            //Console.Clear();

            //for(int i=0;i<marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"marks of student {i+1}");
            //    for (int k = 0;k < marks.GetLength(1); k++)
            //    {
            //        Console.Write($"marks of subject {k+1}");
            //        Console.WriteLine(marks[i,k]);
            //    }
            //}

            #endregion

            #region 2D arrray (one iteration)

            //int[,] marks = new int[2, 4] { { 1,2,3,4}, {5,6,7,8} };

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine(marks[i/marks.GetLength(1),i%marks.GetLength(1)]);
            //}
            #endregion

            #region judge array

            //int[][] numbers = new int[3][];
            //numbers[0] = new int[] { 1, 2, 3, 4, 5 };
            //numbers[1] = new int[] { 9, 10 };
            //numbers[2] = new int[] { 7, 8, 80, 90 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for(int k = 0; k < numbers[i].Length; k++)
            //    {
            //        Console.WriteLine(numbers[i][k]);
            //    }

            //    Console.WriteLine("========");
            //}
            #endregion

            #region array method
            #region class member method
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array.Sort(number);
            //Array.Reverse(number);
            //Array.Clear(number);

            //int[] arr01 = { 1, 2, 3, 4, 5 };
            //int[] arr02 = new int[5];

            //Array.ConstrainedCopy(arr01, 1, arr02, 1, 2);

            //foreach (int i in arr01)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=========");
            //foreach (int i in arr02)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] arr03 = (string[])Array.CreateInstance(typeof(string), 10);

            //int[,] arr04 = (int[,])Array.CreateInstance(typeof(int), 10, 20);

            //string[] arr03 = (string[])Array.CreateInstance(typeof(string), 10);
            //int[,] arr04 = (int[,])Array.CreateInstance(typeof(int),20, 10);
            //int[,,] arr05 = (int[,,])Array.CreateInstance(typeof(int), 20, 10, 10);
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 ,2};
            //int index = Array.LastIndexOf(numbers, 2);
            //Console.WriteLine(index);
            #endregion

            #region non static method [object member]
            // int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine(number[1]);

            //Console.WriteLine(number.GetValue(1));

            //  number.SetValue(100,2);
            //for (int i = 0; i < number.Length; i++) {
            //    Console.WriteLine(number[i]);
            //}
            #endregion
            #endregion
        }

        #endregion
    }

    }

