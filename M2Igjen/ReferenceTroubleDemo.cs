namespace M2Igjen
{
    internal class ReferenceTroubleDemo
    {
        public static void Run()
        {
            int number = 5;
            DoubleNumber(number);
            Console.WriteLine(number);


            var numbers = new int[] { 5 };
            numbers = new int[] { 1, 2, 3 };
            DoubleNumber(numbers);
            Console.WriteLine(numbers[0]);
        }

        private static void DoubleNumber(int[] numbers)
        {
            numbers[0] *= 2;
        }

        private static void DoubleNumber(int i)
        {
            i *= 2;
        }
    }
}
