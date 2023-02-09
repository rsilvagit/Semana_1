// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Seja bem vindo!!!");
Console.WriteLine ("Qual o seu primeiro nome?");
string nome = Console.ReadLine();
Console.WriteLine ("Qual o seu sobrenome?");
string sobrenome = Console.ReadLine();
Console.WriteLine ("Qual a sua idade?");
int idade= int.Parse (Console.ReadLine());
Console.WriteLine ("Qual a sua cor favorita");
string cor = Console.ReadLine();
Console.WriteLine ("Segue os seus dados abaixo:"+"\r\n"+"Nome: "+nome+"\r\n"+ "Sobrenome: " +sobrenome+ "\r\n"+"Idade: "+ idade+" anos"+"\r\n"+"Cor Favorita: "+cor);