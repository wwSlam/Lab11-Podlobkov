int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
int target = 6767;
bool found = false;

foreach (int number in recordBooks)
{
    if (number == target)
    {
        found = true;
        break;
    }
}
System.Console.WriteLine(found ? "Студент найден" : "Стундент не найден");


int variant = 17;
bool isPrime = true;

for (int divisor = 2; divisor < variant; divisor++)
{
    if (variant % divisor == 0)
    {
        isPrime = false;
        break;
    }
}
System.Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
