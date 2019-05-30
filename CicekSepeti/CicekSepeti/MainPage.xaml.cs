using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CicekSepeti
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Menu_Clicked(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Navigation.PushModalAsync(menu);

        }

        private void Cicekler_Clicked(object sender, EventArgs e)
        {

        }
    }
}
