using System;
using ScreenSound.Model;

namespace ScreenSound.Menus
{
    internal class MenuRegisterBand : Menu
    {
        public MenuRegisterBand(List<Band> bands) : base(bands) { }
        public override void Execute()
        {
            Console.Clear();
            Console.WriteLine("Enter the band name: ");
            string name = Console.ReadLine();
            bands.Add(new Band(name));
            Console.WriteLine($"Band '{name}' registered. Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
    
}
