namespace ListaExercicios.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular o volume de um cilindro");
                Console.Write("Digite o Raio: ");
                double Raio = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a altura: ");
                double Altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Volume:" + 3.14 * (Raio*Raio) * Altura);
                Console.ReadLine();
            }
        }
    }
}