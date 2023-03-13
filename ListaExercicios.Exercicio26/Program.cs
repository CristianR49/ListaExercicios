namespace ListaExercicios.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa: Fatorial de um número A");
                Console.Write("Digite o número: ");
                int A = Convert.ToInt32(Console.ReadLine());
                int A2 = A;
                string FatorialInteira = A + "! = " + A;
                int Fatorial = A;
                for (int i = 1; i < A2; i++)
                {
                    A--;
                    Fatorial = Fatorial * A;
                    FatorialInteira = FatorialInteira + " X " + A;

                    if (i == A2 - 1)
                    {
                        FatorialInteira = FatorialInteira + " = " + Fatorial;
                    }

                }
                Console.WriteLine(FatorialInteira);
                Console.ReadLine();
            }
        }
    }
}



