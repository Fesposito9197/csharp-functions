
printArray(new[] { 2, 6, 7, 5, 3, 9 });

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
