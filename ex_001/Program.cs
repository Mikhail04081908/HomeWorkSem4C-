// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int num2 = GetNumberFromUser("Введите число в которое хотите возвести ","Ошибка ввода!");
int func = GetExponentiationNumbers(num2);
Console.WriteLine($"Число {num} в степени {num2} -> {func}");

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

int GetExponentiationNumbers(int number)
{
    int i = 1;
    while(i < num2)
    {
        number = number * num;
        i++;
    }
    return number;
}