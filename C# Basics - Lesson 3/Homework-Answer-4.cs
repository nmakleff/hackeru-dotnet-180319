using System;

public class Program
{
    public static void Main()
    {
        const int ROWS_NUM = 5;

        for (int i = 0; i < ROWS_NUM; i++)
        {
            int spacesBeforeAst = (ROWS_NUM / 2) - i;
            if (spacesBeforeAst < 0)
                spacesBeforeAst = spacesBeforeAst * (-1);

            int astetisks = ROWS_NUM - (spacesBeforeAst * 2);

            for (int j = 0; j < spacesBeforeAst; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < astetisks; j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < spacesBeforeAst; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
