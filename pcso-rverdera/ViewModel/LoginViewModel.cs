using CommunityToolkit.Mvvm.ComponentModel;

namespace pcso_rverdera.ViewModel;

public partial class LoginViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;
}
