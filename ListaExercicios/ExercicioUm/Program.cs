//Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.

double baseRetangulo;
double alturaRetangulo;
double resultado;

Console.WriteLine("##-----------RETANGULO----------##\n");
Console.WriteLine("|----------------------------------|");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|   Calcula a àrea do retangulo!   |");
Console.ResetColor();
Console.WriteLine("|----------------------------------|\n");
Console.WriteLine("-Base do triangulo: \n");
baseRetangulo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n-Base do triangulo: \n");
alturaRetangulo = Convert.ToDouble(Console.ReadLine());

resultado = baseRetangulo + alturaRetangulo;

Console.WriteLine("\n##-----------RESULTADO-----------##");
Console.WriteLine("\nÁREA: " + resultado);