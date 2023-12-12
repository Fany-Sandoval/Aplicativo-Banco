using Evaluacion.Models;

namespace Evaluacion;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Obtener los valores ingresados en los campos de entrada
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;
        // Crear una instancia de Usuario y asignar los valores
        Usuario usuario = new Usuario
        {
            UserName = username,
            Password = password
        };
        Navigation.PushAsync(new Bienvenido(usuario));
    }
}