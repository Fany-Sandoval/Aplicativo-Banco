using Evaluacion.Models;

namespace Evaluacion;

public partial class Nuevo : ContentPage
{
    public Nuevo()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Obtener los valores ingresados en los campos de entrada
        string username = UsernameEntry.Text;
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;
        string confirmarPassword = ConfirmarPasswordEntry.Text;
        string telefono = TelefonoEntry.Text;

        // Validar que los campos no est�n vac�os y que las contrase�as coincidan (puedes agregar m�s validaciones seg�n tus necesidades)
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmarPassword) || string.IsNullOrWhiteSpace(telefono))
        {
            StatusLabel.Text = "Por favor, complete todos los campos.";
        }
        else if (password != confirmarPassword)
        {
            StatusLabel.Text = "Las contrase�as no coinciden.";
        }
        else
        {
            // Crear una instancia de Usuario y asignar los valores
            Usuario usuario = new Usuario
            {
                UserName = username,
                Email = email,
                Password = password,
                Telefono = telefono
            };
            // Mostrar el mensaje de registro exitoso
            StatusLabel.Text = $"Usuario Registrado:\nNombre: {usuario.UserName}\nEmail: {usuario.Email}\nTel�fono: {usuario.Telefono}";
        }
    }
}