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
    public partial class FormLevel4 : Form //четвертый уровень
    {
        public FormLevel4()
        {
            InitializeComponent();
        }
        private void start_game()
        {
            MessageBox.Show("Чтобы пройти этот уровень необходимо подобрать ключ прежде, чем отправиться к финишу");
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

        private void finish_game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Вы проиграли. Еще раз?", "Сообщение", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
            label_key.Visible = true;
        }

        private void FormLevel4_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label_key_MouseEnter(object sender, EventArgs e) //подбирание ключа
        {
            label_key.Visible = false;
            Sound.play_catch();
        }

        private void label_door_MouseEnter(object sender, EventArgs e)//открывание двери ключом
        {
            if (label_key.Visible)
                finish_game();
            else
            {
                label_door.Visible = false;
                Sound.play_door();
            }
        }


    }
}
