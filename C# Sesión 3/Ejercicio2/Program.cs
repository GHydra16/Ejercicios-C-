// Leer números hasta que se digite -99. Determinar el mayor y el menor (sin contar el -99).

int numero;
int mayor;
int menor;

Console.WriteLine("Ingrese números (termine con -99):");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == -99)
{
    Console.WriteLine("No se ingresaron números.");
}
else
{
    mayor = numero;
    menor = numero;

    while (true)
    {
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == -99)
        {
            break;
        }

        if (numero > mayor)
        {
            mayor = numero;
        }

        if (numero < menor)
        {
            menor = numero;
        }
    }

    Console.WriteLine("El mayor es: " + mayor);
    Console.WriteLine("El menor es: " + menor);
}
