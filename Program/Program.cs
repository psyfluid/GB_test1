string[] CreateArrayFromInput()
{
    Console.Write("Input the size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] newArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input array element {i + 1}: ");
        newArray[i] = Console.ReadLine() ?? String.Empty;
    }

    return newArray;
}

void PrintArray(string[] array)
{
    int len = array.Length;

    Console.Write("[");

    for (int i = 0; i < len; i++)
    {
        Console.Write(array[i]);
        if (i < len - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

string[] GetArrayWithStringsOfTargetLength(string[] initialArray, int targetLength = 3)
{

    int len = initialArray.Length;
    int[] maskArray = new int[len];
    int newSize = 0;

    for (int i = 0; i < len; i++)
    {
        if (initialArray[i].Length <= targetLength)
        {
            newSize++;
            maskArray[i] = 1;
        }
    }

    string[] newArray = new string[newSize];
    int j = 0;

    for (int i = 0; i < len; i++)
    {
        if (j == newSize)
            break;

        if (maskArray[i] == 1)
        {
            newArray[j] = initialArray[i];
            j++;
        }
    }

    return newArray;
}

string[] firstArray = CreateArrayFromInput();

// string[] firstArray = {"hello", "2", "world", ":-)"};
// string[] firstArray = {"1234", "1567", "-2", "computer science"};
// string[] firstArray = {"Russia", "Denmark", "Kazan"};

PrintArray(firstArray);

Console.WriteLine();
Console.Write("Input target length: ");
int targetLength = Convert.ToInt32(Console.ReadLine());

PrintArray(GetArrayWithStringsOfTargetLength(firstArray, targetLength));
