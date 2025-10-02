namespace Diaryapplication;

class Program
{
    public static void Main(string[] args)
    {
        DiaryChoices diary = new DiaryChoices();
        DiaryMenu(diary);
    }

        public static void DiaryMenu(DiaryChoices diary)
        {   
            int inputMenuChoice;

        while (true)
        {
            Console.WriteLine("Axels Dagboksapplikation\n");
            Console.WriteLine("1. Lägg till en anteckning");
            Console.WriteLine("2. Lista anteckningar ");
            Console.WriteLine("3. Sök anteckning");
            Console.WriteLine("4. Spara anteckning till fil");
            Console.WriteLine("5. Ladda upp anteckning från fil");
            Console.WriteLine("6. Avsluta");
            Console.Write("Välj ett val: ");

            inputMenuChoice = nullValidating.GetInt();

            switch (inputMenuChoice)
            {
                case 1:
                    diary.AddEntry();
                    break;
                case 2:
                    diary.ListEntries();
                    break;
                case 3:
                    diary.LoadEntries();
                    diary.SearchByDate();
                    break;
                case 4:
                    diary.SaveEntries();           
                    EntryDisplay.PostEntry();
                    break;
                case 5:
                    diary.LoadEntries();
                    Console.WriteLine("Anteckningar laddade från fil.");
                    EntryDisplay.PostEntry();
                    break;
                case 6:
                    Console.WriteLine("Avslutar programmet.");
                    return;
                default:
                    Console.WriteLine("Felaktigt val, vänligen försök igen!");
                    EntryDisplay.PostEntry();
                    break;
            }
        }
    }
}