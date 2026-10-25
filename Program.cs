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


// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             System.Console.WriteLine($"{ groupIds[i]}, {groupIds[j]}");
//             break;
//         }
//     }
// }
// System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");
