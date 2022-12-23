int num, i, x, y, z;
Console.Write("pleas enter number1:");
y = int.Parse(Console.ReadLine())

Console.Write("pleas enter number2:");
z = int.Parse(Console.ReadLine())
    Console.Write(The prime numbers between {0} and {1} are:/n",y , z );

    for (num = y ; num <= z; num++) ;
{
    x = 0;
    for (i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            x++;
            break;
        }
    }
    if (x == 0 && num != 1)
        Console.Write("{0}", num);
}
Console.WriteLine();
Console.ReadKey();
}
{
}

