using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_Empleados
{
    public partial class frmDetalles : Form
    {
        string fecha = DateTime.Now.ToString("dd-MM-yyyy");
        string hora = DateTime.Now.ToString("HH.mm.ss");
        public frmDetalles()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
            bool archivo = File.Exists("Detalles.txt");
           if (archivo == false)
           {
                File.Create("Detalles.txt");
           }
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("empleados.txt");
            string Linea = "";
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                cboEmpleado.Items.Add(Linea);
            }

            sr.Close();
            sr.Dispose();
        }

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            string valor = "";
            if (this.cboEmpleado.SelectedItem != null)
            {
                valor = this.cboEmpleado.SelectedItem.ToString();
            }
            else
            {
                // Mostrar un mensaje de error o elegir un valor por defecto
            }
            List<int> numeros = new List<int>();

            List<string> lista = new List<string>();
            string ruta = valor + ".txt";
            if (File.Exists(ruta))
            {
                listbox.Items.Clear();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    listbox.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("SELECCIONAR EMPLEADO", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdArchivar_Click(object sender, EventArgs e)
        {
            string empleado = cboEmpleado.SelectedItem.ToString();
            var respuesta = MessageBox.Show("SE ARCHIVARÁN TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                listbox.DataSource = null;
                listbox.Items.Clear();
                string origen = (empleado + ".txt");
                string destino = "Archivos/Detalles/Detalles de " + empleado + hora + " " + fecha + ".txt";
                File.Move(origen, destino);

            }
            else
            {

            }
        }
    }
}
