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

 Console.Write("Массив строк: [");
        for (int i = 0; i < num; i++)
        {
            Console.Write(array[i]+ ",");
 
        }
Console.Write("]");

// Распечатываем массив из символов меньше 3

 Console.WriteLine("Новый массив строк: [");
        for (int j = 0; j < num; j++)
        {
            Console.Write(newArray[j]+ ",");
 
        }
Console.Write("]");

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

string[] GetNewArray(string[] array)
{
    string[] res = new string[size];
    for (int i = 0; i < num; i++)
    {
        if (array[i].Length <= 3)
        {
            for (int j = 0; j < size; j++)
            {
                res[j] = array[i];
            }


        }
    }
    return res;
}