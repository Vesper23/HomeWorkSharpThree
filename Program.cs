//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
int reverse(int num, int acc)
{
    while (num > 0) 
    { 
        acc = acc * 10 + num % 10; num /= 10; 
    }
    return acc;
}

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine((num == 0) || (reverse(num, 0) == num));
Console.ReadKey(true);

*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int xA = InputNum("Введите x для A;");
int yA = InputNum("Введите y для A;");
int zA = InputNum("Введите z для A;");

int xB = InputNum("Введите x для B;");
int yB = InputNum("Введите y для B;");
int zB = InputNum("Введите z для B;");

double Root(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double res1 = Math.Pow(xB - xA, 2);
    double res2 = Math.Pow(yB - yA, 2);
    double res3 = Math.Pow(zB - zA, 2);
    double res = Math.Sqrt(res1 + res2 + res3);
    return res;
}

double distance = Root(xA, yA, zA, xB, yB, zB);
Console.WriteLine(Math.Round(distance, 2));
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

