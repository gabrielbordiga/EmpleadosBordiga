﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Runtime.InteropServices;

namespace Gestión_Empleados
{
    public partial class frmRetirarDinero : Form
    {
        string formadepago = "";
        System.Timers.Timer timer;
        public string valor = "";
        public int restar = 0;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmRetirarDinero()
        {
            InitializeComponent();
            // Inicializar el timer con un intervalo de 2000 milisegundos y suscribirlo al evento Elapsed
            timer = new System.Timers.Timer(500);  // Ajuste del intervalo a 700 ms
            timer.Elapsed += OnTimedEvent;

            // Desactivar el timer por defecto
            timer.Enabled = false;
        }

        private void frmRetirarDinero_Load(object sender, EventArgs e)
        {
            this.dtpFecha.Value = DateTime.Now;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (optEfectivo.Checked)
            {
                formadepago = "EFECTIVO";
            }
            else
            {
                formadepago = "TRANSFERENCIA";
            }

            bool existe = File.Exists("Plata_" + valor + ".txt");
            if (existe == true)
            {
                DateTime fechaActual = DateTime.Now;
                DateTime fechaSeleccionado = dtpFecha.Value;
                if (fechaSeleccionado <= fechaActual)
                {
                    if (txtCuenta.Text == "")
                    {
                        MessageBox.Show("INTRODUZCA LA CANTIDAD", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cboEmpleado.SelectedIndex == -1)
                    {
                        MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Quitar los puntos antes de convertir el valor en número
                        restar = int.Parse(txtCuenta.Text.Replace(".", ""));

                        List<double> numeros = new List<double>();
                        StreamReader srr = new StreamReader("Plata_" + valor + ".txt");
                        string linea = srr.ReadLine();
                        while (linea != null)
                        {
                            double numero = double.Parse(linea);
                            numeros.Add(numero);
                            linea = srr.ReadLine();
                        }
                        srr.Close();
                        srr.Dispose();

                        // Guardar el saldo sin formato
                        StreamWriter srr2 = new StreamWriter("Cuenta" + valor + ".txt");
                        srr2.WriteLine(numeros.Sum());
                        srr2.Close();

                        // Mostrar el saldo formateado en txtCuenta
                        txtCuenta.Text = numeros.Sum().ToString("N0");

                        if (!timer.Enabled)  // Verificación para evitar duplicaciones
                        {
                            timer.Start();
                        }

                        txtCuenta.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("NO HAY DINERO CARGADO EN ESTE EMPLEADO", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void txtCuenta_click(object sender, EventArgs e)
        {
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            List<double> numeros = new List<double>();
            StreamReader pr = new StreamReader("Cuenta" + valor + ".txt");
            string linea = pr.ReadLine();
            pr.Close();
            double numero = double.Parse(linea);
            double resto = restar;
            double resultado = numero - resto;

            Console.WriteLine(resultado);

            // Guardar sin formato en el archivo
            StreamWriter sr4 = new StreamWriter("Plata_" + valor + ".txt", true);
            sr4.WriteLine("-" + resto);
            sr4.Close();

            // Guardar en el log sin formato
            StreamWriter td = new StreamWriter(valor + ".txt", true);
            //td.WriteLine("** PLATA ANTES DE RETIRO ** $" + numero);
            td.WriteLine("** " + dtpFecha.Text + " PLATA RETIRADA EN " + formadepago + " ** -$" + resto);
            td.WriteLine("(Antes total cuenta: $" + numero + ", Después total cuenta: $" + resultado + ")");
            td.Close();

            StreamWriter cc = new StreamWriter("TodosLosRetiros.txt", true);
            cc.WriteLine("El día " + dtpFecha.Text + " " + valor + " retiró en " + formadepago + " : $" + resto);
            cc.Close();

            // Guardar sin formato en el archivo de cuenta
            StreamWriter sw = new StreamWriter("Cuenta" + valor + ".txt");
            sw.WriteLine(resultado);
            sw.Close();

            // Detener el timer y mostrar el mensaje
            timer.Stop();
            MessageBox.Show("DINERO RETIRADO EN " + formadepago + " -$" + resto, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor2 = this.cboEmpleado.SelectedItem.ToString();
            valor = valor2;
        }

        private void cmdTodosLosRetiros_Click(object sender, EventArgs e)
        {
            bool existe = File.Exists("TodosLosRetiros.txt");

            if (existe == true)
            {
                frmTodosLosRetiros todosLosRetiros = new frmTodosLosRetiros();
                todosLosRetiros.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("NO HAY RETIROS", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmSelector Selector = new frmSelector();
                Selector.Show();
                this.Hide();
            }
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && !timer.Enabled)  // Asegurarse que no se ejecute más de una vez
            {
                pictureBox1_Click(sender, e);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            // Guardar la posición del cursor antes del formateo
            int cursorPosition = txtCuenta.SelectionStart;

            // Quitar los puntos existentes antes de reformatear
            string valorSinFormato = txtCuenta.Text.Replace(".", "");

            // Verificar que sea un número válido
            if (long.TryParse(valorSinFormato, out long valorNumerico))
            {
                // Formatear el número con puntos de miles
                txtCuenta.Text = valorNumerico.ToString("N0");

                // Restaurar la posición del cursor
                txtCuenta.SelectionStart = cursorPosition + (txtCuenta.Text.Length - valorSinFormato.Length);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }
    }

}
