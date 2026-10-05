using System;
using System.Windows.Forms;

namespace SistemaGrupo3
{
    /// <summary>
    /// Formulario de inicio de sesión del sistema.
    /// </summary>
    public partial class FormLogin : Form
    {
        // Credenciales de demostración
        private const string UsuarioDemo = "admin";
        private const string ContrasenaDemo = "1234";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Debe ingresar el usuario y la contraseña.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar credenciales
            if (usuario == UsuarioDemo && contrasena == ContrasenaDemo)
            {
                this.Hide();
                Form1 principal = new Form1();
                principal.FormClosed += (s, args) => this.Close();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
