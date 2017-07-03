using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUMP_RPGProjekt.Controllers;

namespace DUMP_RPGProjekt.Models
{
    public class Enemy
    {
        public _EnemyNames Name;
        public int Age;
        public _EnemyRaces Race;
        public int Level;

        public int Strength;
        public int Endurance;
        public int Intelligence;
        public int Willpower;
        public int Agility;
        public int Speed;
        public int Luck;

        //public int MaxHealth;
        public int Health;  //kasnije u bliskoj ili dalekoj buducnosti implementiraj da enemies mogu koristit consumeables
        //public int ExperienceForNextLevel; //takoder implementiraj da ako je player pobjeden, enemy dobije exp i moze levelUp-at
        //public int Experience;
        //public int MaxMana;
        public int Mana;

        public bool HasAssignedQuest;

        public override string ToString()
        {
            return $"{Name} the {Race}\nLevel: {Level}\nHealth: {Health}";
        }
    }

    public enum _EnemyRaces {Goblin = 1, Golem, Leviathan, Harpy, Hydra, Minotaur, Dragon, Ork, Centaur, Wolf, Undead}
    public enum _EnemyNames { Grolt = 1, Marakat, Haar, Kongor, Yver, Ughod, Grubfoot, Bentoze, Wartface, Agadaar, Orkan, Elvarg, Tonole, Durzag, Firnen}
}
