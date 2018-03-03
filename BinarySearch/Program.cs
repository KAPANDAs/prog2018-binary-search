using System;

namespace BinarySearch
{
    class Program
    {
        public static int BinarySearch(int[] array, int value)

        {
            //Array.Sort(array);
            //код поиска значения value в массиве array
            if (array.Length == 0 || value < array[0] || value > array[array.Length - 1])
            {
                return -1;
            }

            var idFirst = 0;
            var idLast = array.Length;

            while (idFirst < idLast)
            {
                int idMiddle = idFirst + (idLast - idFirst) / 2;

                if (value <= array[idMiddle])
                {
                    idLast = idMiddle;
                }
                else
                {
                    idFirst = idMiddle;
                }
            }

            if (array[idLast] == value)
            {
                return idLast;
            }
            else
            {
                return -1;
            }
        }


        static void Main(string[] args)

        {
            TestNonExistentElement();
            TestArrayOfFiveElements();
            TestNegativeNumbers();
            Console.ReadKey();
        }


        private static void TestNegativeNumbers()

        {
            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] {-5, -4, -3, -2};

            if (BinarySearch(negativeNumbers, -3) != 2)

                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        private static void TestNonExistentElement()

        {
            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] {-5, -4, -3, -2};

            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");
        }

        private static void TestArrayOfFiveElements()
        {
            //Тестирование поиска в массиве из пяти элементов
            
            int[] fiveElements = new[] { 0, 4, 88, 90, 100};

            if (BinarySearch(fiveElements, 90) == 3)

                Console.WriteLine("Поиск среди массива из пяти элементов вернул корректный результат");
            
            else

                Console.WriteLine("! Поиск не нашёл число 90 среди чисел { 0, 4, 88, 90, 100}");

        }
    }
}