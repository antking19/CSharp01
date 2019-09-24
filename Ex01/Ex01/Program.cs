﻿using System;

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

            for (int i = 0; i<phantu.Length; i++) {
                if(phantu[i] % 2 == 0)
                {
                    Console.WriteLine("So chan: {0}", phantu[i]);
                    countChan++;
                }
            }
            Console.WriteLine("Co tat ca {0} so chan", countChan);
            Console.WriteLine("==================================================");

            for (int i = 0; i < phantu.Length; i++)
            {
                if (phantu[i] % 2 != 0)
                {
                    Console.WriteLine("So le: {0}", phantu[i]);
                    countLe++;
                }
            }
            Console.WriteLine("Co tat ca {0} so le", countLe);
        }
    }
}