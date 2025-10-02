namespace Diaryapplication;

class DiaryEntry
{
    public DateTime Date { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return $"{Date:yyyy-MM-dd} - {Content}";
    }

    public DiaryEntry(DateTime date, string content)
    {
        Date = date;
        Content = content;
    }
}