﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestión_Empleados
{
    public partial class frmDetalles : Form
    {
        System.Timers.Timer timer;
        public string valor = "";
        public int restar = 0;
        string fecha = DateTime.Now.ToString("dd-MM-yyyy");
        string hora = DateTime.Now.ToString("HH.mm.ss");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private PrintDocument printDocument;
        private string filePath = ""; // Ruta del archivo a imprimir
        private string fileContent = "";
        private string employeeName = ""; // Nombre del empleado
        private int employeeBalance = 0; // Saldo del empleado

        public frmDetalles()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(2);
            timer.Elapsed += OnTimedEvent;

            // Desactivar el timer por defecto
            timer.Enabled = false;

            // Configurar el PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSelector Selector = new frmSelector();
            Selector.Show();
            this.Hide();
            bool archivo = File.Exists("Detalles.txt");
           if (archivo == false)
           {
                File.Create("Detalles.txt");

           }
        }

        private void frmDetalles_Load(object sender, EventArgs e)
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

        private void cmdcargar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1)
            {
                string valor = cboEmpleado.SelectedItem.ToString();
                string ruta = valor + ".txt";
                if (File.Exists(ruta))
                {
                    listbox.Items.Clear();
                    StreamReader sr = new StreamReader(ruta);
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        while (linea.Length > 80) // Ajusta el número 80 según tu preferencia
                        {
                            listbox.Items.Add(linea.Substring(0, 80));
                            linea = linea.Substring(80);
                        }
                        listbox.Items.Add(linea);
                    }
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("NO HAY DETALLES", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONAR EMPLEADO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            
            string origen = (valor + ".txt");
            string destino = "Archivos/Detalles/Detalles de " + valor + hora + " " + fecha + ".txt";
            File.Move(origen, destino);

        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdArchivar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1)
            {
                string valor = cboEmpleado.SelectedItem.ToString();
                var respuesta = MessageBox.Show("SE ARCHIVARÁN TODOS LOS DATOS", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK)
                {
                    List<int> numeros = new List<int>();
                    StreamReader srr = new StreamReader("Plata_" + valor + ".txt");
                    string linea = srr.ReadLine();
                    while (linea != null)
                    {
                        int numero = int.Parse(linea);
                        numeros.Add(numero);
                        linea = srr.ReadLine();
                    }
                    srr.Close();

                    foreach (int n in numeros)
                    {
                        Console.WriteLine(n);


                    }

                    StreamWriter srr2 = new StreamWriter("Cuenta" + valor + ".txt");

                    srr2.WriteLine(numeros.Sum());

                    srr2.Close();

                    bool existe = File.Exists("Cuenta" + valor + ".txt");
                    if (existe == true)
                    {
                        List<int> numeros2 = new List<int>();
                        StreamReader pr = new StreamReader("Cuenta" + valor + ".txt");
                        string linea2 = pr.ReadLine();
                        pr.Close();
                        int numero = int.Parse(linea2);
                        StreamWriter td = new StreamWriter(valor + ".txt", true);
                        td.WriteLine("*** TOTAL DINERO AL ARCHIVAR *** $" + numero);
                        td.Close();
                        td.Dispose();

                        listbox.DataSource = null;
                        listbox.Items.Clear();
                        string origen = (valor + ".txt");
                        string destino = "Archivos/Detalles/Detalles de " + valor + " " + hora + " " + fecha + ".txt";
                        File.Move(origen, destino);
                        MessageBox.Show("ARCHIVADO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StreamWriter tdr = new StreamWriter(valor + ".txt", true);
                        tdr.WriteLine("*** TOTAL DINERO *** $" + numero);
                        tdr.Close();
                        tdr.Dispose();
                        listbox.Items.Add("*** TOTAL DINERO *** $" + numero);
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUDO ARCHIVAR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }
            else 
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1)
            {
                employeeName = cboEmpleado.SelectedItem.ToString();
                filePath = employeeName + ".txt";
                if (File.Exists(filePath))
                {
                    fileContent = File.ReadAllText(filePath);

                    PrintDialog printDialog = new PrintDialog
                    {
                        Document = printDocument
                    };

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private int CalculateEmployeeBalance(string employeeName)
        {
            // Implementar la lógica para calcular el saldo del empleado
            // Ejemplo:
            string valor = cboEmpleado.SelectedItem.ToString();
            int balance = 0;
            string balanceFilePath = "Cuenta" + valor + ".txt";
            if (File.Exists(balanceFilePath))
            {
                string balanceContent = File.ReadAllText(balanceFilePath);
                if (int.TryParse(balanceContent, out balance))
                {
                    return balance;
                }
            }
            return balance;
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string valor = cboEmpleado.SelectedItem.ToString();
            string balanceFilePath = "";
            using (StreamReader pr = new StreamReader("Cuenta" + valor + ".txt"))
            {
                balanceFilePath = pr.ReadLine();
            }

            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float rightMargin = e.MarginBounds.Right;
            float bottomMargin = e.MarginBounds.Bottom;
            Font printFont = new Font("Arial", 11);
            SolidBrush myBrush = new SolidBrush(Color.Black);

            // Imprimir el nombre del empleado
            e.Graphics.DrawString("Empleado: " + employeeName, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, leftMargin, topMargin);
            yPos = topMargin + 40; // Dejar un espacio después del nombre

            // Imprimir el contenido del archivo
            using (StringReader sr = new StringReader(fileContent))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    while (line.Length > 0)
                    {
                        int charsFitted = 0;
                        int linesFilled = 0;
                        SizeF size = e.Graphics.MeasureString(line, printFont, new SizeF(rightMargin - leftMargin, printFont.Height), new StringFormat(), out charsFitted, out linesFilled);

                        // Imprimir la línea ajustada
                        e.Graphics.DrawString(line.Substring(0, charsFitted), printFont, myBrush, new RectangleF(leftMargin, yPos, rightMargin - leftMargin, printFont.Height));

                        // Quitar la parte de la línea que ya se ha impreso
                        line = line.Substring(charsFitted);

                        yPos += printFont.GetHeight(e.Graphics);

                        // Verificar si necesitamos una nueva página
                        if (yPos + printFont.GetHeight(e.Graphics) > bottomMargin)
                        {
                            e.HasMorePages = true;
                            return;
                        }
                    }
                }
            }

            // Imprimir el saldo del empleado al final
            yPos += printFont.GetHeight(e.Graphics); // Dejar un espacio antes del saldo
            e.Graphics.DrawString("Plata en Cuenta: $" + balanceFilePath, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, leftMargin, yPos);

            myBrush.Dispose();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            
            DialogResult dialogResult = MessageBox.Show("QUIERES VER LOS ARCHIVOS?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string Ruta = System.AppDomain.CurrentDomain.BaseDirectory + "Archivos\\Detalles";
                System.Diagnostics.Process.Start("explorer.exe", Ruta);
            }
            else if (dialogResult == DialogResult.No)
            {
                // No hacer nada
            }
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEmpleado.SelectedIndex >= 0) 
            {
                string valor = "";
                if (this.cboEmpleado.SelectedItem != null)
                {
                    valor = this.cboEmpleado.SelectedItem.ToString();
                }
                else
                {
                    // Mostrar un mensaje de error o elegir un valor por defecto
                }
                List<int> numeros = new List<int>();

                List<string> lista = new List<string>();
                string ruta = valor + ".txt";
                if (File.Exists(ruta))
                {
                    listbox.Items.Clear();
                    StreamReader sr = new StreamReader(ruta);
                    while (!sr.EndOfStream)
                    {
                        listbox.Items.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("NO HAY DETALLES", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void frmDetalles_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }
    }
}
