﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestión_Empleados
{
    public partial class frmAdmin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void cmdMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdPrograma_Click(object sender, EventArgs e)
        {
            frmInicio Inicio = new frmInicio();
            Inicio.Show();
            this.Hide();
        }

        private void cmdResetear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea RESETEAR el programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Verificar el resultado del MessageBox
            if (result == DialogResult.Yes)
            {
                bool existem = File.Exists("empleados.txt");
                if (existem)
                {
                    using (StreamReader sr = new StreamReader("empleados.txt"))
                    {
                        string Linea = "";
                        while (!sr.EndOfStream)
                        {
                            Linea = sr.ReadLine();
                            File.Delete(Linea + ".txt");
                            File.Delete("Cuenta" + Linea + ".txt");
                            File.Delete("Plata_" + Linea + ".txt");
                        }
                    }
                    File.Delete("empleados.txt");
                }

                bool exister = File.Exists("TodosLosRetiros.txt");
                bool existep = File.Exists("precio.txt");
                bool existed = File.Exists("Detalles.txt");
                bool existea = Directory.Exists("Archivos");
                bool existea1 = Directory.Exists("Archivos/Detalles");
                bool existea2 = Directory.Exists("Archivos/Retiros");
                bool archRedondeo = File.Exists("Config/redondeo.txt");
                bool archRedondeo2 = File.Exists("Config/redondeo2.txt");
                bool config = Directory.Exists("Config");

                if (exister)
                {
                    File.Delete("TodosLosRetiros.txt");
                }
                if (existep)
                {
                    File.Delete("precio.txt");
                }
                if (existed)
                {
                    File.Delete("Detalles.txt");
                }
                if (existea1)
                {
                    DeleteDirectory("Archivos/Detalles");
                }
                if (existea2)
                {
                    DeleteDirectory("Archivos/Retiros");
                }
                if (existea)
                {
                    DeleteDirectory("Archivos");
                }
                if (archRedondeo) 
                {
                    File.Delete("Config/redondeo2.txt");
                }
                if (archRedondeo2)
                {
                    File.Delete("Config/redondeo2.txt");
                }
                if (config)
                {
                    DeleteDirectory("Config");
                }

                MessageBox.Show("Reseteado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    File.Delete(file);
                }
                foreach (string subDir in Directory.GetDirectories(path))
                {
                    DeleteDirectory(subDir);
                }
                Directory.Delete(path);
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
