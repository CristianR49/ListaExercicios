namespace ListaExercicios.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para processar os valores A e B");
                Console.Write("A: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("B: ");
                int B = Convert.ToInt32(Console.ReadLine());
                int C;
                if (A == B)
                {
                    C = A + B;
                }
                else
                {
                    C = A * B;
                }
                Console.WriteLine("C: " + C);
                Console.ReadLine();
            }
        }
    }
}