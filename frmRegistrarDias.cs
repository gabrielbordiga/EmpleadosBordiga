using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestión_Empleados
{

    public partial class frmRegistrarDias : Form
    {

        public frmRegistrarDias()
        {
            InitializeComponent();

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector(); 
            Selector.Show(); 
            this.Hide(); 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarDias_Load(object sender, EventArgs e)
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

            StreamReader pr = new StreamReader("precio.txt");
            string Linea2 = "";
            while (pr.EndOfStream == false) 
            {
                Linea2 = pr.ReadLine();
                txtPrecio.AppendText(Linea2);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.dtpFecha.Value = DateTime.Now;
            this.cboEmpleado.SelectedIndex = -1;
            this.txtDetalle.Text = string.Empty;
            this.UnDia.Checked = false;
            this.MedioDia.Checked = false;
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string dia = "";
            string precio = "";
            if (this.UnDia.Checked)
            {
                dia = "1 Día";
                precio = txtPrecio.Text;
            }
            else if (this.MedioDia.Checked)
            {
                dia = "1/2 Día";
                double numero = Convert.ToDouble(this.txtPrecio.Text);
                precio = (numero / 2).ToString();
            }
            string valor = this.cboEmpleado.SelectedItem.ToString();
            StreamWriter sw = new StreamWriter(valor + ".txt", true);
            sw.Write(dtpFecha.Text + ", ");
            sw.Write(dia + ", ");
            sw.Write(txtDetalle.Text + ", ");
            sw.WriteLine(precio);
            this.cboEmpleado.SelectedIndex = -1;
            sw.Close();
            sw.Dispose();
            StreamWriter pr = new StreamWriter("Plata_" + valor + ".txt", true);
            pr.WriteLine(precio);
            pr.Close();
            pr.Dispose();
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
