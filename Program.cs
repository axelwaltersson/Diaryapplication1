namespace Diaryapplication;

class DiaryEntry
    {
    public DateTime Date { get; set; }
    public string Content { get; set; }
    
    public override string ToString()
    {
        return $"{Date:yyyy-MM-dd HH:MM} - {Content}";
    }
}

class Program
{
    static List<DiaryEntry> diaryEntries = new List<DiaryEntry>();
    const string filePath = "diary.txt";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Dagboksappen");
            Console.WriteLine("1. Lägg till en anteckning");
            Console.WriteLine("2. Lista anteckningar ");
            Console.WriteLine("3. Uppdatera anteckning");
            Console.WriteLine("4. Sök anteckning");
            Console.WriteLine("5. Ta bort anteckning");
            Console.WriteLine("6. Spara anteckning till fil");
            Console.WriteLine("7. Ladda upp anteckning från fil");
            Console.WriteLine("8. Avsluta");
            Console.Write("Välj ett val: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NewEntry();
                    break;
                case "2":
                    ListEntries();
                    break;
                case "3":
                    UpdateEntries();
                    break;
                case "4":
                    SearchEntries();
                    break;
                case "5":
                    DeleteEntry();
                    return;
                case "6":
                    SaveToFile();
                    return;
                case "7":
                    LoadFromFile();
                    return;
                case "8":
                    Console.WriteLine("Avslutar programmet.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
}
