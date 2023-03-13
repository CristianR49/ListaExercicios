namespace ListaExercicios.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)

        {
                Console.WriteLine("Programa: Números ímpares entre 100 e 200");
                Console.Write("Números ímpares: ");
                int n = 100;
                for (int i = 0; i < 100; i++)
                { 
                    if (n % 2 != 0)
                    {
                        Console.Write(n + " ");
                    }
                    n++;
                }
        }
    }
}