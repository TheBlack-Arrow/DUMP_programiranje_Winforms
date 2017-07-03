using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUMP_RPGProjekt.Controllers;

namespace DUMP_RPGProjekt.Models
{
    public class Quest
    {
        public string Name;
        public _QuestLocations Location;  //implementiraj sa botunima na mapi kasnije
        public string Difficulty;
        public int ExperienceReward;
        //public int MoneyReward //implementiraj kasnije sa kupovanjem itema

        public Enemy Enemy;

        public override string ToString()
        {
            return $"{Name} \nLocation: {Location} \nDifficulty: {Difficulty} \nExperience reawrd: {ExperienceReward}";  //listbox ne moze radit newline, probaj sa textbox
        }
    }

    public enum _QuestLocations { Home = 1, Ocean, Tropical_Islands, North_Cold, Volcano, Lush_Forests, Windy_Mountains, Desert, Brackish_Waters, Cold_Sea}
}
