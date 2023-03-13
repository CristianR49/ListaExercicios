namespace ListaExercicios.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular o IMC");
                Console.Write("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                double imc = peso / (altura * altura);
                if(imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                if(18.5 < imc && imc < 25)
                {
                    Console.WriteLine("Peso normal");
                }
                if (25 < imc && imc < 30)
                {
                    Console.WriteLine("Acima do peso");
                }
                if (30 < imc)
                {
                    Console.WriteLine("Obeso");
                }
                Console.ReadLine();
            }
        }
    }
}