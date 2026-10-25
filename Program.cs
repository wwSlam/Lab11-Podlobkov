// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 6767;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// System.Console.WriteLine(found ? "Студент найден" : "Стундент не найден");


// int variant = 17;
// bool isPrime = true;

// for (int divisor = 2; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }
// System.Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной"); // задание 2


// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 }; // задание 3
// int sum = 0;
// int total = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         total += 1;
//         continue;
//     }
//     sum += points;
// }
// System.Console.WriteLine($"Сумма баллов за сданные работы {sum}");
// System.Console.WriteLine($"{total}");


int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            hasDuplicates = true;
            System.Console.WriteLine($"{ groupIds[i]}, {groupIds[j]}");
            break;
        }
    }
}
System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны"); // задание 4

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;


// for (int day = 1; day <= days; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             System.Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }       

// if (!found)
// {
//     System.Console.WriteLine("Свободных слотов нет"); // задание 5
// }


// System.Console.WriteLine();       //самостоятельные задания
// System.Console.WriteLine("Задание А");  

// int[] massiv = { 134, 34, 777, 666, 67, 52 };
// int chislo = 777;
// bool flag = false;
// int index = -1; 

// for (int i = 0; i < massiv.Length; i++)
// {
//     if (massiv[i] == chislo)
//     {
//         flag = true;
//         index = i;
//         break;
//     }
// };
// if (flag)
// {
//     System.Console.WriteLine($"Число найдено, индекс {index}");
// }
// else
// {
//     System.Console.WriteLine($"Числа нет");
// }


// System.Console.WriteLine();
// System.Console.WriteLine("задание Б");

// Console.Write("Введите число: ");
// int gag = int.Parse(Console.ReadLine());

// bool Flag = true;

// if (gag < 2)
// {
//     Flag = false;
// }
// else
// {
//     for (int i = 2; i <= Math.Sqrt(gag); i++)
//     {
//         if (gag % i == 0)
//         {
//             Flag = false;
//             break;
//         }
//     }
// }

// if (Flag)
// {
//     Console.WriteLine($"Число {gag} является простым.");
// }
// else
// {
//     Console.WriteLine($"Число {gag} не является простым.");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// System.Console.WriteLine();
// System.Console.WriteLine("Задание 2");

// while (true) 
// {
//     Console.Write("Введите число (чтобы остановить введите 0): ");
//     int number = int.Parse(Console.ReadLine());

//     if (number == 0)
//     {
//         break; 
//     }

//     bool isPrime = true;

//     if (number < 2)
//     {
//         isPrime = false; 
//     }
//     else
//     {
//         for (int i = 2; i <= Math.Sqrt(number); i++)
//         {
//             if (number % i == 0)
//             {
//                 isPrime = false; 
//                 break;           
//             }
//         }
//     }

//     if (isPrime)
//     {
//         Console.WriteLine($"Число {number} — простое.");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} — НЕ простое.");
//     }
// }


// System.Console.WriteLine();
// System.Console.WriteLine("Задание 10");

// int porog = 100;
// int a = 1;
// int b = 1;
// int sochran = a;

// while (true)
// {
//     if (sochran > porog)
//     {
//         break;
//     }
//     sochran = a + b;
//     a = b;
//     b = sochran;
// }
// System.Console.WriteLine(sochran);

