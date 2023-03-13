namespace ListaExercicios.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para processar um aumento e uma redução de um salário");
                Console.Write("Digite o salário: ");
                double Salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Salário inicial: " + Salario);
                double SalarioAum = Salario + (Salario / 100) * 15;
                double SalarioRed = SalarioAum - (SalarioAum / 100) * 8;
                Console.WriteLine("Aumento: " + SalarioAum);
                Console.WriteLine("Redução: " + SalarioRed);
                Console.ReadLine();

            }
        }
    }
}