using AppMovil.ViewModels;

namespace AppMovil.Views;

public partial class ZapatoPage : ContentPage
{
    public ZapatoPage()
    {
        InitializeComponent();
        BindingContext = new ZapatoViewModel();
    }
}
