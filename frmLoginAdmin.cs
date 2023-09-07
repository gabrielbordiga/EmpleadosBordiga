using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestión_Empleados
{
    public partial class frmLoginAdmin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            
            frmInicio Inicio = new frmInicio();
            Inicio.Show();
            this.Hide();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            // Obtener el usuario y la contraseña del TextBox
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            // Validar los datos
            if (usuario == "admin" && contraseña == "45352684")
            {
                // Crear una instancia del formulario principal
                frmAdmin Admin = new frmAdmin();
                // Mostrar el formulario principal
                Admin.Show();
                // Ocultar el formulario de login
                this.Hide();
            }
            else
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                // Obtener el usuario y la contraseña del TextBox
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
                // Validar los datos
                if (usuario == "admin" && contraseña == "45352684")
                {
                    // Crear una instancia del formulario principal
                    frmAdmin Admin = new frmAdmin();
                    // Mostrar el formulario principal
                    Admin.Show();
                    // Ocultar el formulario de login
                    this.Hide();
                }
                else
                {
                    // Mostrar un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
