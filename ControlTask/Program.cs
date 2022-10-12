

string[] textArray = { "hi", "hello", "123", ":-)", "w0rld", "two", "10000", "конь", "стул", "28" };// получаемый массив


string SortElementsInCurrentArray(string[] array, int placeOfelement, int numOfSymbolsInElement) // сортировка элементов массива по длинне
{
    string element = string.Empty;

    if (array[placeOfelement].Length <= numOfSymbolsInElement)
    {
        element = array[placeOfelement];
    }
    return element; 
}


string[] CreateNewArrayFromCurrentArray(string[] array, int numOfSymbolsIElement) // Метод создающий нговый массив
{
    string[] resArray = { };
    int iteration = 0;
    int elementPlace = 0;
    string element = string.Empty;
    while (iteration <= array.Length - 1)
    {
        element = SortElementsInCurrentArray(array, iteration, numOfSymbolsIElement);
        if (element != string.Empty)
        {
            Array.Resize(ref resArray, resArray.Length + 1);
            resArray[elementPlace] = element;
            elementPlace++;
        }
        iteration++;
    }
    return resArray;
}

void PrintArr(string[] array)  // метод распечатывабющиймассив
{
    if (array.Length > 0)
    {
        System.Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write(array[i] + ",");
        }
        System.Console.Write(array[array.Length - 1]);
        System.Console.Write("]");
    }
    else System.Console.WriteLine("нечего распечатывать"); 
}


System.Console.WriteLine("* * *");
PrintArr(textArray);
System.Console.Write("--->");
PrintArr(CreateNewArrayFromCurrentArray(textArray, 3));
System.Console.WriteLine("");
System.Console.WriteLine("* * *");



