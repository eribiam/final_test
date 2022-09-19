//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreateStringArray (int arraySize)
{
    string[] resultArray = new string[arraySize];
    Console.WriteLine("Введите нужные строки: ");
    for (int i = 0; i < arraySize; i++)
    {
        resultArray[i] = Console.ReadLine();
    }
    return resultArray;
}

string[] ArrayRework (string[] initialArray)
{
    int arraySize = initialArray.GetLength(0);
    int count = 0;
    string temp = "";
    for (int i = 0; i < arraySize; i++)
    {
        temp = initialArray[i];
        if (temp.Length > 3) count++;
    }
    string[] resultArray = new string[arraySize-count];
    count = 0;
    for (int j = 0; j < arraySize; j++)
    {
        temp = initialArray[j];
        if (temp.Length <= 3)
        {
            resultArray[count] = initialArray[j];
            count++;
        }
    }
    return resultArray;
}

void PrintStringArray (string[] array)
{
    int arraySize = array.GetLength(0);
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine($"[ {array[i]} ]");
    } 
}

Console.Clear();
Console.WriteLine("Введите кол-во нужных строк: ");
int numberOfStrings = Convert.ToInt32(Console.ReadLine());
string[] stringArray = CreateStringArray(numberOfStrings);
System.Console.WriteLine("Исходный массив:");
PrintStringArray(stringArray);
stringArray = ArrayRework(stringArray);
System.Console.WriteLine("Готовый массив:");
PrintStringArray(stringArray);