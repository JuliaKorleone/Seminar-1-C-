//Первая задача
Console.WriteLine("Введите первое число: ");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int secondnum = Convert.ToInt32(Console.ReadLine());
 
            if(firstnum > secondnum)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (firstnum < secondnum)
            {
                Console.WriteLine("Первое число меньше второго");
            }


//Вторая задача
Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
         
    if (a > b && a > c)
    {
        Console.WriteLine("Первое число является максимальным ");
    }
    else if (a > b && a < c)
    {
        Console.WriteLine("Третье число является максимальным ");
    }
    else
    {
        Console.WriteLine("Второе число является максимальным ");
    }

// Третья задача
    Console.WriteLine("Введите число: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d % 2 == 0)
            {
                Console.WriteLine("Число является четным ");
            }
    else
    {
        Console.WriteLine("Число является нечетным ");
    }