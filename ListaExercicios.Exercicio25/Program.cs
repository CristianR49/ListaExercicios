namespace ListaExercicios.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa: tabuada");
                Console.Write("Digite um número de 1 a 10 e será mostrado a sua tabuada: ");
                int N = Convert.ToInt32(Console.ReadLine());
                if (N < 1 || N > 10)
                {
                    Console.WriteLine("Número inválido");
                    Console.ReadLine();
                    continue;
                }
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i + " x " + N + " = " + i * N);
                }

                Console.ReadLine();
            }
        }
    }
}