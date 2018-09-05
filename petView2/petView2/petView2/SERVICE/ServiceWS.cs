using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using petView2.ALIMENTADOR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace petView2.SERVICE
{
    class ServiceWS
    {
        
        public async static void  AtivarAlimentador(JObject alimentarViaWeb)
        {
            string server = "http://192.168.11.7/ajax";
            var URL = new Uri(server);
           
            var param = new StringContent(alimentarViaWeb.ToString(), Encoding.UTF8, "application/json");
            HttpClient requisicao = new HttpClient();
                                                               //url e parametros
            HttpResponseMessage resposta = null;

            resposta = await requisicao.PostAsync(URL, param);

            System.Console.WriteLine("DEBUG POST");

            /*
            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;*/

           
        }

    }
}
