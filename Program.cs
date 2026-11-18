// int[] marks = { 1, 2, 3, 4, 5 };
// int[] numbers = new int[5];
// Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс", };
// for (int i = 6; i >= 0; i--)
// {
//     Console.WriteLine($"{i + 1}: {days[i]}");
// }
// Console.WriteLine("");
// // Задание 1.2
// double[] temps = { 10.5, 23.1, 17.0, 22.9, 21.4, 10.6, -1.1 };
// foreach (double temp in temps)
// {
//     Console.Write($"{temp}C ");
// }
// Console.WriteLine("");
// // Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int msum = 0;
// foreach (int price in prices)
// {
//     sum += price;
// }
// foreach (int price in prices)
// {
//     if (price > 100)
//     {
//         msum += 1;
//     }
// }
// Console.WriteLine($"общая сумма цен: {sum}");
// Console.WriteLine($"средняя цена: {(double)sum / prices.Length}");
// Console.WriteLine($"товаров с ценой больше 100: {msum}");
// Console.WriteLine("");
// int max = prices[0];
// int min = prices[0];
// int index = 0;
// for (int i = 1; i < prices.Length; i++){
//     if (prices[i] < min){
//         min = prices[i];
//     }
//     if (prices[i] > max){
//         max = prices[i];
//     }
// }
// for (int i = 1; i < prices.Length; i++){
//     if (prices[i] == max){
//         index = i;
//     }
// }
// Console.WriteLine($"Минимальная цена:{min}, индекс элемента с максимальной ценой {index}");
// Console.WriteLine("");
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++){
//     if (balance[i] < 0){
//         balance[i] = 0;
//     }
// }
// foreach (int n in balance){
//     Console.Write(n + " ");
// }
// Задание 5
// int[] ex4 = new int[5];
// int ex4r = 0;
// for (int i = 0; i < 5; i++){
//     ex4[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < ex4.Length; i++){
//     if (ex4[i]%2 == 0){
//         ex4r += 1;
//     }
// }
// Console.WriteLine("");
// for (int i = 4; i >= 0; i--){
//     Console.WriteLine($"{ex4[i]}");
// }
// Console.WriteLine($"четных чисел: {ex4r}");
// Console.WriteLine("");
 // Задание 6
string[] names = { "Анна", "Игорь",
"Мария", "Олег", "Ольга" };
string ex5 = Console.ReadLine();
int ex5r = 0;
int ex5rr = 0;
for (int i = 0; i < names.Length; i++){
    if (names[i] == ex5){
        ex5r = i;
    }
    else {
        ex5rr +=1;
    }
}
if (ex5rr == 5){
    Console.WriteLine("Не найдено");
}
else{
    Console.WriteLine(ex5r+1);
}