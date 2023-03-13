namespace ListaExercicios.Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular o volume de uma caixa retangular");
                Console.Write("Comprimento: ");
                int comprimento = Convert.ToInt32(Console.ReadLine());
                Console.Write("Largura: ");
                int largura = Convert.ToInt32(Console.ReadLine());
                Console.Write("Altura: ");
                int altura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("O volume é:" + comprimento * largura * altura);
                Console.ReadLine();
            }
        }
    }
}