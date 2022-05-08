namespace DesafioWarrenProWay {
    public class WarrenDesafio3 {
        public void Desafio3() {
            Console.Write("Digite o valor do resultado: ");
            int soma = int.Parse(Console.ReadLine());
            List<int> vetor = new List<int>();
            int valorVetor = 0;
            do {
                Console.Write("Digite um valor para ser somado (0 para sair): ");
                valorVetor = int.Parse(Console.ReadLine());
                if (valorVetor != 0) {
                    vetor.Add(valorVetor);
                }
            }
            while (valorVetor != 0);

        }
    }
}