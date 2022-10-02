/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
 Console.WriteLine("Задайте значения M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
if (m>n)
for (int i = m; i <= n; i++){
    sum = sum + 1;
}
    
 Console.WriteLine("Cумма натуральных элементов");
 Console.WriteLine(sum);
