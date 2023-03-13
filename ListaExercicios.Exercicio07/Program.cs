namespace ListaExercicios.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular o salário total de um vendedor");
                Console.WriteLine("Informe o salário por mês: ");
                int salario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o valor total das vendas: ");
                int vendas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a % da comissão: ");
                int comissao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Salário total: " + (salario + ((vendas/100) * comissao)));
                Console.ReadLine();
            }
        }
    }
}