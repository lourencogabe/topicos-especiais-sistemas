int[] vetor  = new int[100];
int auxiliar;

Random aleatorio = new Random();

for(int i =0; i < vetor.Length; i++ ){
    vetor[i] = aleatorio.Next(100);
}

for(int i =0; i < vetor.Length; i++ ){
    if(vetor[i] > vetor[i + 1]){
        auxiliar = vetor[i];

        vetor[i] = vetor[i+1];
        vetor[i+1] = auxiliar;
    }
}

for(int i =0; i <= vetor.Length; i++ ){
    Console.WriteLine(vetor[i] + " ");
}
