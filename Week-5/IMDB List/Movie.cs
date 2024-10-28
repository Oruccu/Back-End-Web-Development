public class Movie
{
    public string name { get; set; }
    public double IMDBScore { get; set; }

    public Movie(string name, double IMDBScore){
        this.name = name;
        this.IMDBScore = IMDBScore;
    }
    public void PrintInfo(){
        Console.WriteLine(name + " " + IMDBScore);
    }
}