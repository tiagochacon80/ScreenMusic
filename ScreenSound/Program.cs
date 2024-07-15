using ScreenSound;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {     

       Band queen = new Band();

       Album albumQueen = new Album("A night at the opera");
       Music music1 = new Music("Love if my life", queen, 278, true);
       Music music2 = new Music("Bohemian Rhapsody", queen, 354, false); 
       
       albumQueen.AddMusic(music1);
       albumQueen.AddMusic(music2);
       queen.AddAlbum(albumQueen);

        music1.DisplayInfo();
        music2.DisplayInfo();
        albumQueen.DisplayMusicofAlbum();
        queen.DisplayBandInfo();


    }

}
