// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

{
    Console.Write("Введите три числа:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int d = Convert.ToInt32(Console.ReadLine());


    if ((a > b) && (a > d))
    {
        Console.WriteLine("{0} наибольшее число", a);
    }

    if ((b > a) && (b > d))
    {
        Console.WriteLine("{0} наибольшее число", b);
    }

    if ((d > a) && (d > b))

    {
        Console.WriteLine("{0} наибольшее число", d);
    }

      Console.ReadLine();
}
