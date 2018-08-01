using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using petView2;
using petView2.MONITOR;

namespace petView2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new webVieww();
        }

        private void Agendar_Alimento(object sender, EventArgs e)
        {
            
        }
    }
}
