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
        public frmDetalles()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
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
                MessageBox.Show("Seleccionar Empleado");

            }
        }
    }
}
