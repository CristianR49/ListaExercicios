namespace ListaExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa para contar quantos dias de vida uma pessoa possui");
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(nome +", você tem " + idade * 365 + " dias de vida");
                Console.ReadLine();
            }
        }
    }
}