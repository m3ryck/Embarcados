using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json.Linq;
using petView2.SERVICE;

namespace petView2.MONITOR
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class webVieww : ContentPage
	{
		public webVieww ()
		{
			InitializeComponent ();
            
		}

        private void Button_Clicked(object sender, EventArgs e)
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