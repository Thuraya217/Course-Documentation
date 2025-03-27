namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional statements ( if else / switch case )");

            //int i = 100;
            //if (i > 50)
            //{
            //    Console.WriteLine("good");
            //}

            //else;
            //{
            //    Console.WriteLine("bad");
            //}

            int num = 10;
            if (num > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negative Number");
            }
        }
    }
}
