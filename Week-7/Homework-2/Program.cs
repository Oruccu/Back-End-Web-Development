using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

List<PatikafyMucis> createSongs = new List<PatikafyMucis>{
    new PatikafyMucis("Ajda Pekkan", "Pop", 1968, "Yaklaşık 20 Milyon"),
    new PatikafyMucis("Sezan Aksu", "Türk Halk Müziği/Pop", 1971, "Yaklaşık 10 Milyon"),
    new PatikafyMucis("Funda Arar", "Pop", 1999, "Yaklaşık 3 Milyon"),
    new PatikafyMucis("Sertab Erener", "Pop", 1994, "Yaklaşık 5 Milyon"),
    new PatikafyMucis("Sıla", "Pop", 2009, "Yaklaşık 3 Milyon"),
    new PatikafyMucis("Serdar Ortaç", "Pop", 2009, "Yaklaşık 10 Milyon"),
    new PatikafyMucis("Tarkan", "Pop", 1992, "Yaklaşık 40 Milyon"),
    new PatikafyMucis("Hande Yener", "Pop", 1999, "Yaklaşık 7 Milyon"),
    new PatikafyMucis("Hadise", "Pop", 2005, "Yaklaşık 5 Milyon"),
    new PatikafyMucis("Sezan Aksu", "Pop/Türk Halk Müziği", 1971, "Yaklaşık 10 Milyon"),
    new PatikafyMucis("Neşet Ertaş", "Türk Halk Müziği/Türk Halk Müziği", 1960, "Yaklaşık 2 Milyon")
 };

PatikafyMucis musicLibrary = new PatikafyMucis();

musicLibrary.AddSong(createSongs);

//musicLibrary.ShowAllSongs();
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar");
var sNames = from singerName in musicLibrary.songList
             where singerName.SingerNameSurname.StartsWith("S")
             select singerName;

foreach (var name in sNames)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(name.SingerNameSurname);
    Console.ResetColor();
}

Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar.");
var musicReleaseYear = from musicYear in musicLibrary.songList
                       where musicYear.ReleaseYear < 2000
                       orderby musicYear.SingerNameSurname
                       select musicYear;

foreach (var releaseYear in musicReleaseYear)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{releaseYear.SingerNameSurname} - {releaseYear.MusicType} | Yıl: {releaseYear.ReleaseYear} | Satış: {releaseYear.AlbumSales} ");
    Console.ResetColor();
}

Console.WriteLine("En çok albüm satan şarkıcı");
int ExtractSalesNumber(string albumSales)
{
    // Regex ile sayıyı bulup integer olarak döndürme
    var match = Regex.Match(albumSales, @"\d+");
    return match.Success ? int.Parse(match.Value) : 0;
}

var BestSellingSinger = from music in musicLibrary.songList
                        orderby ExtractSalesNumber(music.AlbumSales)
                        select music;

foreach (var singer in BestSellingSinger)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{singer.SingerNameSurname} - {singer.MusicType} | Yıl: {singer.ReleaseYear} | Satış: {singer.AlbumSales} ");
    Console.ResetColor();
}

Console.WriteLine("En yeni çıkış yapan şarkıcı");
var bestSinger = musicLibrary.songList
                .OrderByDescending(music => music.ReleaseYear)
                .FirstOrDefault();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"{bestSinger.SingerNameSurname} - {bestSinger.MusicType} | Yıl: {bestSinger.ReleaseYear} | Satış: {bestSinger.AlbumSales} ");
Console.ResetColor();

Console.WriteLine("En eski çıkış yapan şarkıcı");
var oldSinger = musicLibrary.songList
                .OrderBy(music => music.ReleaseYear)
                .FirstOrDefault();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"{bestSinger.SingerNameSurname} - {bestSinger.MusicType} | Yıl: {bestSinger.ReleaseYear} | Satış: {bestSinger.AlbumSales} ");
Console.ResetColor();

