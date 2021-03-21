using RealPromo.Models;
using RealPromo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RealPromo
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<Promocao> lista = new ObservableCollection<Promocao>();

        public MainPage()
        {
            InitializeComponent();
            //GetPromocoes();
            ListViewPromocao.ItemsSource = lista;

            new RealPromoSignalR(lista);


            /**
            Device.StartTimer(TimeSpan.FromSeconds(10),() => {
                lista.Add(new Promocao { Empresa = "Carrefour", Chamada = "TV em promoções" +DateTime.Now.ToString(), Regras = "10 unidades", EnderecoURL = "http://www.carrefour.com.br" });
                return true;
            });**/
        }
        /**
        private void GetPromocoes()
        {
            lista.Add(new Promocao{Empresa="Carrefour",Chamada = "TV em promoções", Regras = "10 unidades",EnderecoURL = "http://www.carrefour.com.br"});
            lista.Add(new Promocao{Empresa="Carrefour",Chamada = "Notebooks", Regras = "20 unidades",EnderecoURL = "http://www.carrefour.com.br"});
        }**/
    }
}
