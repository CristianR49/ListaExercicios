namespace ListaExercicios.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para informar se um número é par ou ímpar");
                Console.Write("Digite o número:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Par");
                }
                else
                {
                    Console.WriteLine("Ímpar");
                }
                
                Console.ReadLine();
            }

        }
    }
}