/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*/ 

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []

void PrintArr(string[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length-1]}]");
}

string[] StringLen3(string[] arr, int n){
    string[] array;
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n) 
        {
            size += 1;
        }
    }
    size = (size != 0) ? size:1;
   
    array = new string[size];

    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            array[j] = arr[i];
            j++;
        }
    }
    return array;
}

int n = 3;
string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

Console.Write(arr3);
PrintArr(StringLen3(arr1,n));
PrintArr(StringLen3(arr2,n));
PrintArr(StringLen3(arr3,n));
