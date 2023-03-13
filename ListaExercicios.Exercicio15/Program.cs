namespace ListaExercicios.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa: será lido uma temperatura em Celsius e imprimido em Fahrenheit");
                Console.Write("Digite a temperatura em Celsius: ");
                double Cel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Round((Cel * 1.8) + 32) + "°F");
                Console.ReadLine();
            }


        }
    }
}