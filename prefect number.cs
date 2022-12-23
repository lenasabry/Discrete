using System;
//{ 
  int n1, n2;
    Console.WriteLine("Enter First Number: ");
    n1 = int.Parse(Console.ReadLine());
   
    Console.WriteLine("Enter Second Number: ");
    n2 = int.Parse(Console.ReadLine());
    for (int i = n1; i <= n2; i++)
    {
        //int x = 2;
        if (i % 2 == 2)
        {

            Console.WriteLine(i + " is a perfect number");
            Console.WriteLine();
        }


    }

    int n3, n4;
    Console.WriteLine("Enter First Number: ");
    n3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Second Number: ");
    n4 = int.Parse(Console.ReadLine());

    for (int i = n3; i <= n4; i++)
    {
       
        {
            Console.WriteLine(i + " is a prefect number");
            Console.WriteLine();
        }
    }
    Console.ReadKey();

    