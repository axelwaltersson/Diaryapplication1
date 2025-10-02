namespace Diaryapplication
{
    internal class EntryDisplay
    {
        public static void PostEntry()
        {
            Console.WriteLine("Tryck på slumpad tangent för att fortsätta.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PreEntry()
        {
            Console.Clear();
            Console.WriteLine("Axels Dagboksapplikation\n");
        }
    }
}