namespace Diaryapplication
{
    internal class DiaryChoices
    {
        private Dictionary<DateTime, DiaryEntry> _entriesByDate = new Dictionary<DateTime, DiaryEntry>();

        public DiaryChoices()
        {
            _entriesByDate = FileManager.LoadEntries();
        }

        public void AddEntry()
        {
            EntryDisplay.PreEntry();

            Console.Write("Ange anteckningens innehåll: ");
            string? content = Console.ReadLine();
            if (string.IsNullOrEmpty(content))
            {
                Console.WriteLine("Innehållet får inte vara tomt.");
                //EntryDisplay.PostEntry();
                return;
            }
            var entry = new DiaryEntry(DateTime.Now, content);
            _entriesByDate[entry.Date] = entry;
            Console.WriteLine("Anteckning tillagd.");

            EntryDisplay.PostEntry();
        }

        public void ListEntries()
        {
            EntryDisplay.PreEntry();

            if (_entriesByDate.Count == 0)
            {
                Console.WriteLine("Inga anteckningar hittade.");
                return;
            }
            foreach (var entry in _entriesByDate.Values.OrderBy(e => e.Date))
            {
                Console.WriteLine(entry);
            }
            EntryDisplay.PostEntry();
        }

        public void SearchByDate()
        {
            EntryDisplay.PreEntry();

            Console.Write("Ange datum (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime searchDate))
            {
                var results = _entriesByDate.Values.Where(e => e.Date.Date == searchDate.Date).ToList();
                if (results.Count == 0)
                {
                    Console.WriteLine("Inga anteckningar hittades för det angivna datumet.");
                }
                else
                {
                    foreach (var entry in results)
                    {
                        Console.WriteLine(entry);
                    }
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt datumformat.");
            }
            EntryDisplay.PostEntry();
        }

        public void SaveEntries()
        {     
            FileManager.SaveEntries(_entriesByDate);
        }

        public void LoadEntries()
        {
            _entriesByDate = FileManager.LoadEntries();
        }
    }
}