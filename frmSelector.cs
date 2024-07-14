﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Gestión_Empleados
{
    public partial class frmSelector : Form
    {
        private System.Windows.Forms.Timer timer;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmSelector()
        {
            InitializeComponent();
            // Inicializar el Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo de 1 segundo (1000 milisegundos)
            timer.Tick += new EventHandler(Timer_Tick); // Suscribirse al evento Tick del Timer
            timer.Start(); // Iniciar el Timer

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Código que se ejecutará cada segundo
            txtPrecio.Text = "";
            bool precioExiste = File.Exists("precio.txt");
            if (precioExiste)
            {


                StreamReader pr = new StreamReader("precio.txt");
                string Linea2 = "";
                while (pr.EndOfStream == false)
                {
                    Linea2 = pr.ReadLine();
                    txtPrecio.AppendText("(Precio actual $" + Linea2 + ")");
                }
                pr.Close();
                pr.Dispose();
            }


        }
        private void cmdRegistrarDias_Click(object sender, EventArgs e)
        {
            bool existe = File.Exists("precio.txt");
            if (existe) 
            {                
               frmRegistrarDias RegistrarDias = new frmRegistrarDias();
               RegistrarDias.Show();
               this.Hide();              
            }
            else 
            {
                MessageBox.Show("FALTA AGREGAR EL PRECIO", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmPrecioPorDia PrecioPorDia = new frmPrecioPorDia();
                PrecioPorDia.Show();
                
            }
    
        }

        private void cmdAñadirEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado AgregarEmpleado = new frmAgregarEmpleado(); 
            AgregarEmpleado.Show(); 
            this.Hide();
        }

        private void cmdModificarPrecio_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.PRecioPorDia();
             
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCuentaEmpleado_Click(object sender, EventArgs e)
        {
            CuentaEmpleado Cuenta = new CuentaEmpleado(); Cuenta.Show();
            this.Hide();
        }

        private void cmdRetirarDinero_Click(object sender, EventArgs e)
        {
            frmRetirarDinero retirarDinero = new frmRetirarDinero(); retirarDinero.Show();
            this.Hide();
        }

        private void cmdDetalles_Click(object sender, EventArgs e)
        {
            frmDetalles Detalles = new frmDetalles(); Detalles.Show();
            this.Hide();
        }

        private void frmSelector_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Archivos");
            Directory.CreateDirectory("Archivos/Detalles");
            Directory.CreateDirectory("Archivos/Retiros");
            bool archivo = File.Exists("empleados.txt");
            if (archivo == false)
            {                         
              StreamWriter escribir = new StreamWriter("empleados.txt");                 
              escribir.Close();
              escribir.Dispose();              
            }
            bool precioExiste = File.Exists("precio.txt");
            if (precioExiste)
            {
                

                StreamReader pr = new StreamReader("precio.txt");
                string Linea2 = "";
                while (pr.EndOfStream == false)
                {
                    Linea2 = pr.ReadLine();
                    txtPrecio.AppendText("(Precio actual $" + Linea2 + ")");
                }
                pr.Close();
                pr.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
