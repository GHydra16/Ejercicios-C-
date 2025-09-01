// Suma independiente de pares e impares entre 1 y 100

int sumaPares = 0;
int sumaImpares = 0;
int i;

for (i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sumaPares = sumaPares + i;
    }
    else
    {
        sumaImpares = sumaImpares + i;
    }
}

Console.WriteLine("Suma de pares: " + sumaPares);
Console.WriteLine("Suma de impares: " + sumaImpares);
