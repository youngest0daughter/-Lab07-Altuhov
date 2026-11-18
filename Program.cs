// int[] marks = { 1, 2, 3, 4, 5 };
// int[] numbers = new int[5];
// Задание 1.1
string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс", };
for (int i = 6; i >= 0; i--)
{
    Console.WriteLine($"{i + 1}: {days[i]}");
}
Console.WriteLine("");
// Задание 1.2
double[] temps = { 10.5, 23.1, 17.0, 22.9, 21.4, 10.6, -1.1 };
foreach (double temp in temps)
{
    Console.Write($"{temp}C ");
}
Console.WriteLine("");
// Задание 2
int[] prices = { 120, 45, 300, 80, 15, 210 };
int sum = 0;
int msum = 0;
foreach (int price in prices)
{
    sum += price;
}
foreach (int price in prices)
{
    if (price > 100)
    {
        msum += 1;
    }
}
Console.WriteLine($"общая сумма цен: {sum}");
Console.WriteLine($"средняя цена: {(double)sum / prices.Length}");
Console.WriteLine($"товаров с ценой больше 100: {msum}");