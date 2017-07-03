using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_RPGProjekt.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Age;
        public _Race Race;
        public int Level;
        //public int Money

        public int Strength;
        public int Endurance;
        public int Intelligence;
        public int Willpower;
        public int Agility;
        public int Speed;
        public int Luck;

        public int MaxHealth;
        public int Health;
        public int ExperienceForNextLevel;
        public int Experience;
        public int MaxMana;
        public int Mana;

        public bool IsAlive;

        public override string ToString()
        {
            return $"{Name} the {Race}\nLevel: {Level}\nHealth: {Health} / {MaxHealth}";
        }
    }

    public enum _Race { Red_Dragon = 1, Blue_Dragon, Green_Dragon, Gold_Dragon, Silver_Dragon, Black_Dragon, White_Dragon, Bronze_Dragon}
}
