/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

// Запрашиваем у пользователя массив строк.

int num = GetNumberFromUser("Введите длинну массива: ", "Ошибка ввода!");
string[] array = GetArray(num);

int size = GetSize(array);

string[] newArray = GetNewArray(array);

// Распечатываем массив

Console.Write("Исходный массив строк: ");

Console.Write("[ ");
for (int i = 0; i < num; i++)
{

   array[i] = string.Format("\"{0}\"", array[i]);

    Console.Write(array[i]);

    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }

}
Console.Write(" ]");

Console.WriteLine();

// Распечатываем массив из символов меньше или равных 3

Console.Write("Новый массив строк: [ ");
for (int j = 0; j < size; j++)
{
    newArray[j] = string.Format("\"{0}\"", newArray[j]);

    Console.Write(newArray[j]);

    if (j < newArray.Length - 1)
    {
        Console.Write(", ");
    }


}
Console.Write(" ]");

// Вводим размер массива

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

// Создаем массив

string[] GetArray(int num)
{
    string[] res = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите строку для элемента {0} массива: ", i);
        res[i] = Console.ReadLine();
    }
    return res;
}

// Узнаем размер нового массива

int GetSize(string[] array)
{

    int count = 0;

    for (int i = 0; i < num; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    return count;

}

// Создаем новый массив из элементов <= 3

string[] GetNewArray(string[] array)
{
    string[] res = new string[size];

    int index = 0;

    for (int i = 0; i < num; i++)
    {
        if (array[i].Length <= 3)
        {
            res[index] = array[i];

            index++;
        }

    }
    return res;
}