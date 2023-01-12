namespace M2Igjen
{
    internal class MyConsole
    {
        public static void WriteBox(string text = "Hallo", int borderThickness = 1)
        {
            Console.WriteLine(string.Empty.PadLeft(text.Length+4, '*'));
            Console.WriteLine("* " + text + " *");
            Console.WriteLine(string.Empty.PadLeft(text.Length+4, '*'));
        }

        public static void WriteBox(double number)
        {
            WriteBox(number.ToString());
        }

        //public static void WriteBox()
        //{
        //    WriteBox("Hallo");
        //}

    }
}
