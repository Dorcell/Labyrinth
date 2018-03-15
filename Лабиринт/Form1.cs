using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Лабиринт
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)//проигрывание звука при згрузке
        {
            Sound.play_load();
        }

        private void button1_Click(object sender, EventArgs e) //начало игры с первой карты
        {
            Sound.play_start();
            MessageBox.Show("Чтобы пройти лабиринт,проведите курсор от старта до финиша, не касаясь стен");
            start_level1();
        }

        private void SoundBox_CheckedChanged(object sender, EventArgs e) //отключение и включение звука в игре
        {
            if (SoundBox.Checked)
            {
                Sound.sound_on();
                SoundBox.Text = "Звук включен";
                Sound.play_key();
            }
            else
            {
                Sound.sound_off();
                SoundBox.Text = "Звук выключен";
            }
        }

        private void button2_Click(object sender, EventArgs e) //выход из игры
        {
            this.Close();
        }
        private void start_level1() //запуск первого уровня
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Sound.play_win();
                start_level2();
            }
        }
        private void start_level2() //запуск второго уровня
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Sound.play_win();
                start_level3();
            }
        }
        private void start_level3()//запуск третьего уровня
        {
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr==System.Windows.Forms.DialogResult.OK)
            {
                Sound.play_win();
                start_level4();
            }

        }
        private void start_level4()//запуск четвертого уровня
        {
            FormLevel4 level4 = new FormLevel4();
            DialogResult dr = level4.ShowDialog();
            if (dr==System.Windows.Forms.DialogResult.OK)
            {
                Sound.play_win();
                start_level5();
            }
        }

        private void start_level5()//запуск пятого уровня
        {
            FormLevel5 level5 = new FormLevel5();
            DialogResult dr = level5.ShowDialog();
            if (dr==System.Windows.Forms.DialogResult.OK)
            {
                Sound.play_win();
                MessageBox.Show("Вы прошли игру, поздравляю!");
                this.Close();
            }
        }
    }



}
