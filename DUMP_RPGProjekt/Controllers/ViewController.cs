using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUMP_RPGProjekt.Models;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace DUMP_RPGProjekt.Controllers
{
    public class ViewController
    {
        private MainWIndow _form;

        public ViewController(MainWIndow form)
        {
            _form = form;

            //MenuButtons.Add(_form.button_Stats);
            //MenuButtons.Add(_form.button_Items);
            //MenuButtons.Add(_form.button_Store);
            //MenuButtons.Add(_form.button_Quests);
            //MenuButtons.Add(_form.button_Map);

            //MenuButtons_ImagesURL.Add("@\"../../ Images / Stats_Button_Unclicked.png\"");
            //MenuButtons_ImagesURL.Add("@\"../../ Images / Items_Button_Unclicked.png\"");
            //MenuButtons_ImagesURL.Add("@\"../../ Images / Store_Button_Unclicked.png\"");
            //MenuButtons_ImagesURL.Add("@\"../../ Images / Quests_Button_Unclicked.png\"");
            //MenuButtons_ImagesURL.Add("@\"../../ Images / Map_Button_Unclicked.png\"");
        }

        //public bool ToggleVisibility(bool visible)
        //{
        //    return visible = !visible;
        //}

        public void Show_GameScreen()
        {
            _form.pictureBox_TitleScreen.Visible = true;
        }

        public void Show_MainMenuScreen()
        {
            //prikazi screen sa input stvarima
            _form.pictureBox_TitleScreen.Visible = false;
            _form.panel_MainMenuScreen.Visible = true;
        }

        public void Show_StatsMenu()
        {
            //sakrije main menu screen (dodaj animaciju?) i prikaze stats menu
            _form.panel_MainMenuScreen.Visible = false;
            _form.panel_StatsMenu.Visible = true;
            Button_Stats_Clicked();
        }

        //*************************************************
        //****************** * BUTTONS * ******************
        //*************************************************

        List<Button> MenuButtons = new List<Button>();
        //List<string> MenuButtons_ImagesURL = new List<string>();

        //public void Add_ButtonsToList ()
        //{
        //    MenuButtons.Add(_form.button_Stats);
        //    MenuButtons.Add(_form.button_Items);
        //    MenuButtons.Add(_form.button_Store);
        //    MenuButtons.Add(_form.button_Quests);
        //    MenuButtons.Add(_form.button_Map);
        //}

        public void Button_Stats_Unclicked()
        {
            //pictureBox_TitleScreen.Image = Image.FromFile("C:/Users/MERI/Documents/Visual Studio 2017/Projects/DUMP_RPGProjekt/DUMP_RPGProjekt/Images/Armor_Store_Button_Unclicked.png");
            _form.button_Stats.Image = Image.FromFile(@"../../Images/Stats_Button_Unclicked.png");
            _form.button_Stats.Tag = 0;
        }

        public void Button_Stats_Hovered()
        {
            if (0 == int.Parse(_form.button_Stats.Tag.ToString())) //da ne prebrise sa button_hovered slikom ako je vec kliknut botun
                _form.button_Stats.Image = Image.FromFile(@"../../Images/Stats_Button_Hovered.png");
        }

        public void Button_Stats_Clicked()
        {
            _form.button_Stats.Image = Image.FromFile(@"../../Images/Stats_Button_Clicked.png");
            _form.button_Stats.Tag = 1;
            Display_StatsMenuInfo();

            _form.panel_StatsMenu.Visible = true;

            _form.panel_ItemsMenu.Visible = false;
            _form.panel_StoreMenu.Visible = false;
            _form.panel_QuestsMenu.Visible = false;
        }

        //*********************
        public void Button_Items_Unclicked()
        {
            _form.button_Items.Image = Image.FromFile(@"../../Images/Items_Button_Unclicked.png");
            _form.button_Items.Tag = 0;
        }

        public void Button_Items_Hovered()
        {
            if (0 == int.Parse(_form.button_Items.Tag.ToString()))
                _form.button_Items.Image = Image.FromFile(@"../../Images/Items_Button_Hovered.png");
        }

        public void Button_Items_Clicked()
        {
            _form.button_Items.Image = Image.FromFile(@"../../Images/Items_Button_Clicked.png");
            _form.button_Items.Tag = 1;
            Display_ItemsMenuInfo();

            _form.panel_ItemsMenu.Visible = true;

            _form.panel_StatsMenu.Visible = false;
            _form.panel_StoreMenu.Visible = false;
            _form.panel_QuestsMenu.Visible = false;
        }

        //*********************
        public void Button_Store_Unclicked()
        {
            _form.button_Store.Image = Image.FromFile(@"../../Images/Store_Button_Unclicked.png");
            _form.button_Store.Tag = 0;
        }

        public void Button_Store_Hovered()
        {
            if (0 == int.Parse(_form.button_Store.Tag.ToString()))
                _form.button_Store.Image = Image.FromFile(@"../../Images/Store_Button_Hovered.png");
        }

        public void Button_Store_Clicked()
        {
            _form.button_Store.Image = Image.FromFile(@"../../Images/Store_Button_Clicked.png");
            _form.button_Store.Tag = 1;
            Display_StoreMenuInfo();

            _form.panel_StoreMenu.Visible = true;

            _form.panel_StatsMenu.Visible = false;
            _form.panel_ItemsMenu.Visible = false;
            _form.panel_QuestsMenu.Visible = false;
        }

        //*********************
        public void Button_Quests_Unclicked()
        {
            _form.button_Quests.Image = Image.FromFile(@"../../Images/Quests_Button_Unclicked.png");
            _form.button_Quests.Tag = 0;
        }

        public void Button_Quests_Hovered()
        {
            if (0 == int.Parse(_form.button_Quests.Tag.ToString()))
                _form.button_Quests.Image = Image.FromFile(@"../../Images/Quests_Button_Hovered.png");
        }

        public void Button_Quests_Clicked()
        {
            _form.button_Quests.Image = Image.FromFile(@"../../Images/Quests_Button_Clicked.png");
            _form.button_Quests.Tag = 1;
            Display_QuestsMenuInfo();

            _form.panel_QuestsMenu.Visible = true;

            _form.panel_StatsMenu.Visible = false;
            _form.panel_ItemsMenu.Visible = false;
            _form.panel_StoreMenu.Visible = false;
        }

        //*********************
        public void Button_Map_Unclicked()
        {
            _form.button_Map.Image = Image.FromFile(@"../../Images/Map_Button_Unclicked.png");
            _form.button_Map.Tag = 0;
        }

        public void Button_Map_Hovered()
        {
            if (0 == int.Parse(_form.button_Map.Tag.ToString()))
                _form.button_Map.Image = Image.FromFile(@"../../Images/Map_Button_Hovered.png");
        }

        public void Button_Map_Clicked()
        {
            _form.button_Map.Image = Image.FromFile(@"../../Images/Map_Button_Clicked.png");
            _form.panel_StatsMenu.Visible = false;
            _form.panel_ItemsMenu.Visible = false;
            _form.panel_StoreMenu.Visible = false;
            _form.panel_QuestsMenu.Visible = false;
            _form.button_Map.Tag = 1;
        }

        //public void Button_Clicked(Button button)
        //{
        //    button.Tag = 1;

        //    if ("button_Stats" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Stats_Button_Clicked.png");
        //    else if ("button_Items" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Items_Button_Clicked.png");
        //    else if ("button_Store" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Store_Button_Clicked.png");
        //    else if ("button_Quests" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Quests_Button_Clicked.png");
        //    else if ("button_Map" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Map_Button_Clicked.png");
        //}

        public void Button_Hovered(Button button)
        {
            //    if (0 == int.Parse(button.Tag.ToString()))
            //    {
            //        if ("button_Stats" == button.Name)
            //            button.Image = Image.FromFile(@"../../Images/Stats_Button_Hovered.png");
            //        else if ("button_Items" == button.Name)
            //            button.Image = Image.FromFile(@"../../Images/Items_Button_Hovered.png");
            //        else if ("button_Store" == button.Name)
            //            button.Image = Image.FromFile(@"../../Images/Store_Button_Hovered.png");
            //        else if ("button_Quests" == button.Name)
            //            button.Image = Image.FromFile(@"../../Images/Quests_Button_Hovered.png");
            //        else if ("button_Map" == button.Name)
            //            button.Image = Image.FromFile(@"../../Images/Map_Button_Hovered.png");
            //    }

            foreach (Button b in MenuButtons)
            {
                if (1 != int.Parse(b.Tag.ToString()))
                {
                    if ("button_Stats" == button.Name)
                        button.Image = Image.FromFile(@"../../Images/Stats_Button_Unclicked.png");
                    else if ("button_Items" == button.Name)
                        button.Image = Image.FromFile(@"../../Images/Items_Button_Unclicked.png");
                    else if ("button_Store" == button.Name)
                        button.Image = Image.FromFile(@"../../Images/Store_Button_Unclicked.png");
                    else if ("button_Quests" == button.Name)
                        button.Image = Image.FromFile(@"../../Images/Quests_Button_Unclicked.png");
                    else if ("button_Map" == button.Name)
                        button.Image = Image.FromFile(@"../../Images/Map_Button_Unclicked.png");
                }
            }
        }

        //public void Button_Unclicked(Button button)
        //{
        //    button.Tag = 0;

        //    if ("button_Stats" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Stats_Button_Unclicked.png");
        //    else if ("button_Items" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Items_Button_Unclicked.png");
        //    else if ("button_Store" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Store_Button_Unclicked.png");
        //    else if ("button_Quests" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Quests_Button_Unclicked.png");
        //    else if ("button_Map" == button.Name)
        //        button.Image = Image.FromFile(@"../../Images/Map_Button_Unclicked.png");
        //}

        //****************************************************
        //****************** * PANEL INFO * ******************
        //****************************************************

        public void Display_StatsMenuInfo()
        {
            _form.progressBar_Health.Maximum = _form._GameController._player.MaxHealth;
            _form.progressBar_Health.Value = _form._GameController._player.Health;
            _form.progressBar_Mana.Maximum = _form._GameController._player.MaxMana;
            _form.progressBar_Mana.Value = _form._GameController._player.Mana;
            _form.progressBar_Experience.Maximum = _form._GameController._player.ExperienceForNextLevel;
            _form.progressBar_Experience.Value = _form._GameController._player.Experience;

            _form.label_Name.Text = _form._GameController._player.Name;
            _form.label_Age.Text = _form._GameController._player.Age.ToString();
            _form.label_Race.Text = _form._GameController._player.Race.ToString();
            _form.label_Level.Text = _form._GameController._player.Level.ToString();

            _form.label_Strength.Text = _form._GameController._player.Strength.ToString();
            _form.label_Endurance.Text = _form._GameController._player.Endurance.ToString();
            _form.label_Intelligence.Text = _form._GameController._player.Intelligence.ToString();
            _form.label_Willpower.Text = _form._GameController._player.Willpower.ToString();
            _form.label_Agility.Text = _form._GameController._player.Agility.ToString();
            _form.label_Speed.Text = _form._GameController._player.Speed.ToString();
            _form.label_Luck.Text = _form._GameController._player.Luck.ToString();
        }

        public void Display_ItemsMenuInfo()
        {
            //*********************
        }

        public void Display_StoreMenuInfo()
        {
            //*********************
        }

        public void Display_QuestsMenuInfo()
        {
            //*********************
        }

        //************************************************
        //****************** * BATTLE * ******************
        //************************************************

        public void Display_BattleMenu()
        {
            _form.panel_Battle.Visible = true;
        }

        public void Hide_BattleMenu()
        {
            _form.panel_Battle.Visible = false;
        }

        public void Display_PlayerInfo(Player player)
        {
            _form.label_PlayerStats.Text = player.ToString();
        }

        public void Display_EnemyInfo(Enemy enemy)
        {
            _form.label_EnemyStats.Text = enemy.ToString();
        }

        //Stvarno, ispricavan se. Ovo sve u Write_BattleLog je napisano u roku od 1h
        //samo da bi moglo radit i da stignem predat na vrime

        public void Write_BattleLog(Player player, Enemy enemy, Quest quest) //ova logika je tribala ic u _GameController, a ispis u labele ovde
        {
            int playerDamage = 0;
            int enemyDamage = 0;
            int overflow = 0;

            while (player.Health > 0 && enemy.Health > 0)
            {
                if (player.Speed + _form._GameController._random.Next(1, player.Luck) >= enemy.Speed + _form._GameController._random.Next(1, enemy.Luck))
                {
                    if (_form._GameController.Choose_TypeOfAttack())
                    {
                        playerDamage = Math.Abs((player.Strength * player.Level) - (enemy.Endurance + enemy.Luck + enemy.Agility));
                        _form.label_BattleOutput.Text += "Player strikes first with melee, does " + playerDamage + " damage.\n";

                        enemy.Health -= playerDamage;
                        Display_EnemyInfo(enemy);
                        if (enemy.Health <= 0)
                        {
                            enemy.Health = 0;
                            //kill enemy
                            _form.label_BattleOutput.Text += "Player defeated the enemy!\n";
                            _form._GameController.KillEnemy(enemy);

                            //exp reward
                            if ((player.ExperienceForNextLevel - player.Experience) <= quest.ExperienceReward)
                            {
                                overflow = quest.ExperienceReward - (player.ExperienceForNextLevel - player.Experience);
                                _form._GameController.LevelUp(overflow);
                            }
                            else player.Experience += quest.ExperienceReward;

                            //finish quest
                            _form._GameController.FinishQuest(quest);
                        }

                        //******************************************************************
                        //******************************************************************
                        if (_form._GameController.Choose_TypeOfAttack())
                        {
                            enemyDamage = Math.Abs((enemy.Strength * enemy.Level) - (player.Endurance + player.Luck + player.Agility));
                            _form.label_BattleOutput.Text += "Enemy strikes first with melee, does " + enemyDamage + " damage.\n";

                            player.Health -= enemyDamage;
                            Display_PlayerInfo(player);
                            if (player.Health <= 0)
                            {
                                player.Health = 0;
                                //kill player
                                _form.label_BattleOutput.Text += "Enemy defeated the player!\n";
                                _form._GameController.KillPlayer(player);
                            }
                        }
                        else
                        {
                            enemyDamage = Math.Abs(((enemy.Intelligence + enemy.Willpower) * enemy.Level) - (player.Endurance + player.Luck + player.Agility));
                            _form.label_BattleOutput.Text += "Enemy strikes first with magic, does " + enemyDamage + " damage.\n";

                            player.Health -= enemyDamage;
                            Display_PlayerInfo(player);
                            if (player.Health <= 0)
                            {
                                player.Health = 0;
                                //kill player
                                _form.label_BattleOutput.Text += "Enemy defeated the player!\n";
                                _form._GameController.KillPlayer(player);
                            }
                        }

                        //******************************************************************
                        //******************************************************************
                    }
                    else
                    {
                        playerDamage = Math.Abs(((player.Intelligence + player.Willpower) * player.Level) - (enemy.Endurance + enemy.Luck + enemy.Agility));
                        _form.label_BattleOutput.Text += "Player strikes first with magic, does " + playerDamage + " damage.\n";

                        enemy.Health -= playerDamage;
                        Display_EnemyInfo(enemy);
                        if (enemy.Health <= 0)
                        {
                            enemy.Health = 0;
                            //kill enemy
                            _form.label_BattleOutput.Text += "Player defeated the enemy!\n";
                            _form._GameController.KillEnemy(enemy);

                            //exp reward
                            if ((player.ExperienceForNextLevel - player.Experience) <= quest.ExperienceReward)
                            {
                                overflow = quest.ExperienceReward - (player.ExperienceForNextLevel - player.Experience);
                                _form._GameController.LevelUp(overflow);
                            }
                            else player.Experience += quest.ExperienceReward;

                            //finish quest
                            _form._GameController.FinishQuest(quest);
                        }

                        //******************************************************************
                        //******************************************************************
                        if (_form._GameController.Choose_TypeOfAttack())
                        {
                            enemyDamage = Math.Abs((enemy.Strength * enemy.Level) - (player.Endurance + player.Luck + player.Agility));
                            _form.label_BattleOutput.Text += "Enemy strikes with melee, does " + enemyDamage + " damage.\n";

                            player.Health -= enemyDamage;
                            Display_PlayerInfo(player);
                            if (player.Health <= 0)
                            {
                                player.Health = 0;
                                //kill player
                                _form.label_BattleOutput.Text += "Enemy defeated the player!\n";
                                _form._GameController.KillPlayer(player);
                            }
                        }
                        else
                        {
                            enemyDamage = Math.Abs(((enemy.Intelligence + enemy.Willpower) * enemy.Level) - (player.Endurance + player.Luck + player.Agility));
                            _form.label_BattleOutput.Text += "Enemy strikes with magic, does " + enemyDamage + " damage.\n";

                            player.Health -= enemyDamage;
                            Display_PlayerInfo(player);
                            if (player.Health <= 0)
                            {
                                player.Health = 0;
                                //kill player
                                _form.label_BattleOutput.Text += "Enemy defeated the player!\n";
                                _form._GameController.KillPlayer(player);
                            }
                        }

                        //******************************************************************
                        //******************************************************************
                    }
                }
                else
                {
                    if (_form._GameController.Choose_TypeOfAttack())
                    {
                        enemyDamage = Math.Abs((enemy.Strength * enemy.Level) - (player.Endurance + player.Luck + player.Agility));
                        _form.label_BattleOutput.Text += "Enemy strikes first with melee, does " + enemyDamage + " damage.\n";

                        player.Health -= enemyDamage;
                        Display_PlayerInfo(player);
                        if (player.Health <= 0)
                        {
                            player.Health = 0;
                            //kill player
                            _form.label_BattleOutput.Text += "Enemy defeated the player!\n";
                            _form._GameController.KillPlayer(player);
                        }

                        //******************************************************************
                        //******************************************************************

                        if (_form._GameController.Choose_TypeOfAttack())
                        {
                            playerDamage = Math.Abs((player.Strength * player.Level) - (enemy.Endurance + enemy.Luck + enemy.Agility));
                            _form.label_BattleOutput.Text += "Player strikes with melee, does " + playerDamage + " damage.\n";

                            enemy.Health -= playerDamage;
                            Display_EnemyInfo(enemy);
                            if (enemy.Health <= 0)
                            {
                                enemy.Health = 0;
                                //kill enemy
                                _form.label_BattleOutput.Text += "Player defeated the enemy!\n";
                                _form._GameController.KillEnemy(enemy);

                                //exp reward
                                if ((player.ExperienceForNextLevel - player.Experience) <= quest.ExperienceReward)
                                {
                                    overflow = quest.ExperienceReward - (player.ExperienceForNextLevel - player.Experience);
                                    _form._GameController.LevelUp(overflow);
                                }
                                else player.Experience += quest.ExperienceReward;

                                //finish quest
                                _form._GameController.FinishQuest(quest);
                            }
                        }
                        else
                        {
                            playerDamage = Math.Abs(((player.Intelligence + player.Willpower) * player.Level) - (enemy.Endurance + enemy.Luck + enemy.Agility));
                            _form.label_BattleOutput.Text += "Player strikes with magic, does " + playerDamage + " damage.\n";

                            enemy.Health -= playerDamage;
                            Display_EnemyInfo(enemy);
                            if (enemy.Health <= 0)
                            {
                                enemy.Health = 0;
                                //kill enemy
                                _form.label_BattleOutput.Text += "Player defeated the enemy!\n";
                                _form._GameController.KillEnemy(enemy);

                                //exp reward
                                if ((player.ExperienceForNextLevel - player.Experience) <= quest.ExperienceReward)
                                {
                                    overflow = quest.ExperienceReward - (player.ExperienceForNextLevel - player.Experience);
                                    _form._GameController.LevelUp(overflow);
                                }
                                else player.Experience += quest.ExperienceReward;

                                //finish quest
                                _form._GameController.FinishQuest(quest);
                            }
                        }

                        //******************************************************************
                        //******************************************************************
                    }
                    else
                    {
                        enemyDamage = Math.Abs(((enemy.Intelligence + enemy.Willpower) * enemy.Level) - (player.Endurance + player.Luck + player.Agility));
                        _form.label_BattleOutput.Text += "Enemy strikes first with magic, does " + enemyDamage + " damage.\n";

                        player.Health -= enemyDamage;
                        Display_PlayerInfo(player);
                        if (player.Health <= 0)
                        {
                            player.Health = 0;
                            //kill player
                            _form.label_BattleOutput.Text += "Enemy defeated the player!\n";
                            _form._GameController.KillPlayer(player);
                        }

                        //******************************************************************
                        //******************************************************************

                        if (_form._GameController.Choose_TypeOfAttack())
                        {
                            playerDamage = Math.Abs((player.Strength * player.Level) - (enemy.Endurance + enemy.Luck + enemy.Agility));
                            _form.label_BattleOutput.Text += "Player strikes with melee, does " + playerDamage + " damage.\n";

                            enemy.Health -= playerDamage;
                            Display_EnemyInfo(enemy);
                            if (enemy.Health <= 0)
                            {
                                enemy.Health = 0;
                                //kill enemy
                                _form.label_BattleOutput.Text += "Player defeated the enemy!\n";
                                _form._GameController.KillEnemy(enemy);

                                //exp reward
                                if ((player.ExperienceForNextLevel - player.Experience) <= quest.ExperienceReward)
                                {
                                    overflow = quest.ExperienceReward - (player.ExperienceForNextLevel - player.Experience);
                                    _form._GameController.LevelUp(overflow);
                                }
                                else player.Experience += quest.ExperienceReward;

                                //finish quest
                                _form._GameController.FinishQuest(quest);
                            }
                        }
                        else
                        {
                            playerDamage = Math.Abs(((player.Intelligence + player.Willpower) * player.Level) - (enemy.Endurance + enemy.Luck + enemy.Agility));
                            
                            _form.label_BattleOutput.Text += "Player strikes with magic, does " + playerDamage + " damage.\n";

                            enemy.Health -= playerDamage;
                            Display_EnemyInfo(enemy);
                            if (enemy.Health <= 0)
                            {
                                enemy.Health = 0;
                                //kill enemy
                                _form.label_BattleOutput.Text += "Player defeated the enemy!\n";
                                _form._GameController.KillEnemy(enemy);

                                //exp reward
                                if ((player.ExperienceForNextLevel - player.Experience) <= quest.ExperienceReward)
                                {
                                    overflow = quest.ExperienceReward - (player.ExperienceForNextLevel - player.Experience);
                                    _form._GameController.LevelUp(overflow);
                                }
                                else player.Experience += quest.ExperienceReward;

                                //finish quest
                                _form._GameController.FinishQuest(quest);
                            }
                        }

                        //******************************************************************
                        //******************************************************************
                    }
                }
            }
        }

        public void EndGame_PlayerKilled()
        {
            _form.panel_EndGame.Visible = true;
        }
    }
}
