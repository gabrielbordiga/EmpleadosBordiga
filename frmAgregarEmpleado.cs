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
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Timers;

namespace Gestión_Empleados
{
    public partial class frmAgregarEmpleado : Form
    {
        System.Timers.Timer timer;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        public frmAgregarEmpleado()
        {
            InitializeComponent();
            // Inicializar el timer con un intervalo de 2000 milisegundos y suscribirlo al evento Elapsed
            timer = new System.Timers.Timer(200);
            timer.Elapsed += OnTimedEvent;

            // Desactivar el timer por defecto
            timer.Enabled = false;
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e) 
        {
            
            timer.Stop();
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
            string valor = txtEmpleado.Text;
            bool existe = File.Exists("empleados.txt");
            bool existe2 = false;
            if (existe == true) 
            {
                StreamReader srg = new StreamReader("empleados.txt");
                string Linea = "";
                while (srg.EndOfStream == false)
                {
                    Linea = srg.ReadLine();
                    if (Linea == valor) 
                    {
                        existe2 = true;
                    }
                }
                srg.Close();
                srg.Dispose();
            }
            if (existe2 == false)
            {
                if (txtEmpleado.Text != "")
                {
                    StreamWriter sw = new StreamWriter("empleados.txt", true);
                    sw.WriteLine(txtEmpleado.Text);
                    sw.Close();
                    sw.Dispose();
                    listBox1.DataSource = null;
                    listBox1.Refresh();
                    MessageBox.Show("SE AÑADIÓ CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("ESCRIBA EL NOMBRE Y APELLDIO DE UN EMPLEDO", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("EL EMPLEADO YA ESTA AÑADIDO", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                existe = false;
                txtEmpleado.Text = "";
            }


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
            

            if (listBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("SE ELIMINARÁ EL EMPLEADO SELECCIONADO", "ELIMINAR EMPLEADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) 
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
                    MessageBox.Show("SE ELIMINÓ CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bool existe1 = File.Exists(item + ".txt");
                    if (existe1 == true) 
                    {
                        File.Delete(item + ".txt");
                    }
                    bool existe2 = File.Exists("Plata_" + item + ".txt");
                    if (existe2 == true)
                    {
                        File.Delete("Plata_" + item + ".txt");
                    }
                    bool existe3 = File.Exists("Cuenta" + item + ".txt");
                    if (existe3 == true)
                    {
                        File.Delete("Cuenta" + item + ".txt");
                    }
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
            else
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO DE LA LISTA","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void txtEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmSelector Selector = new frmSelector();
                Selector.Show();
                this.Hide();
            }
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string valor = txtEmpleado.Text;
                bool existe = File.Exists("empleados.txt");
                bool existe2 = false;
                if (existe == true)
                {
                    StreamReader srg = new StreamReader("empleados.txt");
                    string Linea = "";
                    while (srg.EndOfStream == false)
                    {
                        Linea = srg.ReadLine();
                        if (Linea == valor)
                        {
                            existe2 = true;
                        }
                    }
                    srg.Close();
                    srg.Dispose();
                }
                if (existe2 == false)
                {
                    if (txtEmpleado.Text != "")
                    {
                        StreamWriter sw = new StreamWriter("empleados.txt", true);
                        sw.WriteLine(txtEmpleado.Text);
                        sw.Close();
                        sw.Dispose();
                        listBox1.DataSource = null;
                        listBox1.Refresh();
                        MessageBox.Show("SE AÑADIÓ CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    else
                    {
                        MessageBox.Show("ESCRIBA EL NOMBRE Y APELLDIO DE UN EMPLEDO", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("EL EMPLEADO YA ESTA AÑADIDO", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    existe = false;
                    txtEmpleado.Text = "";
                }

            }
            




        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }
    }
}
