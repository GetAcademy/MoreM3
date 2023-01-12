namespace M2Igjen
{
    internal class NullableDemo
    {

        public static int Double(int? i)
        {
            if (i == null) return 0;
            return i.Value * 2;
        }
    }
}
