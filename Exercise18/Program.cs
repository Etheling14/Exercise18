int n = 0;
int c = 0;

Console.Write("tell if the chosen number is prime or not?? ");
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
else
{
    Console.WriteLine("The number is prime");
}
