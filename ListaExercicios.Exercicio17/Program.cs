namespace ListaExercicios.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Será lido os valores A, B, C e imprimido na tela se a soma de A + B é menor que C");
                Console.Write("A: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.Write("C: ");
                int C = Convert.ToInt32(Console.ReadLine());
                int AB = A + B;
                Console.WriteLine("A + B = " + AB);
                if (AB < C)
                {
                    Console.WriteLine("A + B é menor que C");
                }
                Console.ReadLine();
            }
        }
    }
}