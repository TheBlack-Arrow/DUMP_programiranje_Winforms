using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DUMP_RPGProjekt.Controllers;
using DUMP_RPGProjekt.Models;
using System.IO;

namespace DUMP_RPGProjekt
{
    public partial class MainWIndow : Form
    {
        public MainWIndow()
        {
            InitializeComponent();
            
            _PlayerController = new PlayerController(this);
            _EnemyController = new EnemyController(this);
            _QuestController = new QuestController(this);
            _ViewController = new ViewController(this);
            _GameController = new GameController(this);
        }

        public PlayerController _PlayerController;
        public EnemyController _EnemyController;
        public QuestController _QuestController;
        public ViewController _ViewController;
        public GameController _GameController;

        //**********************************************
        //****************** * GAME * ******************
        //**********************************************
        private void stripMenuItem_New_Click(object sender, EventArgs e)
        {
            _ViewController.Show_MainMenuScreen();
        }

        private void stripMenuItem_Save_Click(object sender, EventArgs e)
        {
            _GameController.Save_Game();
        }

        private void stripMenuItem_Load_Click(object sender, EventArgs e)
        {
            _GameController.Load_Game();
        }

        private void StripMenuItem_Quit_Click(object sender, EventArgs e)
        {
            _GameController.Exit_Game();
        }

        //**********************************************
        //****************** * MENU * ******************
        //**********************************************
        

        public int groupBox_RadioButtons_TabIndexChanged(object sender, EventArgs e)
        {
            RadioButton checkedButton = groupBox_RadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return int.Parse(checkedButton.Tag.ToString());
        }

        private void button_StartNewGame_Click(object sender, EventArgs e)
        {
            if ("" == textBox_EnterName.Text)
            {
                //provjeri jel ime upisano, ako nije reci i izadi iz ove funkcije
                MessageBox.Show("Please type in a valid name", "Invalid Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RadioButton checkedButton = groupBox_RadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (null == checkedButton)
            {
                //provjeri jel odabrana rasa, ako nije reci i izadi iz ove funkcije
                MessageBox.Show("Please choose a race", "Invalid Race Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //inicijaliziraj sve kad su zadovoljeni uvjeti
            _PlayerController.NewPlayer();
            for (int i = 0; i < 12; i++)
            {
                _EnemyController.NewEnemy();
            }
            for (int i = 0; i < 11; i++)
            {
                _QuestController.NewQuest();
            }
            _QuestController.AddQuestsToListBox(_GameController.QuestsActive);
            _ViewController.Show_StatsMenu();
        }

        private void MainWIndow_Load(object sender, EventArgs e)
        {
            _ViewController.Show_GameScreen();
        }

        //*************************************************
        //****************** * BUTTONS * ******************
        //*************************************************

        private void button_Stats_Click(object sender, EventArgs e)
        {
            _ViewController.Button_Stats_Clicked();

            _ViewController.Button_Items_Unclicked();
            _ViewController.Button_Store_Unclicked();
            _ViewController.Button_Quests_Unclicked();
            _ViewController.Button_Map_Unclicked();
        }

        private void button_Stats_MouseHover(object sender, EventArgs e)
        {
            _ViewController.Button_Stats_Hovered();
        }

        private void button_Stats_MouseLeave(object sender, EventArgs e)
        {
            if (0 == int.Parse((sender as Button).Tag.ToString()))
                _ViewController.Button_Stats_Unclicked();
        }

        private void button_Items_Click(object sender, EventArgs e)
        {
            _ViewController.Button_Items_Clicked();

            _ViewController.Button_Stats_Unclicked();
            _ViewController.Button_Store_Unclicked();
            _ViewController.Button_Quests_Unclicked();
            _ViewController.Button_Map_Unclicked();
        }

        private void button_Items_MouseHover(object sender, EventArgs e)
        {
            _ViewController.Button_Items_Hovered();
        }

        private void button_Items_MouseLeave(object sender, EventArgs e)
        {
            if (0 == int.Parse((sender as Button).Tag.ToString()))
                _ViewController.Button_Items_Unclicked();
        }

        private void button_Store_Click(object sender, EventArgs e)
        {
            _ViewController.Button_Store_Clicked();

            _ViewController.Button_Stats_Unclicked();
            _ViewController.Button_Items_Unclicked();
            _ViewController.Button_Quests_Unclicked();
            _ViewController.Button_Map_Unclicked();
        }

        private void button_Store_MouseHover(object sender, EventArgs e)
        {
            _ViewController.Button_Store_Hovered();
        }

        private void button_Store_MouseLeave(object sender, EventArgs e)
        {
            if (0 == int.Parse((sender as Button).Tag.ToString()))
                _ViewController.Button_Store_Unclicked();
        }

        private void button_Quests_Click(object sender, EventArgs e)
        {
            _ViewController.Button_Quests_Clicked();

            _ViewController.Button_Stats_Unclicked();
            _ViewController.Button_Items_Unclicked();
            _ViewController.Button_Store_Unclicked();
            _ViewController.Button_Map_Unclicked();
        }

        private void button_Quests_MouseHover(object sender, EventArgs e)
        {
            _ViewController.Button_Quests_Hovered();
        }

        private void button_Quests_MouseLeave(object sender, EventArgs e)
        {
            if (0 == int.Parse((sender as Button).Tag.ToString()))
                _ViewController.Button_Quests_Unclicked();
        }

        private void button_Map_Click(object sender, EventArgs e)
        {
            _ViewController.Button_Map_Clicked();

            _ViewController.Button_Stats_Unclicked();
            _ViewController.Button_Items_Unclicked();
            _ViewController.Button_Store_Unclicked();
            _ViewController.Button_Quests_Unclicked();
        }

        private void button_Map_MouseHover(object sender, EventArgs e)
        {
            _ViewController.Button_Map_Hovered();
        }

        private void button_Map_MouseLeave(object sender, EventArgs e)
        {
            if (0 == int.Parse((sender as Button).Tag.ToString()))
                _ViewController.Button_Map_Unclicked();
        }

        private void button_EndGame_Quit_Click(object sender, EventArgs e)
        {
            _GameController.Exit_Game();
        }

        private void listBox_Quests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Quests.SelectedItem != null)
                _GameController.Battle((listBox_Quests.SelectedItem as Quest));
        }



        //public class NewProgressBar : ProgressBar
        //{
        //    public NewProgressBar()
        //    {
        //        this.SetStyle(ControlStyles.UserPaint, true);
        //    }

        //    protected override void OnPaint(PaintEventArgs e)
        //    {
        //        Rectangle rec = e.ClipRectangle;

        //        rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
        //        if (ProgressBarRenderer.IsSupported)
        //            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
        //        rec.Height = rec.Height - 4;
        //        e.Graphics.FillRectangle(Brushes.Red, 2, 2, rec.Width, rec.Height);
        //    }
        //}

        //NewProgressBar progressBar_Health = new NewProgressBar();

        //public void Funkcija()
        //{
        //    NewProgressBar progressBar_Health = new NewProgressBar();

        //    progressBar_Health.Location = new System.Drawing.Point(100, 100);
        //    progressBar_Health.Size = new Size(150, 10);
        //    progressBar_Health.Visible = true;
        //    progressBar_Health.Name = "Ivan";
        //    this.Controls.Add(progressBar_Health);
        //}
    }
}
