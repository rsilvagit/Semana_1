
Console.WriteLine ("Digite a nota do primeiro trimestre:");
float nota1 = float.Parse (Console.ReadLine());
Console.WriteLine ("Digite a nota do segundo trimestre:");
float nota2= float.Parse (Console.ReadLine());
Console.WriteLine ("Digite a nota do terceiro trimestre:");
float nota3= float.Parse (Console.ReadLine());
float resultado=((nota1+nota2+nota3)/3);

    if (resultado>=6)
    {
    Console.WriteLine ("Aluno aprovado com nota: "+resultado);
    }   
     if (resultado<=4)
        {
        Console.WriteLine ("Aluno reprovado com nota: "+resultado);
        }
        if (resultado==5)
            {        
            Console.WriteLine ("Aluno em recuperação com nota: "+resultado);
            }
