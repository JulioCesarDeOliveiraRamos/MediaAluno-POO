namespace MediaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Media geral dos alunos ###";

            Console.WriteLine("Quantos alunos?");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("aluno #" + (i + 1) + "nome: ");
                string nome = Console.ReadLine();
                Console.Write("aluno #" + (i + 1) + "Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("inserir as notas do aluno " + nome);
                alunos[i].inserirNotas();

            }
            Console.Clear() ;
            double MediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("aluno: " + aluno.Nome);
                Console.WriteLine("media: " + aluno.media);
                Console.WriteLine() ;

                MediaGeral += aluno.media;
            }

            double ResultadoFinal = MediaGeral / alunos.Length;

            Console.WriteLine("media geral dos alunos: " + ResultadoFinal);
            Console.ReadLine();
        }
    }
}