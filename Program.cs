using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Salário bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());

        Funcionario f = new Funcionario(nome, salarioBruto);

        double inss = f.CalcularINSS();
        double irrf = f.CalcularIRRF();

        Console.WriteLine($"\nINSS: R$ {inss:F2}");
        Console.WriteLine($"IRRF: R$ {irrf:F2}");
    }
}
