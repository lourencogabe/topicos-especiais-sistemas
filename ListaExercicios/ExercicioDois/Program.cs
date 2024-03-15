// Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:
// 1. Dólar (1 dólar = 5,17 reais)
// 2. Euro (1 euro = 6,14 reais)
// 3. Peso argentino (1 peso argentino = 0,05 reais)s

double dolar = 5.17;
double euro = 6.14;
double pesoArgentino = 0.05;
double real;
double valorConvertido;
int moeda;

Console.WriteLine("##----CONVERSOR DE MOEDA----##\n");
Console.WriteLine("|-----------------------------|");
Console.WriteLine("| Opção 1 - Dolar             |");
Console.WriteLine("| Opção 2 - Euro              |");
Console.WriteLine("| Opção 3 - Peso Argentino    |");
Console.WriteLine("|-----------------------------|\n");
Console.WriteLine("-Informe a opção da moeda: ");
moeda = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n-Informe o valor em real: ");
real = Convert.ToDouble(Console.ReadLine());

switch (moeda)
{
    case 1:
        valorConvertido = real / dolar;
        Console.WriteLine("\n-Valor convertido em Dolar: " + valorConvertido.ToString("C") + "\n");
        break; 
    case 2:
        valorConvertido = real / euro;
        Console.WriteLine("\n-Valor convertido em Euro: " + valorConvertido.ToString("C") + "\n");
        break;
    case 3:
        valorConvertido = real / pesoArgentino;
        Console.WriteLine("\n-Valor convertido em Peso Argentino: " + valorConvertido.ToString("C") + "\n");
        break;
    default:
        Console.WriteLine("\n-Até logo!");
        break;
}