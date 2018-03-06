using System;

namespace BinarySearch
{
    class Program
    {
        public static int BinarySearch(int[] array, int value)

        {
            if (array.Length == 0 || value < array[0] || value > array[array.Length - 1])
            {
                return -1;
            }

            var indFirst = 0;
            var indLast = array.Length - 1;

            while ((indFirst < indLast) & array[indFirst] != value & array[indLast] != value)
            {
                var indMiddle = indFirst + (indLast - indFirst) / 2;

                if (value >= array[indMiddle])
                {
                    indFirst = indMiddle;
                }
                else
                {
                    indLast = indMiddle;
                }
            }

            if (array[indFirst] == value)
            {
                return indFirst;
            }
            else if (array[indLast] == value)
            {
                return indLast;
            }
            else
            {
                return -1;
            }
        }


        static void Main(string[] args)
        {
            TestNonExistentElement();
            TestNegativeNumbers();
            TestArrayOfFiveElements();
            TestEmptyArray();
            TestRepeatingValue();
            TestSearchBigArray();

            Console.ReadKey();
        }

        /// <summary>
        /// Тестирование поиска в отрицательных числах
        /// </summary>
        private static void TestNegativeNumbers()
        {

            int[] negativeNumbers = new[] {-5, -4, -3, -2};

            Array.Sort(negativeNumbers);

            if (BinarySearch(negativeNumbers, -3) != 2)

                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        /// <summary>
        /// Тестирование поиска отсутствующего элемента
        /// </summary>
        private static void TestNonExistentElement()
        {            
            int[] negativeNumbers = new[] {-5, -4, -3, -2};

            Array.Sort(negativeNumbers);
                     
            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("!Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат");
        }

        /// <summary>
        /// Тестирование поиска в массиве из пяти элементов
        /// </summary>
        private static void TestArrayOfFiveElements()
        {
                       
            int[] fiveElements = new[] { 0, 4, 88, 90, 100};

            Array.Sort(fiveElements);

            if (BinarySearch(fiveElements, 90) == 3)

                Console.WriteLine("Поиск среди массива из пяти элементов вернул корректный результат");
            
            else

                Console.WriteLine("! Поиск не нашёл число 90 среди чисел { 0, 4, 88, 90, 100}");

        }
        
        /// <summary>
        /// Тест поиска в пустом массиве
        /// </summary>
        private static void TestEmptyArray()
        {
            int[] emptyArray = new int[] { };

            if (BinarySearch(emptyArray, 1) >= 0)
            {
                Console.WriteLine("!Поиск нашёл ", 1, " в пустом массиве");
            }
            else
            {
                Console.WriteLine("Поиск в пустом массиве работает корректно");
            }
        }

        /// <summary>
        /// Тест поиска повторяющегося значения
        /// </summary>
        private static void TestRepeatingValue()
        {
            int[] repeatingValue = new[] { 0, 1, 3, 3, 3, 4 };

            Array.Sort(repeatingValue);

            if (BinarySearch(repeatingValue, 3) == -1)
            {
                Console.WriteLine("!Поиск повторяющегося элемента работает некорректно");
            }
            else
            {
                Console.WriteLine("Поиск повторяющегося элемента работает корректно");
            }
        }

        /// <summary>
        /// Тест поиска в большом массиве
        /// </summary>
        private static void TestSearchBigArray()
        {
            Random random = new Random();

            int[] bigArray = new int[100001];

            for (int i = 0; i<100001; i++)
            {
                bigArray[i] = random.Next();
            }

            var value = bigArray[0];

            Array.Sort(bigArray);

            if (BinarySearch(bigArray, value) == -1)
            {
                Console.WriteLine("!Поиск в большом массиве работает не корректно");
            }
            else
            {
                Console.WriteLine("Поиск в большом массиве работает корректно");
            }
        }
    }
}