namespace Diaryapplication
{
    internal class nullValidating
    {
        public static string ValidateStringInput(string? input)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Inmatningen kan inte vara tom. Försök igen: ");
                EntryDisplay.PostEntry();
                input = Console.ReadLine();
            }
            return input;
        }

        public static DateTime ValidateDateInput(string? input)
        {
            DateTime date;
            while (!DateTime.TryParse(input, out date))
            {
                Console.Write("Ogiltigt datumformat. Ange datumet i formatet yyyy-MM-dd HH:mm: ");
                EntryDisplay.PostEntry();
                input = Console.ReadLine();
            }
            return date;
        }

        public static int GetInt()
        {
            int intInput;

            while (!int.TryParse(Console.ReadLine(), out intInput))
            {
                Console.WriteLine("\nFelaktig inmatning!\n");
                EntryDisplay.PostEntry();
                break;
            }
            return intInput;
        }

        public static string GetString()
        {
            string? stringInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(stringInput))
            {
                Console.WriteLine("\nDu måste skriva något för att spara en anteckning!\n");
                EntryDisplay.PostEntry();

                return string.Empty;
            }
            return stringInput.Trim();      
        }
    }
}