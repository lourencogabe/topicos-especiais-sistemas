int numeroUm;
int numeroDois;

Console.WriteLine("##--------MAIOR OU MENOR--------##\n");
Console.WriteLine("|----------------------------------|");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("| Compara o maior e o menor número |");
Console.ResetColor();
Console.WriteLine("|----------------------------------|\n");
Console.WriteLine("-Informe o primeiro número: ");
numeroUm = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n-Informe o segundo número: ");
numeroDois = Convert.ToInt32(Console.ReadLine());

if (numeroUm > numeroDois){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n-O numero UM: " + numeroUm + " é maior que o número DOIS: " + numeroDois + "\n");
    Console.ResetColor();
} else if (numeroDois > numeroUm){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n-O numero DOIS: " + numeroDois + " é maior que o número UM: " + numeroUm + "\n");
    Console.ResetColor();
} else {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n-Os números são iguais!\n");
    Console.ResetColor();
}