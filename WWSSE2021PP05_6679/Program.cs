/*
    Napisz program, który pyta użytkownika o podanie liczby całkowitej a w wyniku wypisuje 
    komunikat o tym czy wprowadzona liczba jest lub nie jest liczbą pierwszą.
*/


// Liczba pierwsza to taka liczba naturalna, która ma dokładnie dwa dzielniki naturalne: jedynkę i samą siebie.

static bool IsPrime(int n)
{
    if (n % 2 == 0)
        return (n == 2);
    for (int i = 3; i <= Math.Sqrt(n); i += 2)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Podaj jakąś liczbę całkowitą: ");
int number = int.Parse(Console.ReadLine());

if (IsPrime(number))
{
    Console.WriteLine("Liczba {0} należy do zbioru liczb pierwszych.", number);
}
else
{
    Console.WriteLine("Liczba {0} nie należy do zbioru liczb pierwszych.", number);
}
