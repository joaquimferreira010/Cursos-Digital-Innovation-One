using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            
            string opcaoUsuario = ObterOpacaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Todo: adicionar aluno
                        Console.WriteLine("Informe o nome do Aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do Aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal.");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        //Todo: listar alunos
                        foreach (var item in alunos)
                        {
                            if(item != null)
                            Console.WriteLine($"Aluno: {item.Nome} - Nota: {item.Nota}");
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        //Todo: calcular médiga geral
                        decimal notaTotal = 0;
                        decimal nrAluno = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (alunos[i] != null)
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAluno++;
                                
                            }
                           
                        }
                        var mediaGeral = notaTotal / nrAluno;
                        Console.WriteLine("Média Geral: " + mediaGeral);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpacaoUsuario();

            }
           
        }

        private static string ObterOpacaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno.");
            Console.WriteLine("2 - Listar alunos.");
            Console.WriteLine("3 - Calcular média geral.");
            Console.WriteLine("X - Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
