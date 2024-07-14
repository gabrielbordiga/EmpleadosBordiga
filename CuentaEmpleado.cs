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
    public partial class CuentaEmpleado : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public CuentaEmpleado()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }

        private void CuentaEmpleado_Load(object sender, EventArgs e)
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

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1)
            {
                string valor = this.cboEmpleado.SelectedItem.ToString();
                bool existe = File.Exists(valor + ".txt");
                if (existe == true) 
                {
                    List<int> numeros = new List<int>();


                    StreamReader sr = new StreamReader("Plata_" + valor + ".txt");
                    string linea = sr.ReadLine();
                    while (linea != null)
                    {
                        int numero = int.Parse(linea);
                        numeros.Add(numero);
                        linea = sr.ReadLine();
                    }
                    sr.Close();

                    foreach (int n in numeros)
                    {
                        Console.WriteLine(n);


                    }
                    StreamWriter sw = new StreamWriter("Cuenta" + valor + ".txt");

                    sw.WriteLine(numeros.Sum());

                    sw.Close();



                    StreamReader pr = new StreamReader("Cuenta" + valor + ".txt");
                    string Linea2 = "";
                    while (pr.EndOfStream == false)
                    {
                        txtCuenta.Text = "";
                        Linea2 = pr.ReadLine();
                        txtCuenta.AppendText("Saldo: $" + Linea2);

                    }
                    pr.Close();
                }
                else
                {
                    MessageBox.Show("NO TIENE DINERO EN CUENTA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else 
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
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

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCuenta.Text = "";
            if (cboEmpleado.SelectedIndex != -1)
            {
                string valor = this.cboEmpleado.SelectedItem.ToString();
                bool existe = File.Exists(valor + ".txt");
                if (existe == true)
                {
                    List<double> numeros = new List<double>();

                    StreamReader sr = new StreamReader("Plata_" + valor + ".txt");
                    string linea = sr.ReadLine();
                    while (linea != null)
                    {
                        if (double.TryParse(linea, out double numero))
                        {
                            numeros.Add(numero);
                        }
                        else
                        {
                            MessageBox.Show($"El formato de la línea '{linea}' no es válido y no se puede convertir a un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        linea = sr.ReadLine();
                    }
                    sr.Close();

                    foreach (double n in numeros)
                    {
                        Console.WriteLine(n);
                    }

                    StreamWriter sw = new StreamWriter("Cuenta" + valor + ".txt");
                    sw.WriteLine(numeros.Sum());
                    sw.Close();

                    StreamReader pr = new StreamReader("Cuenta" + valor + ".txt");
                    string Linea2 = "";
                    while (!pr.EndOfStream)
                    {
                        Linea2 = pr.ReadLine();
                        txtCuenta.AppendText("$" + Linea2);
                    }
                    pr.Close();
                }
                else
                {
                    MessageBox.Show("NO TIENE DINERO EN CUENTA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
