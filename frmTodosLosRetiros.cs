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
using System.Windows.Forms;

namespace Gestión_Empleados
{
    public partial class frmTodosLosRetiros : Form
    {
        string fecha = DateTime.Now.ToString("dd-MM-yyyy");
        string hora = DateTime.Now.ToString("HH.mm.ss");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmTodosLosRetiros()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmRetirarDinero retirarDinero = new frmRetirarDinero();
            retirarDinero.Show();
            this.Hide();
            bool archivo = File.Exists("TodosLosRetiros.txt");
            if (archivo == false) 
            {
                File.Create("TodosLosRetiros.txt");
            }

        }

        private void frmTodosLosRetiros_Load(object sender, EventArgs e)
        {
            bool existe = File.Exists("TodosLosRetiros.txt");

            if (existe == true)
            {
                lsbTodosRetiros.Items.Clear();
                StreamReader sr = new StreamReader("TodosLosRetiros.txt");
                while (!sr.EndOfStream)
                {
                    lsbTodosRetiros.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            else 
            {
                MessageBox.Show("NO HAY RETIROS", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void cmdBorrarTodo_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("SE ARCHIVARÁN TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                lsbTodosRetiros.DataSource = null;
                lsbTodosRetiros.Items.Clear();
                string origen = "TodosLosRetiros.txt";
                string destino = "Archivos/Retiros/TodosLosRetiros " + hora + " " + fecha + ".txt";
                File.Move(origen, destino);
                
            }
            else
            {
                
            }

        }

        private void lsbTodosRetiros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("QUIERES VER LOS ARCHIVOS?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string Ruta = System.AppDomain.CurrentDomain.BaseDirectory + "Archivos\\Retiros";
                System.Diagnostics.Process.Start("explorer.exe", Ruta);
            }
            else if (dialogResult == DialogResult.No)
            {
                // No hacer nada
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}

