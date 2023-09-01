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
    public partial class frmPrecioPorDia : Form
    {
        public frmPrecioPorDia()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdCargar2_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "") 
            {
                MessageBox.Show("Introduzca el precio!");
            }
            else 
            {
                StreamWriter sw = new StreamWriter("precio.txt", false);
                sw.WriteLine(txtPrecio.Text);
                sw.Close();
                sw.Dispose();
                txtPrecio.Text = null;
                MessageBox.Show("Precio modificado correctamente!");
            }
        }

        private void cmdVolver2_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtPrecio.Text == "")
                {
                    MessageBox.Show("Introduzca el precio!");
                }
                else
                {
                    StreamWriter sw = new StreamWriter("precio.txt", false);
                    sw.WriteLine(txtPrecio.Text);
                    sw.Close();
                    sw.Dispose();
                    txtPrecio.Text = null;
                    MessageBox.Show("Precio modificado correctamente!");
                }
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
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
