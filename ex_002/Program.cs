
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int sum = GetSumNumber(num);
Console.WriteLine($"Сумма цифр в числе {num} -> {sum} ");

int GetNumberFromUser(string message, string errorMessage)
{    
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }    
}

int GetSumNumber(int number)
{
    int i = 0;
    int summ = 0;
    int advantage = 0;
    while(num > 0)
    {
        advantage = num - num % 10;
        summ = summ + (num - advantage);
        num = num / 10;   
        i++;
    }
    return summ;
}