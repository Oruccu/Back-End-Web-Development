class PatikafyMucis
{
    private string singerNameSurname;
    private string musicType;
    private int releaseYear;
    private string albumSales;

    public string SingerNameSurname { get { return singerNameSurname; } set { singerNameSurname = value; } }
    public string MusicType { get { return musicType;} set { musicType = value;}}
    public int ReleaseYear { get { return releaseYear;} set { releaseYear = value; } }
    public string AlbumSales { get { return albumSales;} set { albumSales = value; } }

    public List<PatikafyMucis> songList;

    public PatikafyMucis(string singerNameSurname, string musicType, int releaseYear, string albumSales)
    {
        SingerNameSurname = singerNameSurname;
        MusicType = musicType;
        ReleaseYear = releaseYear;
        AlbumSales = albumSales;
    }

    public PatikafyMucis(){
        songList = new List<PatikafyMucis>();
    }

    public void AddSong(List<PatikafyMucis> song){
        songList.AddRange(song);
    }

    public void ShowAllSongs(){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------Şarkı Listesi-------------");
        foreach(var song in songList){ 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{song.SingerNameSurname} - {song.MusicType} | Yıl: {song.ReleaseYear} | Satış: {song.AlbumSales}");
            Console.WriteLine(" ");
            Console.ResetColor();
        }
    }

}