//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int IntInput(string intName)
{
    int num;
    Console.Write($"Введите {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ошибка!!!");
    }
    return  num;
}

int NumbersMore0(int m)
{
    int num = 0;  
    for(int i=1; i <= m; i++)
    {
        if(IntInput($"{i} число") > 0)
        {
            num++;
        }
    }

    return num;
}

int callArg = IntInput("какое количество чисел хотите ввесть");

int more0;
more0 = NumbersMore0(callArg);
Console.WriteLine();
Console.WriteLine( $"Вы ввели {more0} число(ел) больше нуля");