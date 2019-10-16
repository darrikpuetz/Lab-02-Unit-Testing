using System;

namespace Lab_02_Unit_Testing
{
    public class Program
    {
        /// <summary>
        /// Creates the Menu for the bank app. Uses the user input to select the number in the user case. That choice drives the next method. 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
            double balance = 10000;
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
                        double subBalance = Convert.ToInt32(Console.ReadLine());

                        balance = WithDraw(balance, subBalance);
                        break;
                    case 3:
                        Console.WriteLine($"Feed me the money! How much?");
                        double depBalance = Convert.ToInt32(Console.ReadLine());
                        balance = Deposit(balance, depBalance);
                        break;
                    default:
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }

            }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is finished.");
            }

        }
        /// <summary>
        /// Uses the amount of the users input to subtract from the balance. Creates an new int that is compared back to the balance. If it is negative it gets sent an error.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double WithDraw(double balance, double input)
        {
            try
            {
                if (input > balance)
                {
                    Console.WriteLine($"Easy there pal. {input} is more than the {balance} you have.");
                    return balance;
                }
                else
                {
                    double subBalance = balance - input;
                    Console.WriteLine($"Your new sub balance is {subBalance}");
                    return subBalance;
                }

            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
                return balance;
            }
        }
        /// <summary>
        /// Takes the input of the user and adds to the balance. 
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double Deposit(double balance, double input)
        {
            try
            {
            double newBalance = balance + input;
            Console.WriteLine($"Your new balance is {newBalance}");
            return newBalance;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }

}
