namespace ListaExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para verificar se um número é primo");
                Console.Write("Digite um número:");
                int numero = Convert.ToInt32(Console.ReadLine());
                int divisores = 0;
                for (int i = 1; i <= numero; i++)
                {

                    if (numero % i == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores == 2)
                {
                    Console.WriteLine(numero + " é um número primo");
                }
                else if(divisores != 2)
                {
                    Console.WriteLine(numero + " não é um número primo");
                }
                Console.ReadLine();

            }
        }
    }
}