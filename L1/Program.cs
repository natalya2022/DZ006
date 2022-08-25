/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}


void OddsCheck(int number)              // Функция проверки корректности условий
{
    if (number > 0)
    {
        int[] myArr = ArrayInput(number);
        ArrayPrint(myArr);
        System.Console.WriteLine($"Количество положительных чисел равно {PositiveNumber(myArr)}");
    }
    else
    {
        System.Console.WriteLine("Количество не может быть отрицательным или равным нулю");
    }
}


int[] ArrayInput(int number)                    // Функция ввода массива
{
    int[] myArr = new int[number];
    int i = 0;
    while (i < number)
    {
        Console.Write("Введите число ");
        myArr[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return myArr;
}


int PositiveNumber(int[] myArr)            // Функция подсчета положительных чисел
{
    int count = 0;
    for (int i = 0; i < myArr.Length; i++)
    {
        if (myArr[i] > 0)
        {
            count++;
        }
    }
    return count;
}


void ArrayPrint(int[] myArr)                            // Функция печати массива    
{
    for (int j = 0; j < myArr.Length; j++)
    {
        System.Console.Write($"{myArr[j]}  ");
    }
}


int number = Prompt("Определите количество чисел для ввода ");  // Определяем количество элементов (М) массива
OddsCheck(number);                                 // Начинаем проверку условий

