// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите математическое выражение:");

try
{
    string str = Console.ReadLine();
    char[] ops = { '+', '-', '*', '/' };//массив по которому ищем мат-й знак
    string[] st_nums = str.Split(ops).ToArray();//убирает знаки из массива
    double n1 = Convert.ToDouble(st_nums[0]);//преобразует из строки в цифры первое число

    double n2 = Convert.ToDouble(st_nums[1]);//преобразует из строки в цифры второе число
    char op = str[st_nums[0].Length];//выбирает знак



    OperationType operationType = new OperationType();

    if (op == '+') operationType = OperationType.Plus;
    if (op == '-') operationType = OperationType.Minus;
    if (op == '*') operationType = OperationType.Multiply;
    if (op == '/') operationType = OperationType.Devide;

    double result = 0;

    switch (operationType)
    {
        case OperationType.Plus: result = Plus(n1, n2); break;
        case OperationType.Minus: result = Minus(n1, n2); break;
        case OperationType.Multiply: result = Multiply(n1, n2); break;
        case OperationType.Devide: result = Devide(n1, n2); break;
    }


    Console.WriteLine("Результат: " + result);
    Console.ReadLine();   //пауза при закрытииa
}

catch
{
    Console.WriteLine("Не введен арифметический знак");
}


static double Plus(double n1, double n2)
{
    return n1 + n2;
}


static double Minus(double n1, double n2)
{
    return n1 - n2;
}


static double Multiply(double n1, double n2)
{
    return n1 * n2;
}


static double Devide(double n1, double n2)
{
    return n1 / n2;
}

enum OperationType
{
    Plus,
    Minus,
    Multiply,
    Devide
}

