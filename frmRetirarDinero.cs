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
    public partial class frmRetirarDinero : Form
    {
        public frmRetirarDinero()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            string valor = this.cboEmpleado.SelectedItem.ToString();
            List<int> numeros = new List<int>();
            StreamReader pr = new StreamReader("Plata_" + valor + ".txt");
            string linea = pr.ReadLine();
            pr.Close();
            int numero = int.Parse(linea);
            int resto = int.Parse(txtCuenta.Text);
            int resultado = numero - resto;
            
            Console.WriteLine(resultado);

            StreamWriter mrw = new StreamWriter("Plata_" + valor + ".txt");

            mrw.WriteLine(resultado);

            mrw.Close();
        }
    }
}
