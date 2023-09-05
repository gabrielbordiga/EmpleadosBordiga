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
                StreamWriter sw = new StreamWriter("precio.txt", false);
                sw.WriteLine(txtPrecio.Text);
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
                    StreamWriter sw = new StreamWriter("precio.txt", false);
                    sw.WriteLine(txtPrecio.Text);
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
    }
}
