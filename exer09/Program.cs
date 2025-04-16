
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a idade da pessoa: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("A pessoa é maior de idade.");
        }
        else
        {
            Console.WriteLine("A pessoa é menor de idade.");
        }
    }
}

