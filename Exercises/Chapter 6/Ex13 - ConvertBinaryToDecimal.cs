using System;



namespace FundamentalsOfComputerProgrammingWithCSharp
{


    namespace Chapter6
    {
        public static class Ex13_ConvertBinaryToDecimal
        {
            // Contains main solution code 
            public static void Solution()
            {
                Console.Write("Enter binary string: ");
                string binary = Console.ReadLine();

                int number = 0;

                for (int i = 0; i < binary.Length; ++i)
                {
                    // If an invalid binary digit is found during conversion, it will report an error and end the program
                    if (!(binary[i] >= '0' && binary[i] <= '1'))
                    {
                        Console.WriteLine($"Error: Invalid binary digit {binary[i]} found");
                        return;
                    }

                    // Using unicode char offset to convert the char digit to integer digit
                    number += (binary[i] - 48) * (int)Math.Pow(2, binary.Length - 1 - i);
                }

                // Alternatively
                // int number = Convert.ToInt32(binary, 2);
                Console.Write($"{binary} in decimal is: {number}");

            }
        }
    }
}