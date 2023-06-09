Console.WriteLine("Введите номер задания, который вас интересует: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num==1)
{
    Console.WriteLine("Задание 1.");
    Console.WriteLine("Введите число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2=num/10000;
    int num3=num/1000%10;
    int num4=num/100%10;
    int num5=num/10%10;
    int num6=num%10;
    if((num2==num6)&&(num3==num5))
    {
        Console.WriteLine("Да, число являеться палиндромом");
    }
    else
    {
        Console.WriteLine("Нет, число не являеться палиндромом");
    }
}
else if(num==2)
{   
    Console.WriteLine("Задание 2.");
    Console.WriteLine("Введите X первой точки: ");
    int numX1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите У первой точки: ");
    int numY1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите X второй точки: ");
    int numX2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите У второй точки: ");
    int numY2 = Convert.ToInt32(Console.ReadLine());
    double num7= Math.Sqrt(Math.Pow((numX2-numX1),2)+Math.Pow((numY2-numY1),2));
    Console.WriteLine("Расстояния между точками: "+num7);
}
else if(num == 3)
{   
    Console.WriteLine("Задание 3.");
    Console.WriteLine("Введите число: ");
    double num8 = Convert.ToInt32(Console.ReadLine());
    double num9=1;
    double num10=0;
    while(num9!=num8+1)
    {
        num10=Math.Pow(num9,3);
        Console.Write(" "+num10);
        num9++;
    }
}
else
{
    Console.WriteLine("Такого задания нет.(1,2,3)");
}