
Console.WriteLine("Olá!!! Vamos calcular a área do triangulo");
Console.WriteLine("Qual o tamanho da base em cm?");
float baseTriangulo = float.Parse(Console.ReadLine());
Console.WriteLine("Qual a altura cm?");
float altura = float.Parse(Console.ReadLine());
float area = ((baseTriangulo*altura)/2);
Console.WriteLine("A área do triangulo é: " +area+ " cm");
