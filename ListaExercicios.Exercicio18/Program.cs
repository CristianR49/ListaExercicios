namespace ListaExercicios.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programa: Será lido 3 numeros inteiros e diferentes e serão mostrados em ordem decrescente");
                Console.Write("Digite o primeiro número: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o terceiro número: ");
                int n3 = Convert.ToInt32(Console.ReadLine());

                string sn1 = Convert.ToString(n1);
                string sn2 = Convert.ToString(n2);
                string sn3 = Convert.ToString(n3);

                string ultimo = "0";
                string meio = "0";
                string primeiro = "0";


                if (n1 > n2 && n2 > n3)
                {
                    primeiro = sn1;
                    meio = sn2;
                    ultimo = sn3;
                }
                if (n1 > n3 && n3 > n2)
                {
                    primeiro = sn1;
                    meio = sn3;
                    ultimo = sn2;
                }

                if (n2 > n1 && n1 > n3)
                {
                    primeiro = sn2;
                    meio = sn1;
                    ultimo = sn3;
                }
                if (n2 > n3 && n3 > n1)
                {
                    primeiro = sn2;
                    meio = sn3;
                    ultimo = sn1;
                }

                if (n3 > n1 && n1 > n2)
                {
                    primeiro = sn3;
                    meio = sn1;
                    ultimo = sn2;
                }
                if (n3 > n2 && n2 > n1)
                {
                    primeiro = sn3;
                    meio = sn2;
                    ultimo = sn1;
                }
                Console.WriteLine(primeiro + " " + meio + " " + ultimo);
                Console.ReadLine();
            }
        }
    }
}
