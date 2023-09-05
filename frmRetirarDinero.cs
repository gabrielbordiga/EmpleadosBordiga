using System;
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
            timer = new System.Timers.Timer(2);
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
                    bool existepaper = File.Exists("Plata_" + valor + ".txt");
                    if (existepaper == true)
                    {
                        restar = int.Parse(txtCuenta.Text);

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

                        timer.Enabled = !timer.Enabled;
                        txtCuenta.Text = null;
                    }
                    else if (existepaper == false)
                    {
                        StreamWriter caca = new StreamWriter("Plata_" + valor + ".txt");
                        caca.Close();
                        caca.Dispose();
                        MessageBox.Show("DESEA RETIRAR ESA CANTIDAD?", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        restar = int.Parse(txtCuenta.Text);

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

                        timer.Enabled = !timer.Enabled;
                        txtCuenta.Text = null;
                    }


                }
            }
            else 
            {
                MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        public void txtCuenta_click(object sender, EventArgs e)
        {

        }


        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
           
            
            List<int> numeros = new List<int>();
            StreamReader pr = new StreamReader("Cuenta" + valor + ".txt");
            string linea = pr.ReadLine();
            pr.Close();
            int numero = int.Parse(linea);
            int resto = restar;
            int resultado = numero - resto;

            Console.WriteLine(resultado);

            StreamWriter sr4 = new StreamWriter("Plata_" + valor + ".txt", true);
            sr4.WriteLine("-"+resto);
            sr4.Close();

            StreamWriter td = new StreamWriter(valor + ".txt", true);
            td.WriteLine("*** TOTAL DINERO ANTES DE RETIRO *** $"+numero);
            td.WriteLine("*** DINERO RETIRADO *** -$" + resto);
            td.WriteLine("*** TOTAL DESPUES DE RETIRO *** $" + resultado);
            td.Close();

            StreamWriter cc = new StreamWriter("TodosLosRetiros.txt", true);
            cc.WriteLine("El día " + dtpFecha.Text +" "+ valor + " retiró: $" + resto);
            cc.Close();

            StreamWriter sw = new StreamWriter("Cuenta" + valor + ".txt");

            sw.WriteLine(resultado);

            sw.Close();
            timer.Stop();
            MessageBox.Show("DINERO RETIRADO -$" + resto, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                frmTodosLosRetiros todosLosRetiros = new frmTodosLosRetiros(); todosLosRetiros.Show();
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
            if (e.KeyChar == (char)Keys.Enter)
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
                        restar = int.Parse(txtCuenta.Text);

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

                        timer.Enabled = !timer.Enabled;
                        txtCuenta.Text = null;


                    }
                }
                else
                {
                    MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
    }

}
