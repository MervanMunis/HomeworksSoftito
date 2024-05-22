

using System.Diagnostics.Metrics;

namespace HomeWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            int i;

            for (i = 0; i < a.Length; i++)
            {
                Console.Write(i.ToString() + ". index: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //InsertionSort(a);
            Sorting(a);

            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[" + i.ToString() + "] = " + a[i].ToString());
            }
            Console.ReadKey();
        }

        // First thing that came to my mind!
        static int[] Sorting(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int maxValueIndex = i;

                for (int j = i + 1; j < a.Length - 1; j++)
                {
                    if (a[j] > a[maxValueIndex])
                    {
                        maxValueIndex = j;
                    }
                }
                int temp = a[maxValueIndex];
                a[maxValueIndex] = a[i];
                a[i] = temp;
            }
            return a;
        }

        // After getting some experience! For small datas a simple and efficent way.
        static int[] InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                for (int j = i - 1; j <= 0; j--)
                {
                    if (a[j] > key)
                    {
                        a[j + 1] = a[j];
                    }
                }
                a[j + 1] = key;
            }
            return a;
        }

    }
}
