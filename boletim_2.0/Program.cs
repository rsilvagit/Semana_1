Console.WriteLine("Informe o nome do aluno:");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de notas que serão utilizadas para compor a média:");
            int qtdNotas = int.Parse(Console.ReadLine());
/* variavel qtdNotas= entrada quantidade de notas*/

            double[] notas = new double[qtdNotas];
/*criação array notas e inserção no array da variavel qtdNotas*/
            double somaNotas = 0;
/*variavel que irá recebr a soma das notas*/
            for (int i = 0; i < qtdNotas; i++)
            {
                Console.WriteLine($"Informe a nota {i + 1}:");
                notas[i] = double.Parse(Console.ReadLine());
                somaNotas += notas[i];
            }
/*estrutura for para obter as notas do aluno , usando como base o valor da variavel qtdNotas para determinar quantas vezes o loop vai ocorrer*/
            double media = somaNotas / qtdNotas;
            string resultado;
/*estrutura if para definição de aprovação ou naõ do aluno com base na média*/

            if (media >= 6)
            {
                resultado = "Aprovado";
            }
            else if (media >= 5 && media < 6)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }

            Console.WriteLine("Aluno: " + nomeAluno);
            for (int i = 0; i < qtdNotas; i++)
            {
                Console.WriteLine($"N{i + 1}: {notas[i]}");
            }
            Console.WriteLine($"Média: {media:0.00} - {resultado}");
