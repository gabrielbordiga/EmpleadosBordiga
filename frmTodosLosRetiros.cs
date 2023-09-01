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
    public partial class frmTodosLosRetiros : Form
    {
        string fecha = DateTime.Now.ToString("dd-MM-yyyy");
        string hora = DateTime.Now.ToString("HH.mm.ss");
        public frmTodosLosRetiros()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmRetirarDinero retirarDinero = new frmRetirarDinero();
            retirarDinero.Show();
            this.Hide();
            bool archivo = File.Exists("TodosLosRetiros.txt");
            if (archivo == false) 
            {
                File.Create("TodosLosRetiros.txt");
            }

        }

        private void frmTodosLosRetiros_Load(object sender, EventArgs e)
        {
            lsbTodosRetiros.Items.Clear();
            StreamReader sr = new StreamReader("TodosLosRetiros.txt");
            while (!sr.EndOfStream)
            {
                lsbTodosRetiros.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void cmdBorrarTodo_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("SE ARCHIVARÁN TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                lsbTodosRetiros.DataSource = null;
                lsbTodosRetiros.Items.Clear();
                string origen = "TodosLosRetiros.txt";
                string destino = "Archivos/Retiros/TodosLosRetiros " + hora + " " + fecha + ".txt";
                File.Move(origen, destino);
                
            }
            else
            {
                
            }

        }

        private void lsbTodosRetiros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

