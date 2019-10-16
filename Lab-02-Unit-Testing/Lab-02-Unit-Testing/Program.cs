using System;

namespace Lab_02_Unit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10689;
            bool pickagain = true;
            while (pickagain)
            {
                Console.WriteLine("Welcome to the Bank of 'Merica!");
                Console.WriteLine("Please choose an option. ");
                Console.WriteLine("1) View Balance ");
                Console.WriteLine("2) Withdraw ");
                Console.WriteLine("3) Deposit ");

                Int32.TryParse(Console.ReadLine(), out int option);

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Your balance is {balance}. ");
                        break;
                    case 2:
                        Console.WriteLine("Let's get some monies! How much?");
                        int subBalance = Convert.ToInt32(Console.ReadLine());

                        balance = WithDraw(balance, subBalance);
                        break;
                    case 3:
                        Console.WriteLine($"Feed me the money! How much?");
                        int depBalance = Convert.ToInt32(Console.ReadLine());
                        balance = Deposit(balance, depBalance);
                        break;
                    default:
                        Environment.Exit(0);
                        break;


                }

            }

        }

        public static int WithDraw(int balance, int input)
        {
            int newBalance = balance - input;
            Console.WriteLine($"Your new balance is {newBalance}");
            return newBalance;
        }
        public static int Deposit(int balance, int input)
        {
            int newBalance = balance + input;
            Console.WriteLine($"Your new balance is {newBalance}");
            return newBalance;
        }

    }
}
