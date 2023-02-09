Console.WriteLine("Ex 6 -  Tabuada");
Console.Write("Digite o número a ser multiplicado: ");
int numero = int.Parse (Console.ReadLine());
    for (int i = 0; i <=10; i++)
    {
        Console.WriteLine(numero + " x " + i + " = " + (numero * i));
    }
/*Utilizei a estrutura for para repetir a operação de multiplicação usando u numero fornecido pelo usuário e multiplicando ele pela variável de controle atéo o momento em que ela fosse igual a 10*/
