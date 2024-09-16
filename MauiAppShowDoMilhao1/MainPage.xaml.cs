
using MauiAppShowDoMilhao1;
using Plugin.Maui.Audio;

namespace ShowMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRendomPerguntaFacil();

            lbl_nivel.Text = "Facil";
            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString("C");

            //add som

            Stream track =
                FileSystem.OpenAppPackageFileAsync("0.mp3").Result;
            AudioManager.Current.CreatePlayer(track).Play();


        }


        private void toca_som()
        {
            string track = "";

            switch(pergunta_count) {

                case 1:
                    track = "1.wav";
                    break;

                    case 2:
        }
 


        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRendomPerguntaFacil();
        }

        private async void Button_Clicked_Proximo(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ( (bool) alt0.Value)
                {
                    acertou = true;
                    resp = alt0.Content.ToString();

                }
            }

            if (alt1.IsChecked)
            {
                if ((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();

                }
            }

            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();

                }
            }

            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();

                }
            }

            if (acertou)
            {
                await DisplayAlert("ACERTOU !!", resp, "ok");
                this.BindingContext = App.getRendomPerguntaFacil;
            }
            else
            {
                DisplayAlert("Você errou", "Você perdeu", "ok");

            }
        }


    }

}
