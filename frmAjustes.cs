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
    public partial class frmAjustes : Form
    {
        private System.Windows.Forms.Timer timer;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmAjustes()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }

        private void frmAjustes_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
        }

        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {
            StreamReader cr = new StreamReader("Config/redondeo2.txt");
            string Linea3 = "";
            Linea3 = cr.ReadLine();
            cr.Close();
            cr.Dispose();
            if (Linea3 == "Arriba")
            {
                rdArriba.Checked = true;
            }
            if (Linea3 == "Abajo")
            {
                rdAbajo.Checked = true;
            }
            StreamReader pr = new StreamReader("Config/redondeo.txt");
            string Linea2 = "";
            Linea2 = pr.ReadLine();
            pr.Close();
            pr.Dispose();
            
            if (Linea2 == "1") 
            {
                rd1.Checked = true;
            }
            if (Linea2 == "2")
            {
                rd2.Checked = true;
            }
            if (Linea2 == "3")
            {
                rd3.Checked = true;
            }
            if (Linea2 == "4")
            {
                rd4.Checked = true;
            }   

        }
        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Config/redondeo.txt", false);
            escribir.WriteLine("1");
            escribir.Close();
            escribir.Dispose();
            if (rdArriba.Checked)
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Ceiling(SinRedondeo / 10.0) * 10;
                lblConRedondeo.Text = redondeado.ToString();
            }
            if (rdAbajo.Checked) 
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Floor(SinRedondeo / 10.0) * 10;
                lblConRedondeo.Text = redondeado.ToString();
            }
            
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Config/redondeo.txt", false);
            escribir.WriteLine("2");
            escribir.Close();
            escribir.Dispose();
            if (rdArriba.Checked)
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Ceiling(SinRedondeo / 100.0) * 100;
                lblConRedondeo.Text = redondeado.ToString();
            }
            if (rdAbajo.Checked)
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Floor(SinRedondeo / 100.0) * 100;
                lblConRedondeo.Text = redondeado.ToString();
            }
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Config/redondeo.txt", false);
            escribir.WriteLine("3");
            escribir.Close();
            escribir.Dispose();
            if (rdArriba.Checked)
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Ceiling(SinRedondeo / 1000.0) * 1000;
                lblConRedondeo.Text = redondeado.ToString();
            }
            if (rdAbajo.Checked)
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Floor(SinRedondeo / 1000.0) * 1000;
                lblConRedondeo.Text = redondeado.ToString();
            }
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Config/redondeo.txt", false);
            escribir.WriteLine("4");
            escribir.Close();
            escribir.Dispose();
            if (rdArriba.Checked)
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Ceiling(SinRedondeo / 10000.0) * 10000;
                lblConRedondeo.Text = redondeado.ToString();
            }
            if (rdAbajo.Checked)
            {
                int SinRedondeo = Convert.ToInt32(lblSinRedondeo.Text);
                int redondeado = (int)Math.Floor(SinRedondeo / 10000.0) * 10000;
                lblConRedondeo.Text = redondeado.ToString();
            }
        }

        private void rdArriba_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Config/redondeo2.txt", false);
            escribir.WriteLine("Arriba");
            escribir.Close();
            escribir.Dispose();
            if (rd1.Checked)
            {
                rd1_CheckedChanged(sender, e);
            }
            if (rd2.Checked)
            {
                rd2_CheckedChanged(sender, e);
            }
            if (rd3.Checked)
            {
                rd3_CheckedChanged(sender, e);
            }
            if (rd4.Checked)
            {
                rd4_CheckedChanged(sender, e);
            }
        }

        private void rdAbajo_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Config/redondeo2.txt", false);
            escribir.WriteLine("Abajo");
            escribir.Close();
            escribir.Dispose();
            if (rd1.Checked)
            {
                rd1_CheckedChanged(sender, e);
            }
            if (rd2.Checked)
            {
                rd2_CheckedChanged(sender, e);
            }
            if (rd3.Checked)
            {
                rd3_CheckedChanged(sender, e);
            }
            if (rd4.Checked)
            {
                rd4_CheckedChanged(sender, e);
            }
        }
    }
}
