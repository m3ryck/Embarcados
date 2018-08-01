using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace petView2.MONITOR
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class webVieww : ContentPage
	{
		public webVieww ()
		{
			InitializeComponent ();
            
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