namespace ListaExercicios.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9. Crie um programa para calcular a média harmônica das notas de um Aluno
            //Mh = n / n1x + n2x + n3x
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular a média harmonica das notas de um aluno");
                Console.WriteLine("Digite quantas notas serão inseridas: ");
                double QntNotas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite as notas");
                double notas = 0;
                for (int i = 0; i < QntNotas; i++)
                {
                    notas = notas + 1/Convert.ToDouble(Console.ReadLine());

                }
                Console.WriteLine("Média harmonica: " + Math.Round(QntNotas / notas,2));
                Console.ReadLine();
            }
        }
    }
}