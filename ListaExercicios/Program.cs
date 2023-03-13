namespace ListaExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa da padaria Hotpão");
                Console.Write("Quantos pães franceses foram comprados? ");
                double paes = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantas broas foram compradas? ");
                double broas = Convert.ToDouble(Console.ReadLine());
                double paesEbroas = (paes * 0.12) + (broas * 1.5);
                Console.WriteLine("A venda de pães e broas resultou em R$" + paesEbroas + " e foram guardados R$" + paesEbroas / 10 + " para a poupança");
                Console.ReadLine();
            }

        }
    }
}