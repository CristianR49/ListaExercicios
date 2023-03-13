namespace ListaExercicios.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int UltN = 1;
                int Resultado = 2;
                int Resultado2 = 2;
                string sResultado = "1 1";
                bool chegou = false;
                Console.Clear();
                Console.WriteLine("Programa Fibonacci: Dê um número, será dado a sequência de Fibonacci até esse número");
                int N = Convert.ToInt32(Console.ReadLine());
                
                while (chegou == false)
                {
                    sResultado = sResultado + " " + Resultado;
                    Resultado = UltN + Resultado;
                    UltN = Resultado2;
                    Resultado2 = Resultado;
                    if (Resultado > N)
                    {
                        sResultado = sResultado + " " + N;
                        chegou = true;
                    }
                }
                Console.WriteLine(sResultado);
                Console.ReadLine();
            }
            
        }
    }
}