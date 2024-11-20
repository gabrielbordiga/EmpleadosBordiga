using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Gestión_Empleados
{
    public partial class frmPrecioPorDia : Form
    {
        System.Timers.Timer timer;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmPrecioPorDia()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(2);
            timer.Elapsed += OnTimedEvent;

            // Desactivar el timer por defecto
            timer.Enabled = false;
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdCargar2_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("INTRODUZCA EL PRECIO!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Quitar los puntos antes de guardar el valor en el archivo
                string valorSinPuntos = txtPrecio.Text.Replace(".", "");

                StreamWriter sw = new StreamWriter("precio.txt", false);
                sw.WriteLine(valorSinPuntos);
                sw.Close();
                sw.Dispose();

                txtPrecio.Text = null;
                MessageBox.Show("PRECIO MODIFICADO CORRECTAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e) 
        {
            

        }
        private void cmdVolver2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPrecio.Text == "")
                {
                    MessageBox.Show("INTRODUZCA EL PRECIO!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Quitar los puntos antes de guardar el valor en el archivo
                    string valorSinPuntos = txtPrecio.Text.Replace(".", "");

                    StreamWriter sw = new StreamWriter("precio.txt", false);
                    sw.WriteLine(valorSinPuntos);
                    sw.Close();
                    sw.Dispose();

                    txtPrecio.Text = null;
                    MessageBox.Show("PRECIO MODIFICADO CORRECTAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                this.Hide();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmPrecioPorDia_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmPrecioPorDia_Load(object sender, EventArgs e)
        {
            lblPrecioActual.Text = "";
            bool precioExiste = File.Exists("precio.txt");
            if (precioExiste)
            {
                StreamReader pr = new StreamReader("precio.txt");
                string Linea2 = "";
                while (pr.EndOfStream == false)
                {
                    Linea2 = pr.ReadLine();

                    // Verificar que sea un número válido
                    if (long.TryParse(Linea2, out long precioNumerico))
                    {
                        // Formatear el número con puntos de miles
                        lblPrecioActual.Text = "PRECIO ACTUAL: $" + precioNumerico.ToString("N0");
                    }
                    else
                    {
                        lblPrecioActual.Text = "PRECIO ACTUAL: $" + Linea2;  // Si no es un número válido, mostrar el texto original
                    }
                }
                pr.Close();
                pr.Dispose();
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            // Guardar la posición del cursor antes del formateo
            int cursorPosition = txtPrecio.SelectionStart;

            // Quitar los puntos existentes antes de reformatear
            string valorSinFormato = txtPrecio.Text.Replace(".", "");

            // Verificar que sea un número válido
            if (long.TryParse(valorSinFormato, out long valorNumerico))
            {
                // Formatear el número con puntos de miles
                txtPrecio.Text = valorNumerico.ToString("N0");

                // Restaurar la posición del cursor
                txtPrecio.SelectionStart = cursorPosition + (txtPrecio.Text.Length - valorSinFormato.Length);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            cmdVolver2_Click(sender, e);
        }
    }
}
