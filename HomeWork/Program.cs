// // Задача № 1

// int [] GetArray(int size, int leftRange, int rightRange)
// {
//     int [] array = new int [size];
//     Random rand = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array [i] = rand.Next(leftRange, rightRange +1);
//     }
//     return array;
// }

// int GetCount(int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 ==0)
//         {
//             count ++;
//         }
//     }
//     return count;
// }

// int [] arr = GetArray(4, 100, 999);
// System.Console.WriteLine(string.Join(", ", arr));
// System.Console.WriteLine($"Четные элементы массива = {GetCount(arr)}");

// Задача № 2

// int [] GetArray(int size, int leftRange, int rightRange)
// {
//     int [] array = new int [size];
//     Random rand = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array [i] = rand.Next(leftRange, rightRange +1);
//     }
//     return array;
// }

// int SumIndex(int [] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i=i+2)
//     {
//         sum += array [i];
//     }
//     return sum;
// }

// int [] arr = GetArray(4, 100, 999);
// System.Console.WriteLine(string.Join(", ", arr));
// System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumIndex(arr)}");

//Задача № 3

double [] GetDoubleArray(int size, int leftRange, int rightRange)
{
    double [] array = new double [size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(leftRange, rightRange +1) / 10.0;
    }
    return array;
}
double MaxMin(double[] array)
{
    double res = 0;
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    res = max - min;
    return res;
}

double [] arr = GetDoubleArray(4, 200, 999);
System.Console.WriteLine(string.Join(", ", arr));
System.Console.WriteLine($"Разница между минимальным и максимальным элементов массива = {MaxMin(arr)}");