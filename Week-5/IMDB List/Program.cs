List<Movie> MovieList = new List<Movie>();

while (true)
{
    Console.Write("Lütfen film adını giriniz: ");
    string MovieName = Console.ReadLine();
    Console.Write($"{MovieName}'in IMDB Puanı giriniz: ");
    double IMDBScore = Convert.ToDouble(Console.ReadLine());

    Movie movie = new Movie(MovieName, IMDBScore);
    MovieList.Add(movie);


    Console.Write("Yeni film eklemek istiyor musun? Devam etmek için 1 tuşuna basın. Çıkmak için: 2 ");
    int result = Convert.ToInt32(Console.ReadLine());
    if (result == 2)
    {
        break;
    }
}

Console.WriteLine("Film Listeniz ");
foreach (Movie movie in MovieList)
{
    movie.PrintInfo();
}

Console.WriteLine(" Imdb puanı 4 ile 9 arasında olan bütün filmler listesi: ");
for (int i = 0; i < MovieList.Count; i++)
{
    if (MovieList[i].IMDBScore > 4 && MovieList[i].IMDBScore < 9)
    {
        MovieList[i].PrintInfo();
    }

}

Console.WriteLine(" İsmi 'A' ile başlayan filmler ve imdb puanları listesi ");
for (int i = 0; i < MovieList.Count; i++)
{
    if (MovieList[i].name.Substring(0,1) == "A")
    {
        MovieList[i].PrintInfo();
    }

}

