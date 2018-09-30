//Леонов Алексей
//* а) Реализовать класс для работы с двумерным массивом.Реализовать конструктор,
// заполняющий массив случайными числами.Создать методы, которые возвращают сумму всех
//элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее
//минимальный элемент массива, свойство, возвращающее максимальный элемент массива,
//метод, возвращающий номер максимального элемента массива(через параметры, используя
//модификатор ref или out).
//** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные
// в файл.
// ** в) Обработать возможные исключительные ситуации при работе с файлами.

using System;


namespace lesson4
{
    class Table
    {
        int[,] arr;
        public Table(int row, int col)
        {
            arr = new int[row, col];
            Random r = new Random();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк двумерного массива:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов двумерного массива:");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[Table.row, Table.col];

            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = r.Next(0, 101);
                   Console.Write($"{arr[i,j],4}");
                }
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }
    }
}
