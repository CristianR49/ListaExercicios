namespace ListaExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular o consumo de combustível por Km");
                Console.Write("Informe a quilometragem inicial:");
                double Kmi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a quilometragem final:");
                double Kmf = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe quanto de combustível foi gasto nesse percurso");
                double Combustivel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("O gasto foi de " + Math.Round(Combustivel / (Kmf - Kmi), 2) + " Litros por kilometro");
                Console.ReadLine();
            }
        }
    }
}