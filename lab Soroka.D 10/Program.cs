//Сложность Сложная Вариант 1

char[] array = Console.ReadLine().ToCharArray();

bool isPalindrome = IsPalindrome(array);

if (isPalindrome)
{
    Console.WriteLine("Массив является палиндромом.");
}
else
{
    Console.WriteLine("Массив не является палиндромом.");
}
static bool IsPalindrome(char[] array)
{
    int length = array.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (array[i] != array[length - 1 - i])
        {
            return false;
        }
    }

    return true;
}