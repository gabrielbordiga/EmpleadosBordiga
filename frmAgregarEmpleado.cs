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
            
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("empleados.txt");
            string Linea = "";
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                listBox1.Items.Add(Linea);
            }

            sr.Close();
            sr.Dispose();
            this.txtEmpleado.Clear();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdBorrarTodo_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("empleados.txt", false);
            sw.WriteLine(txtEmpleado.Text);
            sw.Close();
            sw.Dispose();
        }

        private void cmdVolver_Click_1(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }

        private void cmdCargare_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("empleados.txt", true);
            sw.WriteLine(txtEmpleado.Text);
            sw.Close();
            sw.Dispose();
            listBox1.DataSource = null;
            listBox1.Refresh();
            MessageBox.Show("Se añadió correctamente");
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader("empleados.txt");
            string Linea = "";
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                listBox1.Items.Add(Linea);
            }


            sr.Close();
            sr.Dispose();
            txtEmpleado.Text = "";

        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader("empleados.txt");
            string Linea = "";
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                listBox1.Items.Add(Linea);
            }
            

            sr.Close();
            sr.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            string s = item.ToString();

            StreamReader reader = new StreamReader("empleados.txt");

            StreamWriter writer = new StreamWriter("temp.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {

                if (!line.Contains(s))
                {

                    writer.WriteLine(line);

                }
            }
            MessageBox.Show("Se eliminó correctamente");


            reader.Close();
            writer.Close();


            File.Delete("empleados.txt");
            File.Move("temp.txt", "empleados.txt");
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader("empleados.txt");
            string Linea = "";
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                listBox1.Items.Add(Linea);
            }


            sr.Close();
            sr.Dispose();

        }
    }
}
