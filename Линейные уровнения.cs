// Проверка ввода чисел
int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

// Подсчет результатов
void LinearEquation ()
{
    int[] array = {0,0,0,0};
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите коэффициент {i+1}: ");
        array[i] = CorrectInput();
    }
    if (array[0] - array[2] != 0)
    {
        double result =((double) array[1] - (double) array[3]) * (-1) / ((double) array[0] - (double) array[2]);
        Console.WriteLine("Решение 2х линейных уравнений = " + result);
    }
    else
    {
        Console.WriteLine("Линии паралельны. Решения нет.");
    }
}

// Код программы
Console.WriteLine("Введите целочисленные коэффициенты 2х линейных уравнений. \n y = k1*x + b1, y = k2*x + b2.");
LinearEquation();

///////////////////////////////////////////////////////////////////
// Почему то во втором варианте не срабатывает захват исключения.//
///////////////////////////////////////////////////////////////////

/*
int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

// Подсчет результатов
void LinearEquation()
{
    try
    {
        int[] array = {0,0,0,0};
        double result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите коэффициент {i+1}: ");
            array[i] = CorrectInput();
        }
        result = ((double)array[1] - (double)array[3])*(-1)/((double)array[0] - (double)array[2]);
        Console.WriteLine("Решение 2х линейных уравнений = " + result);
    }
    catch (DivideByZeroException )
    {
        Console.WriteLine("Линии паралельны. Решения нет.");
    }
}

// Код программы
Console.WriteLine("Введите коэффициенты 2х линейных уравнений. \n y = k1*x + b1, y = k2*x + b2.");
LinearEquation();
*/