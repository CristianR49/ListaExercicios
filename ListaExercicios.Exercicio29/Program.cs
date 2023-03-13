namespace ListaExercicios.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa: Tabuada do 1 ao 10");
            int Multiplicando = 1;
            int Multiplicador = 1;
            for (int i = 0; i < 100; i++) 
            {
                Console.Write(Multiplicando + "x" + Multiplicador + " = " + (Multiplicando * Multiplicador));
                int Resultado = Multiplicando * Multiplicador;
                if(Resultado > 9 && Multiplicador == 10)
                {
                    Console.Write(" ");
                }
                else if (Resultado > 9)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("   ");
                }
                Multiplicando++;
                if(Multiplicando == 11)
                {
                    Multiplicador++;
                    Multiplicando = 1;
                    Console.Write("\n");
                }

            }
        }
    }
}