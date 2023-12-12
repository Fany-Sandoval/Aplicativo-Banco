using Evaluacion.Models;
using Microsoft.Maui.Controls;

namespace Evaluacion
{
    public partial class Bienvenido : ContentPage
    {
        public Bienvenido(Usuario usuario)
        {
            InitializeComponent();

            // Obtener el Label desde el archivo XAML por su nombre
            Label usuarioLabel = (Label)FindByName("UsuarioLabel");

            // Mostrar los datos del usuario en el Label
            usuarioLabel.Text = $"¡Bienvenido, {usuario.UserName}!";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
