using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUMP_RPGProjekt.Models;

namespace DUMP_RPGProjekt.Controllers
{
   public class GameController
    {
        private MainWIndow _form;

        public GameController(MainWIndow form)
        {
            _form = form;
        }

        //**********************************************
        //****************** * GAME * ******************
        //**********************************************
        public void Exit_Game()
        {
            //do you want to save your progress?
            System.Windows.Forms.Application.Exit();
        }

        public void New_Game()
        {
            _form._PlayerController.NewPlayer();
            //new enemies i ostalo
            //pripremi save files
        }

        public void Save_Game()
        {
            //****************************************
        }

        public void Load_Game()
        {
            //****************************************
        }

        public Random _random = new Random();

        //************************************************
        //****************** * BATTLE * ******************
        //************************************************

        public void Battle(Quest quest)
        {
            _form._ViewController.Display_BattleMenu();
            _form._ViewController.Display_PlayerInfo(_player);
            _form._ViewController.Display_EnemyInfo(quest.Enemy);
            _form._ViewController.Write_BattleLog(_player, quest.Enemy, quest);
        }

        public bool Choose_TypeOfAttack()
        {
            int number = _random.Next(1, 100);

            if (number <= 50)
                return true;
            else
                return false;
        }

        //************************************************
        //****************** * PLAYER * ******************
        //************************************************

        public Player _player;

        public void NewPlayer(Player player)
        {
            _player = player;
        }

        public void KillPlayer(Player player)
        {
            player.IsAlive = false;
            _form._ViewController.EndGame_PlayerKilled();
        }

        public void LevelUp(int overflow)
        {
            _player.Level++;
            _player.Strength++;
            _player.Endurance++;
            _player.Intelligence++;
            _player.Willpower++;
            _player.Agility++;
            _player.Speed++;
            _player.Luck++;

            _player.MaxHealth += 50;
            _player.Health = _player.MaxHealth;
            _player.ExperienceForNextLevel += 100;
            //provjeri da nije owerflow opet veci od expForNextLevel
            _player.Experience = overflow;
        }

        //*************************************************
        //****************** * ENEMIES * ******************
        //*************************************************

        public List<Enemy> EnemiesAlive = new List<Enemy>();
        public List<Enemy> EnemiesDead = new List<Enemy>();

        public void NewEnemy (Enemy enemy)
        {
            EnemiesAlive.Add(enemy);
        }

        public void KillEnemy (Enemy enemy)
        {
            EnemiesAlive.Remove(enemy);
            EnemiesDead.Add(enemy);
            _form._EnemyController.NewEnemy();
        }

        //************************************************
        //****************** * QUESTS * ******************
        //************************************************

        public List<Quest> QuestsActive = new List<Quest>();
        public List<Quest> QuestsFinished = new List<Quest>();

        public void NewQuest (Quest quest)
        { 
            QuestsActive.Add(quest);
        }

        public void FinishQuest (Quest quest)
        {
            QuestsActive.Remove(quest);
            QuestsFinished.Add(quest);
            _form._QuestController.NewQuest();
            _form._ViewController.Hide_BattleMenu();
        }
    }
}
