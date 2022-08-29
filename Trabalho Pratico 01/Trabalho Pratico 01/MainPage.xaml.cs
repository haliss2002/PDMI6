using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trabalho_Pratico_01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "admin" && senha.Text == "senha@dmin")
                {
                    Creditos.TextColor = Color.Green;
                    Creditos.Text = "Login Com Sucesso";

                }
                else
                {
                    Creditos.TextColor = Color.Red;
                    Creditos.Text = "login não autorizado";
                }

            }
            catch
            {
                Creditos.Text = "Erro não indentificado";
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            id.Text = "";
            senha.Text = "";

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Creditos.TextColor = Color.Blue;
            Creditos.Text = "Autores: Halisson de Oliveira Sousa e Marcel Crudelli";

        }
        /*
            Desenvolvido Por: Halisson De Oliveira Sousa,
            Marcel Crudelli
            */
    }
}
