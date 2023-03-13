namespace ListaExercicios.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa: Soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500");
            int n = 0;
            int soma = 0;
            for(n = 0; n <= 500;)
            {
                if(n % 2 != 0)
                {
                    soma = soma + n;
                }
                n = n + 3;
            }
            Console.WriteLine(soma);



        }
    }
}