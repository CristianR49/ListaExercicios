namespace ListaExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para converter graus Celsius para Fahrenheit ");
                Console.Write("Digite a temperatura em Celsius: ");
                double Cel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Round((Cel * 1.8) + 32) + "°F");
                Console.ReadLine();
            }
        }
    }
}