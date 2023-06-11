// Скрипников Сергей 17 вариант

        Console.Write("Введите количество элементов: ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент: ");
            array[i] = double.Parse(Console.ReadLine());
        }
        double min = array[0];
        double max = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        double sum = min + max;
        Console.WriteLine($"Сумма минимального ({min}) и максимального ({max}) элементов равна {sum}.");
  