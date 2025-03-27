namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("looping");

            for (int i = 1; i <= 3; i++) // for loop
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; i++) // for loop
            {
                Console.WriteLine(i);
            }
            //----------------------------------------------------------------------------------


            int j = 3;
            while (j <= 5)     // while loop
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 5;        // while loop
            while (k < 9)
            {
                Console.WriteLine(k);
                k++;
            }
            //---------------------------------------------------------------------------------


            int m = 0;     // do while loop
            do
            {
                Console.WriteLine(m);
                m++;
            }
            while (m <= 4);

            int f = 1;          // do while loop
            do
            {
                Console.WriteLine(f);
                f++;
            }
            while (f < 6);
        
        }
    }
}
