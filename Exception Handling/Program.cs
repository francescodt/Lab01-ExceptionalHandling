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

        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");
            int userEntry = Convert.ToInt32(Console.ReadLine());
            int[] sumArray = new int[userEntry];

            int[] userArray = Populate(sumArray);

            int sum = GetSum(sumArray);

            //GetProduct();

            //GetQuotient();

            Console.WriteLine("The sum is {0}", sum);
            Console.WriteLine("Goodbye.");
        }

        public static int[] Populate(int[] userEntry)
        {

            for (int i = 0; i < userEntry.Length; i++)
            {
                Console.WriteLine("Please select and enter {0} numbers.", userEntry.Length);
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
                Console.WriteLine("You should enter a sum that is greater2 than 20, not {0}", sum);
            }

            return sum;

        }

        //static int GetProduct(int[]);
        //{

        //}

        //static double GetQuotient(int);
        //{
        
        //}
    }
}
