namespace ListaExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa imobiliária Imóbilis, será lido as dimensões de um terreno e dado a sua área");
                Console.Write("Comprimento: ");
                int compr = Convert.ToInt32(Console.ReadLine());
                Console.Write("Largura: ");
                int largura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Área: ");
                Console.WriteLine(compr * largura);
                Console.ReadLine();

            }
        }
    }
}