﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

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
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarDias_Load(object sender, EventArgs e)
        {
            bool precioExiste = File.Exists("precio.txt");
            if (precioExiste) 
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
            
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdCargar2_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1)
            {
                string valor = this.cboEmpleado.SelectedItem.ToString();
                bool existefile = File.Exists(valor + ".txt");
                if (existefile == true)
                {
                    string Detalles = "";
                    DateTime fechaActual = DateTime.Now;
                    DateTime fechaSeleccionado = dtpFecha.Value;
                    StreamReader leer = new StreamReader(valor + ".txt");
                    string Linea = "";
                    string fehca2 = dtpFecha.Text.ToString();
                    string reintentar = "";
                    string reintentar2 = "";
                    string fecha = "";
                    string fecha3 = "";

                    if (reintentar == reintentar2)
                    {
                        while (leer.EndOfStream == false)
                        {
                            Linea = leer.ReadLine();
                            string[] datos = Linea.Split(',');
                            fecha = datos[0];

                            if (fecha == fehca2)
                            {
                                MessageBox.Show("ESTA FECHA YA FUE REGISTRADA", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                fecha3 = fehca2;

                            }
                            else
                            {
                                

                            }
                        }

                        leer.Close();
                        leer.Dispose();
                        if (fehca2 != fecha3)
                        {

                            if (fechaSeleccionado <= fechaActual)
                            {
                                if (txtDetalle.Text != Detalles)
                                {
                                    if (cboEmpleado.SelectedIndex != -1)
                                    {
                                        if (this.UnDia.Checked || this.MedioDia.Checked)
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
                                            MessageBox.Show("SE CARGÓ EXITOSAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            if (!chkMantenerDetalle.Checked)
                                            {
                                                txtDetalle.Text = "";
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("SELECCIONE 1 DÍA O 1/2 DÍA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("INTRODUCIR DETALLE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            
                        }


                    }
                    else if(reintentar != reintentar2)
                    {
                        leer.Close();
                        leer.Dispose();
                        if (fechaSeleccionado <= fechaActual)
                        {
                            if (txtDetalle.Text != Detalles)
                            {
                                if (cboEmpleado.SelectedIndex != -1)
                                {
                                    if (this.UnDia.Checked || this.MedioDia.Checked)
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
                                        MessageBox.Show("SE CARGÓ EXITOSAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        if (!chkMantenerDetalle.Checked)
                                        {
                                            txtDetalle.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("SELECCIONE 1 DÍA O 1/2 DÍA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            else
                            {
                                MessageBox.Show("INTRODUCIR DETALLE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {

                    }

                }
                else
                {
                    StreamWriter escritura = new StreamWriter(valor + ".txt");
                    escritura.Close();
                    escritura.Dispose();
                    MessageBox.Show("SE CREÓ UN ARCHIVO NO EXISTENTE, POR FAVOR REINTENTAR", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void cmdVolver2_Click(object sender, EventArgs e)
        {
            if (txtDetalle.Text == "")
            {
                frmSelector Selector = new frmSelector();
                Selector.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("SE PERDERAN LOS DATOS NO CARGADOS", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    frmSelector Selector = new frmSelector();
                    Selector.Show();
                    this.Hide();
                }
                else if (result == DialogResult.Cancel)
                {
                    // El usuario presionó Cancelar
                    // Aquí puedes poner el código que quieras ejecutar
                }
            }
        }

        private void txtDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (txtDetalle.Text == "")
                {
                    frmSelector Selector = new frmSelector();
                    Selector.Show();
                    this.Hide();
                }
                else 
                {
                    DialogResult result = MessageBox.Show("SE PERDERAN LOS DATOS NO CARGADOS", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    
                    if (result == DialogResult.OK)
                    {
                        frmSelector Selector = new frmSelector();
                        Selector.Show();
                        this.Hide();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // El usuario presionó Cancelar
                        // Aquí puedes poner el código que quieras ejecutar
                    }
                }
                
                
            }
        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cboEmpleado.SelectedIndex != -1)
                {
                    string valor = this.cboEmpleado.SelectedItem.ToString();
                    bool existefile = File.Exists(valor + ".txt");
                    if (existefile == true)
                    {
                        string Detalles = "";
                        DateTime fechaActual = DateTime.Now;
                        DateTime fechaSeleccionado = dtpFecha.Value;
                        StreamReader leer = new StreamReader(valor + ".txt");
                        string Linea = "";
                        string fehca2 = dtpFecha.Text.ToString();
                        string reintentar = "";
                        string reintentar2 = "";
                        string fecha = "";
                        string fecha3 = "";

                        if (reintentar == reintentar2)
                        {
                            while (leer.EndOfStream == false)
                            {
                                Linea = leer.ReadLine();
                                string[] datos = Linea.Split(',');
                                fecha = datos[0];

                                if (fecha == fehca2)
                                {
                                    MessageBox.Show("ESTA FECHA YA FUE REGISTRADA", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    fecha3 = fehca2;

                                }
                                else
                                {
                                    

                                }
                            }
                            
                            leer.Close();
                            leer.Dispose();
                            if (fehca2 != fecha3)
                            {
                                
                                if (fechaSeleccionado <= fechaActual)
                                {
                                    if (txtDetalle.Text != Detalles)
                                    {
                                        if (cboEmpleado.SelectedIndex != -1)
                                        {
                                            if (this.UnDia.Checked || this.MedioDia.Checked)
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
                                                MessageBox.Show("SE CARGÓ EXITOSAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                if (!chkMantenerDetalle.Checked)
                                                {
                                                    txtDetalle.Text = "";
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("SELECCIONE 1 DÍA O 1/2 DÍA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("INTRODUCIR DETALLE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                
                            }


                        }
                        else if (reintentar != reintentar2)
                        {
                            leer.Close();
                            leer.Dispose();
                            if (fechaSeleccionado <= fechaActual)
                            {
                                if (txtDetalle.Text != Detalles)
                                {
                                    if (cboEmpleado.SelectedIndex != -1)
                                    {
                                        if (this.UnDia.Checked || this.MedioDia.Checked)
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
                                            MessageBox.Show("SE CARGÓ EXITOSAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            if (!chkMantenerDetalle.Checked)
                                            {
                                                txtDetalle.Text = "";
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("SELECCIONE 1 DÍA O 1/2 DÍA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("INTRODUCIR DETALLE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else 
                        {
                            
                        }

                    }
                    else
                    {
                        StreamWriter escritura = new StreamWriter(valor + ".txt");
                        escritura.Close();
                        escritura.Dispose();
                        MessageBox.Show("SE CREÓ UN ARCHIVO NO EXISTENTE, POR FAVOR REINTENTAR", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
