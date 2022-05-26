using pcso_rverdera.ViewModel;

namespace pcso_rverdera.View;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        // instead of doing new LoginViewModel
        // I can resolve it in constructor because I did register
        BindingContext = loginViewModel;
    }
}