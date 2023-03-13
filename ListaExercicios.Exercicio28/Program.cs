namespace ListaExercicios.Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa: FizzBuzz");
            int M3 = 3;
            int M5 = 5;
            
            for (int i = 1; i <= 100; i++)
            {
                if(i == M3 && i == M5)
                {
                    Console.Write("FizzBuzz ");
                    M3 = M3 + 3;
                    M5 = M5 + 5;
                }
                else if (i == M3)
                {
                    Console.Write("Fizz ");
                    M3 = M3 + 3;
                }
                else if (i == M5)
                {
                    Console.Write("Buzz ");
                    M5 = M5 + 5;
                }
                else
                {
                    Console.Write(i + " ");
                    
                }
                
                
            }
            Console.ReadLine();
        }
    }
}