﻿namespace numeronarcisista
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Narcisistas:");

            for (int i = 0; i <= 1000; i++)
            {
                if (verificanumero(i))
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey(true);
        }
    }
}