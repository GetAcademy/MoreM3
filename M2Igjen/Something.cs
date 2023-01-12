namespace M2Igjen
{
    internal class Something
    {
        /*
         * Refactoring
         *  - innføre variabel
         *  - innføre metode
         */
        public static void Do()
        {
            var maxCharacterIndex = 255;
            var counts = new int[maxCharacterIndex];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                CountCharacters(text, counts);
                ShowCharactersAndCounts(counts);
            }
        }

        private static void ShowCharactersAndCounts(int[] counts)
        {
            for (var characterIndex = 0; characterIndex < counts.Length; characterIndex++)
            {
                var count = counts[characterIndex];
                if (count > 0)
                {
                    var character = (char) characterIndex;
                    Console.WriteLine(character + " - " + count);
                }
            }
        }

        private static void CountCharacters(string text, int[] counts)
        {
            foreach (var character in text)
            {
                var characterIndex = (int) character;
                counts[characterIndex]++;
            }
        }
    }
}
