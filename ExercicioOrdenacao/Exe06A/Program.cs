int[] vetor  = new int[100];
int auxiliar;

Random aleatorio = new Random();

for(int i =0; i < vetor.Length; i++ ){
    vetor[i] = aleatorio.Next(100);
}

Array.Sort(vetor);

for(int i =0; i <= vetor.Length; i++ ){
    Console.WriteLine(vetor[i] + " ");
}