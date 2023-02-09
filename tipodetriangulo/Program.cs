// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ex 5 - Tipo do triângulo");

Console.WriteLine("Digite a medida do primeiro lado");
int lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do segundo lado");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do terceiro lado");
int lado3 = int.Parse(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("As medidas informadas formam um triangulo Equilátero"); 
    }
        else if (lado1 == lado2 || lado2==lado3 || lado3 == lado1)
        {
            Console.WriteLine("As medidas informadas formam um triângulo isósceles"); 
        }
            else
            {
                Console.WriteLine("As medidas informadas formam um triângulo escaleno"); 
            }
               
}

 else
 {
    Console.WriteLine("Os valores não formam um triângulo");
 }  
 
   