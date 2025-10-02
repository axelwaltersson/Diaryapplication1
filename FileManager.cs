using System.Text.Json;

namespace Diaryapplication
{
    internal class FileManager
    {
        private const string FilePath = "../../../entries.json";

        // sparar anteckningar till fil
        public static void SaveEntries(Dictionary<DateTime, DiaryEntry> entries)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(entries.Values.ToList(), options);
                File.WriteAllText(FilePath, jsonString);
                Console.WriteLine("Anteckningar sparade till fil.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid sparande av anteckningar: {ex.Message}");
                LogError($"LoadEntries: {ex.Message}");
            }
        }

        public static Dictionary<DateTime, DiaryEntry> LoadEntries()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    return new Dictionary<DateTime, DiaryEntry>();
                }
                string jsonString = File.ReadAllText(FilePath);
                var entries = JsonSerializer.Deserialize<List<DiaryEntry>>(jsonString);

                if (entries == null)
                    return new Dictionary<DateTime, DiaryEntry>();

                // Convert List<DiaryEntry> to Dictionary<DateTime, DiaryEntry>
                return entries.ToDictionary(e => e.Date, e => e);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid inläsning av anteckningar: {ex.Message}");
                LogError($"LoadEntries: {ex.Message}");
                return new Dictionary<DateTime, DiaryEntry>();
            }

        }
            private static void LogError(string message)
            {
                string logFilePath = "error.log";
                string logMessage = $"{DateTime.Now:yyyy-MM-dd} - {message}";
                
                File.AppendAllText(logFilePath, logMessage);
            }
          
    }
}