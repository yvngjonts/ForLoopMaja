using System.Drawing;

namespace WhileJaDo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta Valik:");
            Console.WriteLine("1 Maja");

            string meetod = Console.ReadLine();
            int number = Convert.ToInt32(meetod);

            if (number == 1)
            {
                maja();
            }

            static void maja()
            {
                int i, j, r;

                Console.Write("\n");
                Console.Write("-----------------------------------");
                Console.Write("\n");

                Console.Write("Sisesta suurus: ");
                r = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i <= r; i++)
                {
                    for (j = 1; j <= r - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\n");
                    {
                    }
                }

                for (int row = 1; row <= r; row++)
                {
                    for (int column = 1; column <= r * 2; column++)
                    {
                        string mark;
                        if (row == column || row + column <= r + 1)
                        {
                            mark = "*";
                        }
                        else
                        {
                            mark = "*";
                        }
                        Console.Write(mark);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}