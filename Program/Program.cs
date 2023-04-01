string[] GenerateArray()
{
    System.Console.WriteLine("Пожалуйста заполните массив.");
    string[] arr = new string[8];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine("Введите новый элемент массива и нажмите Enter.");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.WriteLine(arr[^1]);
}

string[] NewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) count++;
    }
    string[] newArr = new string[count];

    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) 
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}

string[] myArray = GenerateArray();
System.Console.WriteLine("Массив из введённых вами строк: ");
PrintArray(myArray);
string[] newArray = NewArray(myArray);
System.Console.WriteLine("Массив из строк, длинна которых меньше либо равна трём: ");
PrintArray(newArray);