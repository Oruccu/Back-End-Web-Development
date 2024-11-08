Console.Write("Dizi kaydı oluşturmak ister misin? (1: Evet, 0: Hayır): ");
int result = Convert.ToInt16(Console.ReadLine());
PatikaflixSeries seriesLibrary = new PatikaflixSeries();

while (result != 0)
{
    Console.Write("Dizinin Adı: ");
    string name = Console.ReadLine();
    Console.Write("Yapım Yılı: ");
    int year = Convert.ToInt32(Console.ReadLine());
    Console.Write("Dizi Türü: ");
    string type = Console.ReadLine();
    Console.Write("Yayınlanmaya başladığı yıl: ");
    int bublication = Convert.ToInt32(Console.ReadLine());
    Console.Write("Yönetmen: ");
    string directors = Console.ReadLine();
    Console.WriteLine("Yayınlandığı kanal adı: ");
    string channelName = Console.ReadLine();

    List<PatikaflixSeries> createSeries = new List<PatikaflixSeries>
    {
        new PatikaflixSeries(name, year, type, bublication, directors, channelName)
    };
    seriesLibrary.AddSeries(createSeries);

    Console.Write("Başka bir dizi eklemek ister misiniz? (1: Evet, 0: Hayır): ");
    result = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Kayıtlı Diziler:");
foreach (var series in seriesLibrary.PatikaSeries)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Dizi Adı: {series.SeriesName}, Yapım Yılı: {series.ProductionYear}, Tür: {series.Type}, " +
                      $"Yayın Yılı: {series.YearOfPublication}, Yönetmen: {series.Directors}, Platform: {series.Platform}");
    Console.ResetColor();
}


List<FilteredSeries> comedySeries = seriesLibrary.PatikaSeries
            .Where(series => series.Type == "Komedi")
            .Select(series => new FilteredSeries(series.SeriesName, series.Type, series.Directors))
            .OrderBy(series => series.SeriesName)
            .ThenBy(series => series.Directors)
            .ToList();

// Filtrelenmiş listeyi ekrana yazdır
Console.WriteLine("Komedi Dizileri Listesi:");
foreach (var series in comedySeries)
{
    Console.WriteLine($"Dizi Adı: {series.SeriesName}, Tür: {series.Type}, Yönetmen: {series.Directors}");
}