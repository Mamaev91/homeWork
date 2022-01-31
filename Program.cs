string[] myArray = { "UAE", "France", "SAR", "Russia" };

string[] Array(string[] arr, int argument)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= argument)
        {
            index++;
        }
    }
    string[] newArray = new string[index];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= argument)
        {
            newArray[count] = arr[i];
            count++;
        }
    }
    return newArray;
}

string[] secondArray = Array(myArray, 3);

void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}" + " ");
    }
}
PrintArray(secondArray);