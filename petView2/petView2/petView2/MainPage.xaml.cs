using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using petView2;
using petView2.MONITOR;
using petView2.ALIMENTADOR;
using petView2.SERVICE;
using Newtonsoft.Json.Linq;

namespace petView2
{
	public partial class MainPage : ContentPage
	{
      
		public MainPage()
		{
            InitializeComponent();
            
        }

        private void Monitor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new webVieww());
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //slider.Value = Math.Round(e.NewValue);

            var newStep = Math.Round(e.NewValue);
            slider.Value = newStep;
            lblText.Text = slider.Value.ToString();
            //lblText.TranslateTo(slider.Value * ((slider.Width) / slider.Maximum), 0, 100);
        }

        private void Agendar_Alimento()
        {
            double param = (slider.Value)*(2000);

            JObject user = new JObject();

            user.Add("action", "write");
            user.Add("gpio", 17);
            user.Add("status", true);
            user.Add("tempo", param);

            ServiceWS.AtivarAlimentador(user);
            
        }

       
    }
}
