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
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestión_Empleados
{
    public partial class frmDetalles : Form
    {
        System.Timers.Timer timer;
        public string valor = "";
        public int restar = 0;
        string fecha = DateTime.Now.ToString("dd-MM-yyyy");
        string hora = DateTime.Now.ToString("HH.mm.ss");

        public frmDetalles()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(2);
            timer.Elapsed += OnTimedEvent;

            // Desactivar el timer por defecto
            timer.Enabled = false;
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
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            
            string origen = (valor + ".txt");
            string destino = "Archivos/Detalles/Detalles de " + valor + hora + " " + fecha + ".txt";
            File.Move(origen, destino);

        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdArchivar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1)
            {
                string valor = cboEmpleado.SelectedItem.ToString();
                var respuesta = MessageBox.Show("SE ARCHIVARÁN TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK)
                {
                    List<int> numeros = new List<int>();
                    StreamReader srr = new StreamReader("Plata_" + valor + ".txt");
                    string linea = srr.ReadLine();
                    while (linea != null)
                    {
                        int numero = int.Parse(linea);
                        numeros.Add(numero);
                        linea = srr.ReadLine();
                    }
                    srr.Close();

                    foreach (int n in numeros)
                    {
                        Console.WriteLine(n);


                    }

                    StreamWriter srr2 = new StreamWriter("Cuenta" + valor + ".txt");

                    srr2.WriteLine(numeros.Sum());

                    srr2.Close();

                    bool existe = File.Exists("Cuenta" + valor + ".txt");
                    if (existe == true)
                    {
                        List<int> numeros2 = new List<int>();
                        StreamReader pr = new StreamReader("Cuenta" + valor + ".txt");
                        string linea2 = pr.ReadLine();
                        pr.Close();
                        int numero = int.Parse(linea2);
                        StreamWriter td = new StreamWriter(valor + ".txt", true);
                        td.WriteLine("*** TOTAL DINERO AL ARCHIVAR *** $" + numero);
                        td.Close();

                        listbox.DataSource = null;
                        listbox.Items.Clear();
                        string origen = (valor + ".txt");
                        string destino = "Archivos/Detalles/Detalles de " + valor + hora + " " + fecha + ".txt";
                        File.Move(origen, destino);
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUDO ARCHIVAR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }
            else 
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1) 
            {
                string valor = cboEmpleado.SelectedItem.ToString();
                System.Diagnostics.Process.Start(valor + ".txt");
            }
            else 
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }    
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            
            DialogResult dialogResult = MessageBox.Show("QUIERES VER LOS ARCHIVOS?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string Ruta = System.AppDomain.CurrentDomain.BaseDirectory + "Archivos\\Detalles";
                System.Diagnostics.Process.Start("explorer.exe", Ruta);
            }
            else if (dialogResult == DialogResult.No)
            {
                // No hacer nada
            }
        }

    }
}
