namespace assesment_try1;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private async void OnHomeTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnAboutTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlertAsync("About", "Power Hunter - Battery Usage Tracker", "OK");
    }
}