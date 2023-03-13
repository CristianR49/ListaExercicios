namespace ListaExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para converter Fahrenheit em graus Celsius");
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double Fahr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Round((Fahr-32)/1.8,1) + "°C");
                Console.ReadLine();
            }
        }
    }
}