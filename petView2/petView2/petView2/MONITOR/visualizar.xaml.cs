﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.MediaManager.Forms;

using Plugin.MediaManager;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace petView2.MONITOR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class visualizar : ContentPage
    {
        private string URL = "http://192.168.0.19:81/index.htm﻿";

        public visualizar()
        {
            InitializeComponent();
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        private void Alimento_Clicked(object sender, EventArgs e)
        {
            
        }
    }
    }


            
            /*
            if (PlayStopButton.Text == "PLAY")
            {

                //CrossMediaManager.Current.Play(videoURL, Plugin.MediaManager.Abstractions.Enums.MediaFileType.Video);

                PlayStopButton.Text = "STOP";
            }

            if (PlayStopButton.Text == "STOP")
            {
                //CrossMediaManager.Current.Stop();

                PlayStopButton.Text = "PLAY";
            }
            
        }
    }
}

*/