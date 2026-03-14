namespace assesment_try1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSettingsClicked(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }

    private async void OnHomeClicked(object sender, TappedEventArgs e)
    {
        await DisplayAlertAsync("Home", "You are already on the Home page.", "OK");
    }

    private async void OnAboutClicked(object sender, TappedEventArgs e)
    {
        await DisplayAlertAsync("About", "Power Hunter - Battery Usage Tracker", "OK");
    }
}