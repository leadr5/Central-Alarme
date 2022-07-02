using Mg_AlarmeApp.API;
using Plugin.Connectivity;
using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mg_AlarmeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        List<CentralAlarme> listCliente;
        public LoginPage()
        {
            InitializeComponent();
            listCliente = new List<CentralAlarme>();
        }

        public async void Logar()
        {
            //verificar se nao há campos vazios
            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                await DisplayAlert("Erro", "Informe o usuário e a senha", "Ok");
            }
            else
            {
                //verificar se há conexão com a internet
                if (CrossConnectivity.Current.IsConnected)
                {
                    listCliente = await ApiService.ObterCliente();
                    //verifica se o email e senha correspondem a algum usuário cadastrado
                    var cliente = listCliente.Where(x => x.usuario.ToLower() == txtEmail.Text.ToLower() && x.senha.ToLower() == txtSenha.Text.ToLower()).ToList();
                    if (cliente.Count > 0)
                        await Navigation.PushAsync(new InicialPage());
                    else
                        await DisplayAlert("Erro", "Login ou senha invalido", "Ok");
                }
                else
                {
                    await DisplayAlert("Erro", "Sem intetnet verifique a conexão", "Ok");
                }
            }
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Logar();
        }
    }
}