using ScreenSound;

class Program
{
    static void Main(string[] args)
    {     

        Album albunofQueen = new Album();
        albunofQueen.Name = "A night at the opera";

        Console.WriteLine();
        Music music1 = new Music("Roxane", "The Police", 273, true);
        music1.DisplayInfo();
        music1.SetIsAvailable(false);

        Music music2 = new Music("Bohemian Rhapsody", "Queen", 289, true);

        albunofQueen.AddMusic(music2);

        albunofQueen.DisplayMusicofAlbum();

    }

}
