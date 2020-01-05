﻿using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The number is greater than 10");
                Console.WriteLine("And the first number is equal to the second ");
            }
            else
            {
                Console.WriteLine("The number is not greater than 10");
                Console.WriteLine("Or the first number is not equal to second");
            }

            if((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The number is greater than 10");
                Console.WriteLine("Or the first number is equal to the second ");
            }
            else
            {
                Console.WriteLine("The number is not greater than 10");
                Console.WriteLine("And the first number is not equal to second");
            }

        }
        static void Main(string[] args)
        {
            //ExploreIf();
            int counter  = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World, the counter is {counter}");
                counter++;
            }

            int counterDo = 0;
            do{
                Console.WriteLine($"Hola! the counter is {counterDo}");
                counterDo++;
            } while( counterDo < 10);

            for(int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }


            int sum = 0;
            for (int number = 1; number <= 21; number++)
            {
                if(number % 3 == 0)
                {
                   sum = sum + number;
                }
            }
            Console.WriteLine($" The sum is  {sum}");
        }
    }
}
