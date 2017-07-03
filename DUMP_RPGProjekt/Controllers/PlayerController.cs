using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUMP_RPGProjekt.Models;

namespace DUMP_RPGProjekt.Controllers
{
    public class PlayerController
    {
        private MainWIndow _form;

        public PlayerController(MainWIndow form)
        {
            _form = form;
        }

        public void NewPlayer()
        {
            _form._GameController.NewPlayer(new Player()
            {
                Name = _form.textBox_EnterName.Text,
                Age = 0,
                Race = (_Race)(_form.groupBox_RadioButtons_TabIndexChanged(this, EventArgs.Empty)),
                Level = 1,

                Strength = _form._GameController._random.Next(1, 20), //mozda triba bolje nasumicne brojeve
                Endurance = _form._GameController._random.Next(1, 10),
                Intelligence = _form._GameController._random.Next(1, 10),
                Willpower = _form._GameController._random.Next(1, 10),
                Agility = _form._GameController._random.Next(1, 10),
                Speed = _form._GameController._random.Next(1, 10),
                Luck = _form._GameController._random.Next(1, 10),

                MaxHealth = 100,
                Health = 100,
                MaxMana = 50,
                Mana = 50,
                ExperienceForNextLevel = 100,
                Experience = 0,

                IsAlive = true
            }
                );
        }
    }
}
