//Использование LINQ в дейсвтиях над массивами
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQChapkin
{
    public static class Ex
    {
        public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } : elements.SelectMany((e, i) => elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
    class Program
    {
        class Worker
        {
            public string Name;
            public int Salary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Исходные массив");
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-10, 10);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            //1) Дан массив целых чисел. Сгруппировать их по четности и отсортировать по возрастанию.
            var res1 = arr.OrderBy(r => r).GroupBy(r => r % 2 == 0);
            foreach (var group in res1)
            {
                Console.WriteLine(group.Key == true ? "Чётные числа" : "Нечётные числа");
                foreach (var num in group)
                    Console.WriteLine(num);
            }
            //2) Дан массив целых чисел. Сгруппировать их по четности. Для каждой группы посчитать сумму входящих в нее элементов.Итоговая коллекция должна содержать для каждой группы поле, с суммой группы.
            var res2 = arr.OrderBy(r => r).GroupBy(r => r % 2 == 0).Select(r => new { Key = r.Key, Summary = r.Sum() });
            foreach (var an in res2)
                Console.WriteLine(an);
            //3) Дана коллекция пар {Фамилия, Сумма} - Фамилия не ключевое поле (т.е. значения в поле Фамилия повторяются в коллекции. Необходимо составить итоговую коллекцию пар:{ Фамилия, Сумма всех Сумм для данной фамилии}
            var workers = new Worker[] { new Worker { Name = "Петров", Salary = 100 }, new Worker { Name = "Сидоров", Salary = 200 }, new Worker { Name = "Петров", Salary = 130 } };
            var res3 = workers.GroupBy(r => r.Name).Select(r => new { Name = r.Key, SumSalary = r.Sum(r2 => r2.Salary) });
            foreach (var an in res3)
                Console.WriteLine(an);
            //4)Дана коллекция повторяющихя элементов. Необходимо составить новую коллекцию, в которую попадут в одном экземпляре только элементы, встречающиеся ровно три раза в исходной коллекции.
            int[] arr2 = { 1, 3, 1, 1, 4 };
            var res4 = arr2.GroupBy(r => r).Where(r => r.Count() == 3).Select(r => r.Key);
            foreach (var num in res4)
                Console.WriteLine(num);
            //5) Есть три коллекции arr1, arr2, arr3.
            //-Необходимо создать коллекцию, состоящую из всех возможных троек элементов.Каждый элемент тройки представляет собой один элемент из соответствующе коллекции.
            //-Преобразовать итоговую коллекцию в строку типа: (a1, b1, c1), (a2, b1, c1), ...
            //!!!Последнего символа запятая быть не должно:)
            Console.WriteLine();
            int[] arr3 = { 1, 2, 3, 4 };
            var res5 = arr3.DifferentCombinations(3);
            StringBuilder sb = new StringBuilder();
            string delimiter = "";
            foreach (var group in res5)
            {
                string s1 = "(" + String.Join(", ", group) + ")";
                sb.Append(delimiter);
                sb.Append(s1);
                delimiter = ", ";
                //sb.AppendLine(s1);
                //Console.WriteLine();
            }
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}