namespace ListaExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Programa para calcular a média ponderada das duas provas de um aluno");
                Console.Write("Informe a primeira nota: ");
                int pNota = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe a segunda nota: ");
                int sNota = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A média ponderada é: " + (pNota * 10 + sNota * 10)/20);
                Console.ReadLine();
            }
        }
    }
}