using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUMP_RPGProjekt.Models;

namespace DUMP_RPGProjekt.Controllers
{
    public class EnemyController
    {
        private MainWIndow _form;

        public EnemyController(MainWIndow form)
        {
            _form = form;
        }

        public void NewEnemy()
        {
            _form._GameController.NewEnemy(new Enemy()
            {
                Name = (_EnemyNames)(_form._GameController._random.Next(1, 15)),
                Age = _form._GameController._random.Next(1, 150),
                Race = (_EnemyRaces)(_form._GameController._random.Next(1, 11)),
                Level = _form._GameController._random.Next(1, _form._GameController._player.Level + 10),

                Strength = _form._GameController._random.Next(1, _form._GameController._player.Strength + 5), //da ne bude puno preslabih neprijatelja stavit player indekse +nesto
                Endurance = _form._GameController._random.Next(1, _form._GameController._player.Endurance + 5),
                Intelligence = _form._GameController._random.Next(1, _form._GameController._player.Intelligence + 5),
                Willpower = _form._GameController._random.Next(1, _form._GameController._player.Willpower + 5),
                Agility = _form._GameController._random.Next(1, _form._GameController._player.Agility + 5),
                Speed = _form._GameController._random.Next(1, _form._GameController._player.Speed +5),
                Luck = _form._GameController._random.Next(1, _form._GameController._player.Luck + 5),

                //MaxHealth,
                Health = _form._GameController._random.Next(1, _form._GameController._player.Health + 50),
                //MaxMana,
                Mana = _form._GameController._random.Next(1, _form._GameController._player.Mana + 50),
                //ExperienceForNextLevel,
                //Experience

                HasAssignedQuest = false
            }
                );
        }
    }
}
