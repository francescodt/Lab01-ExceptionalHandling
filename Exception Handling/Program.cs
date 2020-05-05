using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hey you did ", ex.Message + ". Let's not do that again.");
            }
            finally
            {
                Console.WriteLine("The Program is complete. Goodbye.");
            }
        }

        public static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");
            int userEntry = Convert.ToInt32(Console.ReadLine());
            int[] sumArray = new int[userEntry];

            int[] userArray = Populate(sumArray);

            int sum = GetSum(sumArray);

            int product = GetProduct(sumArray, sum);

            decimal quotient = GetQuotient(product);

            Console.WriteLine("The sum of the array is {0}", sum);
            Console.WriteLine("The product of the numbers you did is {0}", product);
            //Console.WriteLine("{0} / {1} = {2}", product, dividend, quotient);
        }

        public static int[] Populate(int[] userEntry)
        {

            for (int i = 0; i < userEntry.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i+1} of {userEntry.Length} entries.");
                string numberUserSelected = Console.ReadLine();
                int arrayNumber = int.Parse(numberUserSelected);
                userEntry[i] = arrayNumber;
            }

            for (int j = 0; j < userEntry.Length; j++)
            {
                Console.WriteLine("You entered {0}", userEntry[j]);
            }

            return userEntry;
        }

        public static int GetSum(int[] sumArray)
        {
            int sum = 0;

            for (int i = 0; i < sumArray.Length; i++)
            {
                sum += sumArray[i];
            }

            if(sum < 20)
            {
                Console.WriteLine("You should enter a sum that is greater than 20, not {0}", sum);
            }

            return sum;

        }

        public static int GetProduct(int[] sumArray, int sum)
        {
            int product = 0;
            int userProduct = sumArray.Length;
            
            try
            {
                Console.WriteLine("Please choose a number between 1 and {0}", userProduct);
                string userSelection = Console.ReadLine();
                int selectedNumber = int.Parse(userSelection);
                
                product = sum * selectedNumber;
            }
            catch (Exception idxoor)
            {
                Console.WriteLine("Index is out of range {0}", idxoor.Message);
                throw;
            }
            return product;
        }

        static decimal GetQuotient(int product)
        {
        
            int dividend = 0;
            
            try
            {
                Console.WriteLine("Please enter a number to divide your product {0} from above by.", product);
                int userEntryDividend = int.Parse(Console.ReadLine());
            }
            catch (DivideByZeroException dbze)
            {
                if (dividend == 0)
                {
                    Console.WriteLine("Bad. No.", dbze.Message);
                }
            }
            decimal quotient = product / dividend;
            return quotient;

        }
    }
}
