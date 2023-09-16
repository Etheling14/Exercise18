int number = 2, divisible = 0;
int n = 0;
int c = 0;

do
{
    Console.Write("Up to what number do you want to print prime numbers and say whether the chosen number is part or not?? ");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < (n + 1); i++)
    {
        if (n % i == 0)
        {
            c++;
        }
    }
    if (c != 2)
    {
        Console.WriteLine("The number is not prime");
    }

    int finalNumber = int.Parse(Console.ReadLine());
    while (number <= finalNumber)
    {
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                divisible++;
            }
            if (divisible > 2)
            {
                break;
            }
        }
        if (divisible == 2)
        {
            Console.Write("{0,10:N0} is prime", number);
        }
        divisible = 0;
        number++;

    }
    Console.ReadKey();
}while (true);