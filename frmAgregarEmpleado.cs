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
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("empleados.txt", true);
            sw.WriteLine(txtEmpleado.Text);
            sw.Close();
            sw.Dispose();
        }

        private void cmdBorrarTodo_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("empleados.txt", false);
            sw.WriteLine(txtEmpleado.Text);
            sw.Close();
            sw.Dispose();
        }
    }
}
