// // task 24
// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToDouble(Console.Read());
// Console.WriteLine((1 + n) / 2 * n);

// task 26
//  Console.Clear();
//  Console.Write("Введите число: ");
//  int n = Convert.ToInt32(Console.ReadLine()), count = 1;
//  while (n / 10 != 0)
//  {
//     n /= 10;
//     count ++;
//  }
//  Console.Write(count);

// task 28
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 1;
// for (int i = 2; i <= n; i++);
//     count = count * i;
 
// Console.WriteLine($"Результат: {count}");

// task 30
// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2);
// Console.WriteLine(string.Join(", ", array));

// // ДЗ
// // task 25
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);


//Task 27
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

//task 29 

// int [] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
//  {
//  numbers [i] = new Random().Next(0, 11);
//  Console.Write(" " + Method (i) + " ");
//  }
// Console.Write("]");

// int Method (int a)
// {
//  return numbers[a];
// }



