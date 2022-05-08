namespace DesafioWarrenProWay
{
    public class WarrenDesafio3
    {
        public static int valorMin = 0;
        public static int valorAntigo = int.MaxValue;

        public void Desafio3()
        {
            Console.Write("Digite o valor que sera objeto de soma: ");
            int soma = int.Parse(Console.ReadLine());

            List<int> vetor = new List<int>();
            int valorVetor = 0;

            do
            {
                Console.Write("Digite um número inteiro para ser usado na soma (0 para sair): ");
                valorVetor = int.Parse(Console.ReadLine());

                if (valorVetor != 0)
                    vetor.Add(valorVetor);
            }
            while (valorVetor != 0);

            if (vetor.Count != 0)
            {
                var result = combinacao(vetor, soma).OrderBy(x => x.Count).ToList();

                Console.WriteLine();
                if (result.Count == 0)
                {
                    Console.WriteLine("Nenhuma combinação encontrada!");
                    return;
                }

                Console.WriteLine(soma + "\n");

                List<List<int>> minimo = result.Where(x => x.Count == valorMin).ToList();
                Console.WriteLine("Menores combinações encontradas:");

                for (int i = 0; i < minimo.Count; i++)
                    Console.Write("[" + string.Join(", ", minimo[i]) + "]");
            }
        }

        public static List<List<int>> combinacao(List<int> array, int soma)
        {
            array.Sort();

            var unico = new HashSet<int>();

            for (int i = 0; i < array.Count; i++)
            {
                if (!unico.Contains(array[i]))
                    unico.Add(array[i]);
            }

            array = unico.ToList();

            var vetor = new List<int>();
            var result = new List<List<int>>();

            procuraCombinacao(array, soma, result, vetor, 0);

            return result;
        }

        public static void procuraCombinacao(List<int> array, int soma, List<List<int>> result, List<int> vetor, int i)
        {
            if (soma < 0)
                return;

            if (soma == 0)
            {
                result.Add(new List<int>(vetor));

                if (vetor.Count < valorAntigo)
                {
                    valorMin = vetor.Count;
                    valorAntigo = valorMin;
                }

                return;
            }

            while (i < array.Count && soma - array[i] >= 0)
            {
                vetor.Add(array[i]);

                procuraCombinacao(array, soma - array[i], result, vetor, i);

                i++;

                vetor.RemoveAt(vetor.Count - 1);
            }
        }
    }
}