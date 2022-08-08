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
