internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("o que deseja fazer: ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtraçao");
        Console.WriteLine("3 - divisao");
        Console.WriteLine("4 - multiplicaçao");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("----------");
        Console.WriteLine("selecione uma opçao:");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;


        }


    }
    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        float resultado = v1 + v2;
        Console.WriteLine("o resultado da soma é: " + resultado);
        //Console.WriteLine(resultado);
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        float resultado = v1 - v2;
        Console.WriteLine($"o resultado da subtraçao é: {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        float resultado = v1 / v2;
        Console.WriteLine($"o resultado da divisao é :{resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        float resultado = v1 * v2;
        Console.WriteLine($"o resultado da multiplicaçao é :{resultado}");
        Console.ReadKey();
        Menu();
    }
}