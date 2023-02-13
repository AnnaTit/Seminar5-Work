// Seminar 5 
// Массивы
// Задача. Построить массив 12 элементов, диапазон от -9 до 9. Найти сумму отрицательных членов массива
//
// При решении задач будут использоваться 3 метода:
// 1й метод - создание, инициализация массива (генерирующие)
// 2й метод - базовый расчет (преобразующие)
// 3й метод - вывод массива (аналитические)

// int [] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] coll = new int[size];
//     for(int index = 0; index < size; index++)
//     coll[index] = new Random().Next(minValue, maxValue + 1);
// return coll;
// } 

// void ShowArray(int[]  coll)
// {
//     for(int index = 0; index < coll.Length; index++)
//         Console.Write(coll[index] + " ");
//      Console.WriteLine();
// }

// int GetSumOfNegatives(int[] coll)
// {
//     int sum = 0;
//     for (int index = 0; index < coll.Length; index++)
//     {
//         if(coll[index] < 0)
//             sum += coll[index];  // оператор += это увеличение присваивания, полная форма sum = sum + coll[index]
//     } // эти фигурные скобки можно убрать, так как для for это единый объект
//     return sum;
// }


// Console.Write("Input a length of new coll: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(length, min, max);
// ShowArray(myArray);

// int sumOfNegatives = GetSumOfNegatives(myArray);
// Console.WriteLine("Sum of negatives is: " + sumOfNegatives);


// Задачи для решения в зале
// Задача 1
// НП замены элементов массива + на - и наоборот
// Используются методы 1 и 2 
// задача решена, работает

// int [] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] coll = new int[size];
//     for(int index = 0; index < size; index++)
//     coll[index] = new Random().Next(minValue, maxValue + 1);
// return coll;
// } 

// void ShowArray(int[]  coll)
// {
//     for(int index = 0; index < coll.Length; index++)
//         Console.Write(coll[index] + " ");
//      Console.WriteLine();
// }

// int[] ChangePosNeg(int[] coll)
// {
//     for (int index = 0; index < coll.Length; index++)
//          coll[index] *=(-1);

//     return coll;
// }

// Console.Write("Input a length of new coll: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(length, min, max);
// ShowArray(myArray);

// myArray = ChangePosNeg(myArray);
// ShowArray(myArray);



// Задача 2
// Задать массив и определить присутствует ли заданное пользователем число в массиве или нет (бул, аналитический)
// Решено, работает (но цифры массива с нуля)
// void NewArray(int [] collection)
// {
//     for(int index = 0; index < collection.Length; index++)
//     {
//     Console.WriteLine("Input element "+index+" = ");
//     collection[index] = Convert.ToInt32(Console.ReadLine());
//     }
// } 

// void ShowArray(int[]  coll)
// {
//     for(int index = 0; index < coll.Length; index++)
//         Console.Write(coll[index] + " ");
//      Console.WriteLine();
// }

// bool NumberFind(int find, int[] coll)
// {
//     for(int index = 0; index < coll.Length; index++)
//         if (coll[index] == find)
//             return true;
//     return false;
// }

// int[] coll = new int[4];
// NewArray(coll);
// ShowArray(coll);
// Console.WriteLine("Input find = ");
// int find = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NumberFind(find, coll));


// Задача 3
// Задать массив из N чисел и определить кол-во элементов, значения которых лежат в отрезке от А до В
// аналитический метод
// смотреть с 1.16 (решено, работает)

void NewArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
    Console.WriteLine("Input element "+i+" = ");
    collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void ShowArray(int[]  coll)
{
    for(int index = 0; index < coll.Length; index++)
        Console.Write(coll[index] + " ");
     Console.WriteLine();
}
int Numbers(int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
        if(array[i]>=a && array[i]<=b)
        count++;
    return count;
}
int[] array = new int[6];
NewArray(array);
ShowArray(array);
Console.WriteLine("Input a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers(array, a, b));