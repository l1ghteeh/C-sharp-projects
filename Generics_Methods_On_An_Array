//Реализация действий над массивами с использованием Generics типов
 namespace dz82
{
    class array
    {
        public void massivegeneration()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);//Заполняем случайными числами диапозоном от -10 до 10
                Console.WriteLine("Элемент " + i + " = " + arr[i]);
            }
            GenericsMethod<int[]>.arr = arr;
        }    
    }

    class GenericsMethod<P>
    {
        public static int[]? arr;
        public void Swapgeneration<T>()
        {
            Console.WriteLine("Введите номера элементов, которые хотите заменить");
            int i1, i2;
            string i;
            i = Console.ReadLine();
            i1 = (int) Convert.ToInt32(i);
            i = Console.ReadLine();
            i2 =(int) Convert.ToInt32(i);
            Swap<int>(ref i1, ref i2);
        }

        public void Swap<T>(ref int i1, ref int i2)
        {
            (arr[i2], arr[i1]) = (arr[i1], arr[i2]);
            for (int i = 0; i < arr.Length; i++)
            Console.WriteLine("Элемент " + i + " = " + arr[i]);
        }

        public void MaxValue<T>()
        {
            int maxValue = arr.Max();
            Console.WriteLine("\nМаксимальное значение массива = " + maxValue + "\n");
        }

        public void MinValue<T>()
        {
            int minValue = arr.Min();
            Console.WriteLine("Максимальное значение массива = " + minValue + "\n");
        }

        public void Summ<T>()
        {
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
                summ = summ + arr[i];
            Console.WriteLine("Сумма всех элементов массива = " + summ +"\n");
        }

        public void BubbleSort<T>()
        {
            int swapper;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        swapper = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swapper;
                    }
                }
            }
            Console.WriteLine("Отсортированный пузырьком массив:");
            for (int i = 0; i < arr.Length; i++)
            Console.WriteLine("Элемент " + i + " = " + arr[i]);
        }
    }

    class Vision
    {
        static void Main()
        {
            array array = new array();
            array.massivegeneration();
            GenericsMethod<int[]> generics = new GenericsMethod<int[]>();
            generics.Swapgeneration<int>();
            generics.MaxValue<int>();
            generics.MinValue<int>();
            generics.Summ<int>();
            generics.BubbleSort<int[]>();
        }
    }
}

