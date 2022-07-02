using Newtonsoft.Json;
using Servico;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mg_AlarmeApp.API
{
    public class ApiService
    {
        //https://servico-yu2.conveyor.cloud/
        public const string Url = "https://servico-yu2.conveyor.cloud/";
        public static async Task<List<CentralAlarme>> ObterCliente()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = Url + "api/CentralAlarmes";
                string response = await client.GetStringAsync(url);
                List<CentralAlarme> cliente = JsonConvert.DeserializeObject<List<CentralAlarme>>(response);
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
