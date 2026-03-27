using System.Collections;

ArrayList aList = new ArrayList();

int num = default;

while (num >= 0)
{
    Console.Write("Introduzca un número (Para terminar un número negativo): ");
    num = int.Parse(Console.ReadLine()!);
    if (num >= 0)
        aList.Add(num);
}

int mayor = int.MinValue, menor = int.MaxValue, media = 0, totalNums = aList.Count;

foreach (int i in aList)
{
    if (i > mayor)
    {
        mayor = i;
    }

    if (i < menor)
    {
        menor = i;
    }

    media += i;
}

media /= totalNums;

Console.WriteLine($"Total de numeros: {totalNums}");
Console.WriteLine($"Media: {media}");
Console.WriteLine($"El mayor número: {mayor}");
Console.WriteLine($"El menor número: {menor}");