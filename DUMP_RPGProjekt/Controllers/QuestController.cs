using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUMP_RPGProjekt.Models;

namespace DUMP_RPGProjekt.Controllers
{
    public class QuestController
    {
        private MainWIndow _form;

        public QuestController(MainWIndow form)
        {
            _form = form;
        }

        public void NewQuest()
        {
            Enemy AvailableEnemy = _form._GameController.EnemiesAlive.FirstOrDefault(e => e.HasAssignedQuest == false);
            AvailableEnemy.HasAssignedQuest = true;

            _form._GameController.NewQuest(new Quest()
            {
                Name = "Kill " + AvailableEnemy.Name.ToString() + ", the " + AvailableEnemy.Race.ToString(),
                Location = (_QuestLocations)(_form._GameController._random.Next(1, 10)),
                Difficulty = DetermineDifficulty(AvailableEnemy, _form._GameController._player),
                ExperienceReward = AvailableEnemy.Level * 10,
                //MoneyReward
                Enemy = AvailableEnemy
            }
                );
        }

        public string DetermineDifficulty(Enemy enemy, Player player)
        {
            if (enemy.Level < player.Level - 10)
                return "Laughably easy";
            else if (enemy.Level <= player.Level - 10 && enemy.Level < player.Level - 5)
                return "Very easy";
            else if (enemy.Level >= player.Level - 5 && enemy.Level < player.Level)
                return "Easy";
            else if (enemy.Level >= player.Level && enemy.Level < player.Level + 5)
                return "Medium";
            else if (enemy.Level >= player.Level + 5 && enemy.Level < player.Level + 10)
                return "Hard";
            else
                return "Very hard";
        }

        public void AddQuestsToListBox (List<Quest> quests)
        {
            _form.listBox_Quests.Items.Clear();
            _form.listBox_Quests.Items.AddRange(quests.ToArray());
        }
    }
}
