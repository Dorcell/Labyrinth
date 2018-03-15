﻿using System;
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
    public partial class FormLevel1 : Form //первый уровень
    {
        public FormLevel1()
        {
            InitializeComponent();
        }
        private void start_game() //функция установки курсора на старте
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen (point);
        }
        private void finish_game() //функция проигрыша
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Вы проиграли. Еще раз?", "Сообщение", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
        private void FormLevel1_Shown(object sender, EventArgs e) 
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

    }
}
