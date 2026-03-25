int n1 = 6, n2 = 5, n3 = 6, mayor;

if (n1 > n2)
{
    mayor = n1;
    if (n3 > n1)
    {
        mayor = n3;
    }
}
else
{
    mayor = n2;
    if (n3 > n2)
    {
        mayor = n3;
    }
}

Console.WriteLine(mayor);