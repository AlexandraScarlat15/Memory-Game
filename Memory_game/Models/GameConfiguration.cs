using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_game.Models
{
    public static class GameConfiguration
    {
        //Default game configurations

        public static int Rows { get; set; } = 4;
        public static int Columns { get; set; } = 4;
        public static int TimeLimitSeconds { get; set; } = 60;
        public static string SelectedCategory { get; set; } = "Vikings";
        public static string SelectedCategoryName { get; set; } = "Vikings";

        public static List<string> SelectedImages { get; set; } = new List<string>
        {
            "Images/Axel.png", "Images/Shield.png", "Images/Crest.png",
            "Images/Sword.png", "Images/Fork.png", "Images/Rope.png",
            "Images/Chest.png", "Images/Lamp.png"
        };

        public static User CurrentUser { get; set; }

    }
}
