namespace ListaExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular o volume de uma esfera");
                Console.Write("Digite o valor do raio:");
                double raio = Convert.ToDouble(Console.ReadLine());
                Console.Write("Volume: " + (4 * 3.14 * (raio * raio * raio)) / 3);
                Console.ReadLine();
            }
        }
    }
}