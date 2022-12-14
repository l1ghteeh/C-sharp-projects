namespace zadacha1
{

    class Array
    {
        /**public void massivegeneration()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
                Console.WriteLine("Элемент " + i + " = " + arr[i]);
            }
        }**/

        public int[] arr = new int[] { 1, 3, 5, 7, 9 };
    }

    class Sort
    {
        public void BubbleSort(int[] arr) //Сортировка пузырьком
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

        public void Sort2(int[] arr) //Сортировка вставками
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int k = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    arr[j] = k;
                    j--;
                }
            }

            // Распечатываем массив.
            Console.WriteLine("Сортировка вставками");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void ChooseSort(int[] arr)
        {
            int indx; //переменная для хранения индекса минимального элемента массива
            for (int i = 0; i < arr.Length; i++) //проходим по массиву с начала и до конца
            {
                indx = i; //считаем, что минимальный элемент имеет текущий индекс 
                for (int j = i; j < arr.Length; j++) //ищем минимальный элемент в неотсортированной части
                {
                    if (arr[j] < arr[indx])
                    {
                        indx = j; //нашли в массиве число меньше, чем intArray[indx] - запоминаем его индекс в массиве
                    }
                }
                if (arr[indx] == arr[i]) //если минимальный элемент равен текущему значению - ничего не меняем
                    continue;
                //меняем местами минимальный элемент и первый в неотсортированной части
                int temp = arr[i]; //временная переменная, чтобы не потерять значение intArray[i]
                arr[i] = arr[indx];
                arr[indx] = temp;
            }
            Console.WriteLine("Сортировка выбором");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    class UI
    {
        static void Main()
        {
            Array Array = new Array();
            Sort Sort = new Sort();
            Sort.BubbleSort(Array.arr);
            Sort.Sort2(Array.arr);
            Sort.ChooseSort(Array.arr);
        }
    }
}


