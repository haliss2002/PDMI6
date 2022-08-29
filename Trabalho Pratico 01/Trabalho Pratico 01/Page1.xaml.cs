using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trabalho_Pratico_01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            AbsoluteLayout absolute = new AbsoluteLayout();
            var titulo1 = new Label
            {
                Text = "Aplicação",
                FontSize = 30,
                WidthRequest = 200,
                HeightRequest =  100
         
            };
            var titulo2 = new Label
            {
                Text = "Teste",
                FontSize = 30,
                WidthRequest = 200,
                HeightRequest = 100

            };
            var labelid = new Label
            {
                Text = "ID:",
                FontSize = 20,
                WidthRequest = 200,
                HeightRequest = 60
            };
            var entryid = new Entry
            {
                FontSize = 10,
                WidthRequest = 300,
                HeightRequest = 35
            };
            var labelpass = new Label
            {
                Text = "PASS:",
                FontSize = 20,
                WidthRequest = 200,
                HeightRequest = 60
            };
            var entrypass = new Entry
            {
                FontSize = 10,
                WidthRequest = 300,
                HeightRequest = 35
            };
            var buttonok = new Button
            {
                Text = "OK",
                TextColor = Color.Red,
                WidthRequest = 300,
                HeightRequest = 35
            };
            var buttonlimpar = new Button
            {
                Text = "Limpar",
                TextColor = Color.Red,
                WidthRequest = 300,
                HeightRequest = 35
            };
            var buttonCreditos = new Button
            {
                Text = "Créditos",
                TextColor = Color.Red,
                WidthRequest = 300,
                HeightRequest = 35
            };
            var labelCreditos = new Label
            {
                Text = "Créditos",
                TextColor = Color.Red,
                WidthRequest = 200,
                HeightRequest = 90
            };
   
            absolute.Children.Add(titulo1, new Point(100,20));
            absolute.Children.Add(titulo2, new Point(240, 20));
            absolute.Children.Add(labelid, new Point(40,80));
            absolute.Children.Add(entryid, new Point(70,80));
            absolute.Children.Add(labelpass, new Point(20,120));
            absolute.Children.Add(entrypass, new Point(70,120));
            absolute.Children.Add(buttonok, new Point(45,170));
            absolute.Children.Add(buttonlimpar, new Point(45,220));
            absolute.Children.Add(buttonCreditos, new Point(45,270));
            absolute.Children.Add(labelCreditos, new Point(45, 320));

            buttonok.Clicked += async (sender, args) => Button_Clicked(sender, args);
            buttonlimpar.Clicked+= async (sender, args) => Button_Clicked_1(sender, args);
            buttonCreditos.Clicked += async (sender, args) => Button_Clicked_2(sender, args);
           
            void Button_Clicked(object sender, EventArgs e)
            {
                try
                {
                    if (entryid.Text == "admin" && entrypass.Text == "senha@dmin")
                    {
                        labelCreditos.TextColor = Color.Green;
                        labelCreditos.Text = "Login Com Sucesso";

                    }
                    else
                    {
                        labelCreditos.TextColor = Color.Red;
                        labelCreditos.Text = "login não autorizado";
                    }

                }
                catch
                {
                    labelCreditos.Text = "Erro não indentificado";
                }
            }

             void Button_Clicked_1(object sender, EventArgs e)
            {
                entryid.Text = "";
                entrypass.Text = "";

            }

            void Button_Clicked_2(object sender, EventArgs e)
            {
                labelCreditos.TextColor = Color.Blue;
                labelCreditos.Text = "Autores: Halisson de Oliveira Sousa e Marcel Crudelli";

            }            
            /*
             Desenvolvido Por: Halisson De Oliveira Sousa,
            Marcel Crudelli
            */
        }

    }
}