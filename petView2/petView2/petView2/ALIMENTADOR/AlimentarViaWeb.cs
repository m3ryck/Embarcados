using System;
using System.Collections.Generic;
using System.Text;

namespace petView2.ALIMENTADOR
{
    public class AlimentarViaWeb
    {
        public int id { get; set; }
        public static string action;//nome

        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        public static bool status; //password

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public static int gpio;

        public int Gpio
        {
            get { return gpio; }
            set { gpio = value; }
        }

        public static int tempo;

        public int Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }

    }


}
