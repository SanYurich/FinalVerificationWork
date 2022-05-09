string[] incomingArray = { "One", "Two", "Three", "2", "54664", "+-/*>?", ".>" };

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        if (arrayToPrint[i] != "")
        {
            Console.Write($" {arrayToPrint[i]},");
        }
    }
    Console.Write("]");
}

string[] NoMoreThreeSymbolsInArray(string[] dirtyArray)
{
    string[] exitingArray = new string[dirtyArray.Length];
    for (int i = 0; i < dirtyArray.Length; i++)
    {
        string random = dirtyArray[i];
        if (random.Length <= 3)
        {
            exitingArray[i] = dirtyArray[i];
        }
        else
        {
            exitingArray[i] = "";
        }
    }
    return exitingArray;
}

PrintArray(incomingArray);
string[] showcaseArray = NoMoreThreeSymbolsInArray(incomingArray);
Console.Write(" -> ");
PrintArray(showcaseArray);