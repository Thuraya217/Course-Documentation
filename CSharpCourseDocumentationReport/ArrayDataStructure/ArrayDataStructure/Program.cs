namespace ArrayDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array data structure");

            //int[] Number = new int[4];

            //Console.WriteLine("Enter 4 numbers:");

            //for (int i = 0; i < Number.Length; i++)
            //{
            //    Number[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < Number.Length; i++)
            //{
            //    Console.WriteLine(Number[i]);
            //}
            //Console.WriteLine();

            //-----------------------------------------------------------

            int[] number = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < number.Length; i++)
            {
                number [i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine();
        }
    }
}

