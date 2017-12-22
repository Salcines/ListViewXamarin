using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LiveView
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();


        }

        private void Cmdclick_OnClicked(object sender, EventArgs e)
        {
            lblName.Text = "@SalcinesFran";
            lblName.BackgroundColor = Color.Blue;
            lblName.TextColor = Color.White;
            lblName.FontSize = 25;
        }
    }
}
