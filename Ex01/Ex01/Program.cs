using System;
using System.Collections;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // đếm số phần tử chẫn và lẻ trong mảng
            // xuát ra những phần tử chẵn và lẽ

            int[] phantu = { 22, 252, 5, 36, 6, 3, 63, 6, 36 };
            int countChan = 0;
            int countLe = 0;
            ArrayList myALChan = new ArrayList();
            ArrayList myALLe = new ArrayList();

            for (int i = 0; i < phantu.Length; i++)
            {
                if (phantu[i] % 2 == 0)
                {
                    myALChan.Add(phantu[i]);
                    countChan++;
                }
                else
                {
                    myALLe.Add(phantu[i]);
                    countLe++;
                }
            }
            Console.Write("Co tat ca {0} so chan - {1}", countChan, string.Join(",", myALChan.ToArray()));
            Console.WriteLine("");
            Console.Write("Co tat ca {0} so le - {1}", countLe, string.Join(",", myALLe.ToArray()));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("==========================EX02=================================");

            int value = 36;
            findPosition(value, phantu);

        }
        public static void findPosition(int x, int[] arr)
        {
            for (int i = 0; i<arr.Length; i++)
            {               
                if(arr[i] == x)
                {
                    Console.WriteLine("Phan tu X trong mang o vi tri thu {0}", i+1 );
                }
                
            }
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
