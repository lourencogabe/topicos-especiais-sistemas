/*Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens:
 se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso*/

int idade;

Console.WriteLine("##-----------MAIORIDADE----------##\n");
Console.WriteLine("|----------------------------------|");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|   Verifica em qual idade está!   |");
Console.ResetColor();
Console.WriteLine("|----------------------------------|\n");
Console.WriteLine("\n-Informe a idade: ");
idade = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

if(idade <= 13){
    Console.WriteLine("-\nVocê é uma criança!\n");
}else if(idade > 13 && idade <=18){
    Console.WriteLine("\n-Você é um adolescente!\n");
}else if(idade > 18 && idade <= 60 ){
    Console.WriteLine("\n-Você é um Adulto!\n");
}else{
    Console.WriteLine("\n-Você é um idoso!\n");
}

Console.ResetColor();