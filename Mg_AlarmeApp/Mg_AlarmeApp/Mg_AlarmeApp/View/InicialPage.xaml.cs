using Mg_AlarmeApp.API;
using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Plugin.SimpleAudioPlayer;
using System.Reflection;

namespace Mg_AlarmeApp.View
{
    public interface IaudioService
    {
        void PlayAudioFile(string fileName);
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class InicialPage : ContentPage
    {
        List<CentralAlarme> listCliente;

        public InicialPage()
        {
            InitializeComponent();
            listCliente = new List<CentralAlarme>();
            CallMethodEveryXSecondsYTimes(2);
        }

        
        public void player()
        {
            //para notificar disparos um audio de alerta
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("Mg_AlarmeApp.raw.sirene.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioStream);
            audio.Play();
        }

        int ms = 0;
        public async void Logar()
        {
            listCliente = await ApiService.ObterCliente();
            //verificar estado da zona 1 executar audio de notificação e exibir um alerta
            var cliente = listCliente.Where(x => x.despZona1.ToLower() == "sim").ToList();
            if (cliente.Count > 0)
            {
                ms++;
                player();
                if(ms == 1)
                {
                    await DisplayAlert("Aviso", "Zona 1 desparada", "Ok");
                }
            }
            else
            {
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Stop();
                ms = 0;
            }
        }

        //verificar estado das zonas a cada x segundos definido na chamada deste metodo
        private async void CallMethodEveryXSecondsYTimes(int waitSeconds)
        {
            await Task.Run(() => {
                //var end = DateTime.Now.AddSeconds(durationSeconds);
                while (true)
                {
                    Dispatcher.BeginInvokeOnMainThread(() =>
                    {
                        Logar();
                    });
                    Thread.Sleep(waitSeconds * 1000);
                }
            });
        }

        private void btnTeste_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("!!!!", "!!!!", "Ok");
        }
    }
}