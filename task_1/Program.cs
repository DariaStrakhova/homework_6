/* // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int Numbers(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void GetNumber(int num)
{
    string listNumber = " ";
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        int numberUser = Numbers("Введите число: ");
        listNumber = listNumber + numberUser + ", ";  

        if (numberUser > 0)
        {
           count ++;
        }
    }
    Console.WriteLine($"{listNumber} количество чисел больше 0 = {count}");
}


int NumM = Numbers("Введите общее количество чисел: ");

GetNumber(NumM);

