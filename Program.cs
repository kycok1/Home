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
// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;

// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }
// Console.WriteLine("A в степени B равно: " + step);


//Task 27
// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

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

//task 34
// Console.WriteLine ("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] Array= GetArray(length, min, max);
// Console.WriteLine($"[{string.Join(", ", Array)}]");
// FindEven(Array);

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     Random rnd= new Random();
//     int[] result= new int[size];
//     for(int i= 0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue+ 1);
//     }
//     return result;
//     }
//     void FindEven(int[] MyArray)
//     {
//         int even=0;
//         for(int i= 0; i < MyArray.Length; i++)
//      {
//         if(MyArray[i]%2==0)
//         {
//             even=even+1;
//             }
//     }
// Console.WriteLine($"Чётных чисел {even}");
//  }
    
//task 36
// Console.WriteLine ("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] Array = GetArray(length, min, max);
// Console.WriteLine($"[{string.Join(", ", Array)}]");
// FindOdd(Array);

// int[] GetArray( int size, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[] result = new int[size];
//     for(int i = 0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// void FindOdd(int[] MyArray)
// {
//     int odd = 0;
//     for (int i =1; i < MyArray.Length; i = i +2)
//     {
//         odd = odd + MyArray[i];
//     }
//     Console.WriteLine($"Сумма чисел на нечётных позициях {odd}");
// }

// task 38     Я не понимаю суть проблемы, делал как предыдущие задания
// Console.WriteLine ("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] Array = GetArray(length, min, max);
// Console.WriteLine($"[{string.Join(", ", Array)}]");
// FindDifference( Array, max, min);
// int[] GetArray(int size, int minValue, int maxValue);
// {
//     Random rnd = new Random();
//     int[] result = new int[size];
//     for(int i = 0; i< result.Length; i ++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// void FindDifference(int[] MyArray, int minVal, maxval)
// {
//     for(int i =0; i < MyArray.Length; i ++)
//     {
//         if (MyArray[i] < minVal)
//         {
//             minVal = MyArray[1];
//         }
//         if (MyArray[i]> maxVal)
//         {
//             maxval = MyArray[i];
//         }
//     }
//     Console.WriteLine($"Разница {maxVal - minVal}");
// }

// task 41
// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }

// task 43
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");