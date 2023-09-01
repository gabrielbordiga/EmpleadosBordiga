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

namespace Gestión_Empleados
{
    public partial class CuentaEmpleado : Form
    {
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
            
            string valor = this.cboEmpleado.SelectedItem.ToString();
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
    }
}
