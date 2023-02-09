Console.WriteLine ("Bem vindo ao programa que vai calcular o sua dedução de imposto de renda na folha");
Console.WriteLine ("Digite o valor do seu salário:");
double salario=double.Parse(Console.ReadLine());

if (salario<=900)

{
double alicota=0;
        Console.WriteLine("O seu salário é R$ "+salario+ " e o seu desconto em folha é você é isento de imposto");

}
    else if (salario<=1500)
    {
        double alicota=(0.05 * salario);
        Console.WriteLine("O seu salário é R$ "+salario+ " e o seu desconto em folha é de R$ "+alicota);
    }
        else if (salario<=2500)
        {
            double alicota= (0.1 * salario);
            Console.WriteLine("O seu salário é R$ "+salario+ " e o seu desconto em folha é de R$ "+alicota);

        }
            else if (salario>2500)
            {
                double alicota= (0.2 * salario);
                Console.WriteLine("O seu salário é R$ "+salario+ " e o seu desconto em folha é de R$ "+alicota);

            }
