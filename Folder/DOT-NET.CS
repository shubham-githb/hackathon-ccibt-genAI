using System;

class Program
{
    static void Main()
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int space = 1; space <= rows - i; space++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int star = 1; star <= (2 * i - 1); star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
