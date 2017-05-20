using Xamarin.Forms;

namespace ScrollView.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var scrollVIew = new Xamarin.Forms.ScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 0,
                    WidthRequest = 100,
                    Children =
                    {
                        new BoxView
                        {
                            Color = Color.Blue,
                            HeightRequest = 500,
                        },
                    
                        new BoxView
                        {
                            Color = Color.Yellow,
                            HeightRequest = 500,
                        },
                    
                        new BoxView
                        {
                            Color = Color.Red,
                            HeightRequest = 500,
                        },
                    },
                }
            };

            //UIにStackLayoutをバインドする
            Content = scrollVIew;
        }
    }
}
