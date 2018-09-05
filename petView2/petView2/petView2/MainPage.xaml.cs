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
            App.Current.MainPage = new webVieww();
        }

        
        private void Agendar_Alimento()
        {


            JObject user = new JObject();

            user.Add("action", "write");
            user.Add("gpio", 17);
            user.Add("status", true);
            user.Add("tempo", 2000);

            ServiceWS.AtivarAlimentador(user);
            
        }
        
    }
}
