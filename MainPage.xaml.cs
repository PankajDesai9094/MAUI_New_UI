namespace MAUI_New_UI
{
    public partial class MainPage : ContentPage
    {
        double data;
        public MainPage()
        {
            InitializeComponent();
            double density = DeviceDisplay.Current.MainDisplayInfo.Density; // Get display density
            double screenWidth = DeviceDisplay.Current.MainDisplayInfo.Width / density; // Adjust width with density
            data = screenWidth / 2 - 30;
            frmTab1.WidthRequest = data;
        }

        protected async override void OnAppearing()
        {
            await frmSun.TranslateTo(0, -140, 0);
            base.OnAppearing();
        }

        private async void tabBtn1_Clicked(object sender, EventArgs e)
        {
            await txtTab.FadeTo(0, 0);
            txtTab.Text = "Morning Login";
            frmTab1.TranslateTo(0, 0, 500);
            frmSun.TranslateTo(0, -140, 500);
            grdSColorTop.Color = Color.FromHex("#821f75");
            grdSColorBottom.Color = Color.FromHex("#edad9d");
            txtTab.FadeTo(1, 500);
        }

        private async void tabBtn2_Clicked(object sender, EventArgs e)
        {
            await txtTab.FadeTo(0, 0);
            txtTab.Text = "Night Login";
            frmSun.TranslateTo(0, 0, 500);
            grdSColorTop.Color = Color.FromHex("#0d1438");
            grdSColorBottom.Color = Color.FromHex("#2c4891");
            frmTab1.TranslateTo(data, 0, 500);
            txtTab.FadeTo(1, 500);
        }

    }

}
