using System;
using ScreenSound.Model;

namespace ScreenSound
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Criando instância da banda e adicionando avaliação
                Band band = new Band("The Beatles");
                band.AddAlbum(new Album("Abbey Road"));
                band.AddRating(new Rating(9, "Reviewer 1"));
                band.AddRating(new Rating(8, "Reviewer 2"));
                band.DisplayBandInfo();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
