/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

// метод возвращает строку из массива int
string ArrayIntToString(int[] arr){
    string result = "[";

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}, ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    result = result + "]";

    return result;
}

// вводим исходные данные
System.Console.Write($"Сколько чисел Вы хотите ввести?: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];

// запись массива
for (int i = 0; i < m; i++)
{   
    System.Console.Write($"Введите число {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine()); 
}

// перебор массива, выясняем сколько положительных
int summ = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0){
        summ++;
    }
}
System.Console.WriteLine($"{ArrayIntToString(numbers)} -> {summ}");


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

// прямая b
double[] b = new double[2];
System.Console.Write($"Введите b1: ");
b[0] = Convert.ToDouble(Console.ReadLine());
System.Console.Write($"Введите b2: ");
b[1] = Convert.ToDouble(Console.ReadLine());

// прямая k
double[] k = new double[2];
System.Console.Write($"Введите k1: ");
k[0] = Convert.ToDouble(Console.ReadLine());
System.Console.Write($"Введите k2: ");
k[1] = Convert.ToDouble(Console.ReadLine());

// точка пересечения
double x = 0, y = 0;

// k[1] * x - k[0] * x = b[0] - b[1];
x = ( b[0] - b[1] ) / ( k[1] - k[0] );
y = k[0] * x + b[0];

System.Console.WriteLine($"b1 = {b[0]}, k1 = {k[0]}, b2 = {b[1]}, k2 = {k[1]} -> ({x}; {y})");