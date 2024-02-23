using System.Data;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {

        WriteLine();
        WriteLine("List of commands");
        WriteLine("1 – command have array with: [“Hello”, “2”, “world”, “:-)”]");
        WriteLine("2 – command have array with: [“1234”, “1567”, “-2”, “computer science”]");
        WriteLine("3 – command have array with: [“Russia”, “Denmark”, “Kazan”]");
        WriteLine();


        int com;
        string[] array = new string[] { };

        Write("Enter command: ");
        com = Convert.ToInt16(ReadLine());

    }
}