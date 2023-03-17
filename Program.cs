Console.WriteLine("Stampo l'array");
var ArrayInteri = new[] { 2, 6, 7, 5, 3, 9 };
printArray(ArrayInteri);

void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}
//Funzione che mi stampa un array di numeri interi
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
Console.WriteLine("Stampo il numero elevato al quadrato");
var numeroAlQuadrato = QuadratoArray(2);
Console.WriteLine(numeroAlQuadrato);

int QuadratoArray(int number)
{
    return number * number;
     
}




//Funzione che dato un array di numeri interi restituisce un nuovo array con i numeri al quadrato
Console.WriteLine("Stampo l'array con i numeri elevati al quadrato");
var arrayAlQuadrato = ElevaArrayAlQuadrato(ArrayInteri);
printArray(arrayAlQuadrato);

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] secondArray = (int[]) array.Clone();
    for (int i = 0;i < secondArray.Length; i++)
    {
      secondArray[i] = QuadratoArray(secondArray[i]);
    }
    return secondArray;
}
