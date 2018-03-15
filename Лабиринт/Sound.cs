using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Лабиринт
{
    static class Sound //класс,отвечающий за звуки в игре
    {
        static SoundPlayer sound_load = new SoundPlayer(Properties.Resources.sound_load);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start);
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail);
        static SoundPlayer sound_win = new SoundPlayer(Properties.Resources.sound_win);
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.sound_key);
        static SoundPlayer sound_catch = new SoundPlayer(Properties.Resources.keys_catch);
        static SoundPlayer sound_door = new SoundPlayer(Properties.Resources.door_open);
        static bool sound_enabled = true;

        static public void sound_on()//звук включен
        {
            sound_enabled = true;
        }
        static public void sound_off()//звук выключен
        {
            sound_enabled = false;
        }

        public static void play_key()
        {
            if (sound_enabled)
                sound_key.Play();
        }
        public static void play_load()
        {
            if (sound_enabled)
            sound_load.Play();
        }
        public static void play_start()
        {
            if (sound_enabled)
            sound_start.Play();
        }
        public static void play_fail()
        {
            if (sound_enabled)
            sound_fail.Play();
        }
        public static void play_win()
        {
            if (sound_enabled)
            sound_win.Play();
        }
        public static void play_catch()
        {
            if (sound_enabled)
                sound_catch.Play();
        }
        public static void play_door()
        {
            if (sound_enabled)
                sound_door.Play();
        }
    }
}
