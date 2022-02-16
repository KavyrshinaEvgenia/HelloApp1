using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Label label1 = new Label()
            {
                Text = "Кавыршина Евгения",
                TextColor = Color.Black
            };
            Label label2 = new Label()
            {
                Text = "ПКС-31",
                TextColor = Color.Red
            };
            //Image image = new Image { Source = "9a2c30f67f83ecaea1635b57af2c3623de81d840_hq (1).jpg" };
            //this.Content = image;

        }
    }
}
