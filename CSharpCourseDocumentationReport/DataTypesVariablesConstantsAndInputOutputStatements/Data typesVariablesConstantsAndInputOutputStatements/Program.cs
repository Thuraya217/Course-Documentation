namespace DataTypesVariablesConstantsAndInputOutputStatements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data Type");
        int number1;
        int number2;

        Console.WriteLine("Enter the first Number");
        int number1= int.parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int number2 = int.parse(Console.ReadLine());

        result = number1 - number2;
        Console.WriteLine(result);
    }
}
