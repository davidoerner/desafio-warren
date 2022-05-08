namespace DesafioWarrenProWay
{
    public class WarrenDesafio2
    {
        public void Desafio2()
        {
            Console.Write("Informe a quantidade de alunos na turma: ");
            int tamTurma;
            int.TryParse(Console.ReadLine(), out tamTurma);

            Console.Write("Quantos alunos devem estar presentes para a aula começar? ");
            int alunosPresentes;
            int.TryParse(Console.ReadLine(), out alunosPresentes);

            int tempoChegada;
            int atraso = 0;
            int normal = 0;

            for (int i = 0; i < tamTurma; i++)

            {
                Console.Write("Informe o tempo de chegada do aluno: ");
                int.TryParse(Console.ReadLine(), out tempoChegada);

                if (tempoChegada <= 0)
                {
                    normal++;
                }
                else
                {
                    atraso++;
                }
                if (normal >= alunosPresentes)
                    break;
            }
            if (normal >= alunosPresentes)
            {
                Console.WriteLine("Aula Normal!");
            }
            else
            {
                Console.WriteLine("Aula Cancelada!");
            }
        }
    }
}