//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int IntInput(string intName)
{
    int num;
    Console.Write($"Введите координаты точки {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ошибка!!!");
    }
    return  num;
}

Console.WriteLine();
double k1 = IntInput("k1");
double b1 = IntInput("b1");
double k2 = IntInput("k2");
double b2 = IntInput("b2");
double deltaK = k1-k2;
double deltaB = b1-b2;
double x = (-1)*deltaB/deltaK;
double y = k2*x + b2;
Console.WriteLine();
Console.WriteLine( $"Координаты пересечения ({b1},{k1}) и ({b2},{k2}): x = {x}, y = {y}");