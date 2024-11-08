public class PatikaflixSeries{
    public string SeriesName { get; set; }
    public int ProductionYear { get; set;}
    public string Type { get; set; }
    public int YearOfPublication { get; set; }
    public string Directors { get; set; }
    public string Platform { get; set; }

    public PatikaflixSeries(string seriesName, int productionYear, string type, int yearOfPublication, string directors, string platform)
    {
        SeriesName = seriesName;
        ProductionYear = productionYear;
        Type = type;
        YearOfPublication = yearOfPublication;
        Directors = directors;
        Platform = platform;
    }
    public PatikaflixSeries()
    {
        PatikaSeries = new List<PatikaflixSeries>();
    }

    public List<PatikaflixSeries> PatikaSeries { get; set; }
    public void AddSeries(List<PatikaflixSeries> series){
        PatikaSeries.AddRange(series);
    }
}

public class FilteredSeries
{
    public string SeriesName { get; set; }
    public string Type { get; set; }
    public string Directors { get; set; }

    public FilteredSeries(string seriesName, string type, string directors)
    {
        SeriesName = seriesName;
        Type = type;
        Directors = directors;
    }
}