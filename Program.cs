//var ArrayInteri = new[] { 2, 6, 7, 5, 3, 9 };


Console.WriteLine("Inserisci la lunghezza dell'array");
int n = Convert.ToInt32(Console.ReadLine());

int[] ArrayInteri2 = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Inserisci il {i + 1} numero");
    ArrayInteri2[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Stampo l'array");
printArray(ArrayInteri2);

//Funzione che mi stampa un array di numeri interi
void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}
string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}




//Funzione che prende un numero e lo eleva al quadrato
//Console.WriteLine("Stampo il numero elevato al quadrato");
//var numeroAlQuadrato = QuadratoArray(2);
//Console.WriteLine(numeroAlQuadrato);

int QuadratoArray(int number)
{
    return number * number;

}




//Funzione che dato un array di numeri interi restituisce un nuovo array con i numeri al quadrat
int[] arrayAlQuadrato = ElevaArrayAlQuadrato(ArrayInteri2);
Console.WriteLine("Stampo array originale");
printArray(ArrayInteri2);
Console.WriteLine("Stampo l'array clone con i numeri elevati al quadrato");
printArray(arrayAlQuadrato);


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] secondArray = (int[])array.Clone();
    for (int i = 0; i < secondArray.Length; i++)
    {
        secondArray[i] = QuadratoArray(secondArray[i]);
    }
    return secondArray;
}

////Funzione che preso un array di numeri interi restituisce la somma totale degli elementi
Console.WriteLine("Stampo l'array con la somma totale degli elementi");
var sommaArray = sommaElementiArray(ArrayInteri2);
Console.WriteLine(sommaArray);

int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}


Console.WriteLine("Stampo la somma degli elementi dell'array dove gli elementi sono elevati al quadrato");
var sommaArrayAlQuadrato = sommaElementiArray(arrayAlQuadrato);
Console.WriteLine(sommaArrayAlQuadrato);
