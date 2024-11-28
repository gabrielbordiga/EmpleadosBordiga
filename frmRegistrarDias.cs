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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace Gestión_Empleados
{

    public partial class frmRegistrarDias : Form
    {
        string valor = "";
        string dia = "";
        int preciotxt = 0;
        int precioxhora = 0;
        int precioextra = 0;
        //int redondeadohora = 0;
        int precioglobal = 0;
        int horas = 0;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmRegistrarDias()
        {
            InitializeComponent();

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            
        }



        private void frmRegistrarDias_Load(object sender, EventArgs e)
        {
            precioglobal = preciotxt;
            lblHorasExtra.Text = ("");
            this.UnDia.Checked = false;
            this.MedioDia.Checked = false;
            lblTotal.Text = "";
            bool precioExiste = File.Exists("precio.txt");
            if (precioExiste) 
            {
                this.dtpFecha.Value = DateTime.Now;
                this.dtpDesde.Value = DateTime.Now;
                this.dtpHasta.Value = DateTime.Now;
                StreamReader sr = new StreamReader("empleados.txt");
                string Linea = "";
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    cboEmpleado.Items.Add(Linea);
                    cboEmpleado2.Items.Add(Linea);
                }

                sr.Close();
                sr.Dispose();

                StreamReader pr = new StreamReader("precio.txt");
                string Linea2 = "";
                while (pr.EndOfStream == false)
                {
                    Linea2 = pr.ReadLine();
                    txtPrecio.AppendText(Linea2);
                    preciotxt = Convert.ToInt32(Linea2);
                }
                funcion_precioxhora(sender, e);
                pr.Close();
                pr.Dispose();
            }
            

        }
        private void funcion_precioxhora(object sender, EventArgs e) 
        {
            precioxhora = preciotxt / 8;
            //redondeadohora = (int)Math.Round(precioxhora);
            lblPrecioXHora.Text = ("Valor x hora $" + precioxhora.ToString());
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
                                MessageBox.Show("ESTA FECHA YA FUÉ REGISTRADA", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                            string precio = "";
                                            precio = txtPrecio.Text;
                                            if (nudHorasExtra.Value != 0) 
                                            {
                                                precio = precioextra.ToString();
                                            }

                                            StreamWriter sw = new StreamWriter(valor + ".txt", true);
                                            sw.Write(dtpFecha.Text + ", ");
                                            sw.Write("$" + precio + ", ");
                                            sw.Write(dia + ", ");
                                            if (horas != 0)
                                            {
                                                if (horas > 1)
                                                {
                                                    sw.Write(horas + " Horas extra" + ", ");
                                                }
                                                else
                                                {
                                                    sw.Write(horas + " Hora extra" + ", ");
                                                }
                                            }
                                            sw.WriteLine(txtDetalle.Text);
                                            //this.cboEmpleado.SelectedIndex = -1;
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
                                                this.UnDia.Checked = false;
                                                this.MedioDia.Checked = false;
                                            }
                                            if (!chkMantenerEmpleado.Checked) 
                                            {
                                                cboEmpleado.SelectedIndex = -1;
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

                                        string precio = "";
                                        precio = txtPrecio.Text;
                                        if (nudHorasExtra.Value != 0)
                                        {
                                            precio = precioextra.ToString();
                                        }

                                        StreamWriter sw = new StreamWriter(valor + ".txt", true);
                                        sw.Write(dtpFecha.Text + ", ");
                                        sw.Write("$" + precio + ", ");
                                        sw.Write(dia + ", ");
                                        if (horas != 0)
                                        {
                                            if (horas > 1)
                                            {
                                                sw.Write(horas + " Horas extra" + ", ");
                                            }
                                            else
                                            {
                                                sw.Write(horas + " Hora extra" + ", ");
                                            }
                                        }
                                        sw.WriteLine(txtDetalle.Text);
                                        sw.WriteLine(precio);
                                        //this.cboEmpleado.SelectedIndex = -1;
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
                                            this.UnDia.Checked = false;
                                            this.MedioDia.Checked = false;
                                        }
                                        if (!chkMantenerEmpleado.Checked)
                                        {
                                            cboEmpleado.SelectedIndex = -1;
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
                else if (existefile == false)
                {
                    StreamWriter escritura = new StreamWriter(valor + ".txt");
                    escritura.Close();
                    escritura.Dispose();
                    
                    

                        string Detalles = "";
                        DateTime fechaActual = DateTime.Now;
                        DateTime fechaSeleccionado = dtpFecha.Value;
                        StreamReader leer = new StreamReader(valor + ".txt");
                        string fehca2 = dtpFecha.Text.ToString();
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
                                    string precio = "";
                                    precio = txtPrecio.Text;
                                    if (nudHorasExtra.Value != 0)
                                    {
                                        precio = precioextra.ToString();
                                    }

                                    StreamWriter sw = new StreamWriter(valor + ".txt", true);
                                    sw.Write(dtpFecha.Text + ", ");
                                    sw.Write("$" + precio + ", ");
                                    sw.Write(dia + ", ");
                                    if (horas != 0)
                                    {
                                        if (horas > 1)
                                        {
                                            sw.Write(horas + " Horas extra" + ", ");
                                        }
                                        else 
                                        {
                                            sw.Write(horas + " Hora extra" + ", ");
                                        }
                                    }
                                    sw.WriteLine(txtDetalle.Text);
                                    //this.cboEmpleado.SelectedIndex = -1;
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
                                        this.UnDia.Checked = false;
                                        this.MedioDia.Checked = false;
                                    }
                                    if (!chkMantenerEmpleado.Checked)
                                    {
                                        cboEmpleado.SelectedIndex = -1;
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

            }
            else
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void cmdVolver2_Click(object sender, EventArgs e)
        {
            bool existe = File.Exists(valor + ".txt");
            if (existe == true)
            {
                List<double> numeros = new List<double>();


                StreamReader sr = new StreamReader("Plata_" + valor + ".txt");
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    double numero = double.Parse(linea);
                    numeros.Add(numero);
                    linea = sr.ReadLine();
                }
                sr.Close();

                foreach (double n in numeros)
                {
                    Console.WriteLine(n);


                }
                StreamWriter sw = new StreamWriter("Cuenta" + valor + ".txt");

                sw.WriteLine(numeros.Sum());

                sw.Close();


            }
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
                cmdCargar2_Click(sender, e);
            }
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmdVolver3_Click(object sender, EventArgs e)
        {
            
            bool existe = File.Exists(valor + ".txt");
            if (existe == true)
            {
                List<double> numeros = new List<double>();


                StreamReader sr = new StreamReader("Plata_" + valor + ".txt");
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    double numero = double.Parse(linea);
                    numeros.Add(numero);
                    linea = sr.ReadLine();
                }
                sr.Close();

                foreach (double n in numeros)
                {
                    Console.WriteLine(n);
                    

                }
                StreamWriter sw = new StreamWriter("Cuenta" + valor + ".txt");

                sw.WriteLine(numeros.Sum());

                sw.Close();

               
            }
            if (txtDetalle2.Text == "")
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

        private void cmdCargar3_Click(object sender, EventArgs e)
        {
            if (cboEmpleado2.SelectedIndex != -1)
            {
                valor = this.cboEmpleado2.SelectedItem.ToString();
                bool existefile = File.Exists(valor + ".txt");
                if (existefile == true)
                {
                    string Detalles = "";
                    DateTime fechaActual = DateTime.Now;
                    DateTime fechaSeleccionado = dtpDesde.Value;
                    StreamReader leer = new StreamReader(valor + ".txt");
                    string Linea = "";
                    string fehca2 = dtpDesde.Text.ToString();
                    string reintentar = "";
                    string reintentar2 = "";
                    string fecha = "";
                    string fecha3 = "";
                    DateTime fechaHasta = dtpHasta.Value;
                    leer.Close();
                    leer.Dispose();

                    if (reintentar == reintentar2)
                    {
                        if (fechaSeleccionado <= fechaActual)
                        {
                            if (fechaHasta >= fechaSeleccionado)
                            {
                                if (txtDetalle2.Text != Detalles)
                                {
                                    if (txtPorcentaje.Text != "")
                                    {
                                        if (txtHectareas.Text != "")
                                        {
                                            if (txtMontoPorc.Text != "")
                                            {
                                                string dia = "";
                                                string precio = "";
                                                int hectareasXprecios = 0;
                                                int hectareas = Convert.ToInt32(txtHectareas.Text);
                                                int precioporha = Convert.ToInt32(txtMontoPorc.Text);
                                                double porcentaje = Convert.ToInt32(txtPorcentaje.Text);
                                                double porcentajefin = 0;
                                                double preciofinal = 0;
                                                hectareasXprecios = hectareas * precioporha;
                                                porcentajefin = porcentaje / 100;
                                                preciofinal = hectareasXprecios * porcentajefin;
                                                precio = preciofinal.ToString();

                                                StreamWriter sw = new StreamWriter(valor + ".txt", true);
                                                sw.Write("Registro de porcentaje por: " + txtDetalle2.Text + ", ");
                                                sw.Write("Desde el día " + dtpDesde.Text + " Hasta el día " + dtpHasta.Text + ", ");
                                                sw.Write("Con una Ganancia final de $" + precio + ", ");
                                                sw.Write("por el " + txtPorcentaje.Text + "% por " + txtHectareas.Text + " Hectáreas ");
                                                sw.WriteLine("con un valor de $" + txtMontoPorc.Text + " por hectárea");
                                                this.cboEmpleado.SelectedIndex = -1;
                                                sw.Close();
                                                sw.Dispose();
                                                StreamWriter pr = new StreamWriter("Plata_" + valor + ".txt", true);
                                                pr.WriteLine(precio);
                                                pr.Close();
                                                pr.Dispose();
                                                MessageBox.Show("SE CARGÓ EXITOSAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                if (!chkMantenerDetalle2.Checked)
                                                {
                                                    txtDetalle2.Text = "";
                                                }
                                                if (!chkMantenerEmpleado2.Checked)
                                                {
                                                    cboEmpleado2.SelectedIndex = -1;
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("INTRODUCIR MONTO POR HECTAREA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("INTRODUCIR HECTÁREAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("INTRODUCIR PORCENTAJE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("INTRODUCIR DETALLE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("LA FECHA DE ´DESDE´ TIENE QUE SER MENOR O IGUAL QUE LA DE ´HASTA´", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }


                }
                else if (existefile == false)
                {
                    string Detalles = "";
                    DateTime fechaActual = DateTime.Now;
                    DateTime fechaSeleccionado = dtpDesde.Value;
                    
                    string Linea = "";
                    string fehca2 = dtpDesde.Text.ToString();
                    string reintentar = "";
                    string reintentar2 = "";
                    string fecha = "";
                    string fecha3 = "";
                    DateTime fechaHasta = dtpHasta.Value;
                    

                    if (reintentar == reintentar2)
                    {
                        if (fechaSeleccionado <= fechaActual)
                        {
                            if (fechaHasta >= fechaSeleccionado)
                            {
                                if (txtDetalle2.Text != Detalles)
                                {
                                    if (txtPorcentaje.Text != "")
                                    {
                                        if (txtHectareas.Text != "")
                                        {
                                            if (txtMontoPorc.Text != "")
                                            {
                                                string dia = "";
                                                string precio = "";
                                                int hectareasXprecios = 0;
                                                int hectareas = Convert.ToInt32(txtHectareas.Text);
                                                int precioporha = Convert.ToInt32(txtMontoPorc.Text);
                                                double porcentaje = Convert.ToInt32(txtPorcentaje.Text);
                                                double porcentajefin = 0;
                                                double preciofinal = 0;
                                                hectareasXprecios = hectareas * precioporha;
                                                porcentajefin = porcentaje / 100;
                                                preciofinal = hectareasXprecios * porcentajefin;
                                                precio = preciofinal.ToString();

                                                StreamWriter sw = new StreamWriter(valor + ".txt", true);
                                                sw.Write("Registro de porcentaje por: " + txtDetalle2.Text + ", ");
                                                sw.Write("Desde el día " + dtpDesde.Text + " Hasta el día " + dtpHasta.Text + ", ");
                                                sw.Write("Con una Ganancia final de $" + precio + ", ");
                                                sw.Write("por el " + txtPorcentaje.Text + "% por " + txtHectareas.Text + " Hectáreas ");
                                                sw.WriteLine("con un valor de $" + txtMontoPorc.Text + " por hectárea");
                                                this.cboEmpleado.SelectedIndex = -1;
                                                sw.Close();
                                                sw.Dispose();
                                                StreamWriter pr = new StreamWriter("Plata_" + valor + ".txt", true);
                                                pr.WriteLine(precio);
                                                pr.Close();
                                                pr.Dispose();
                                                MessageBox.Show("SE CARGÓ EXITOSAMENTE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                if (!chkMantenerDetalle2.Checked)
                                                {
                                                    txtDetalle2.Text = "";
                                                }
                                                if (!chkMantenerEmpleado2.Checked)
                                                {
                                                    cboEmpleado2.SelectedIndex = -1;
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("INTRODUCIR MONTO POR HECTAREA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("INTRODUCIR HECTÁREAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("INTRODUCIR PORCENTAJE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("INTRODUCIR DETALLE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("LA FECHA DE ´DESDE´ TIENE QUE SER MENOR O IGUAL QUE LA DE ´HASTA´", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("INTRODUCIR UNA FECHA ACTUAL O ANTERIOR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                }

            }
            else
            {
                MessageBox.Show("SELECCIONE UN EMPLEADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtPorcentaje.Text = "";
            txtMontoPorc.Text = "";
            txtHectareas.Text = "";
            this.dtpDesde.Value = DateTime.Now;
            this.dtpHasta.Value = DateTime.Now;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            if (txtPorcentaje.Text != "")
            {
                if (txtHectareas.Text != "")
                {
                    if (txtMontoPorc.Text != "")
                    {
                        string dia = "";
                        string precio = "";
                        int hectareasXprecios = 0;
                        int hectareas = Convert.ToInt32(txtHectareas.Text);
                        int precioporha = Convert.ToInt32(txtMontoPorc.Text);
                        double porcentaje = Convert.ToInt32(txtPorcentaje.Text);
                        double porcentajefin = 0;
                        double preciofinal = 0;
                        hectareasXprecios = hectareas * precioporha;
                        porcentajefin = porcentaje / 100;
                        preciofinal = hectareasXprecios * porcentajefin;
                        precio = preciofinal.ToString();
                        lblTotal.Text = "Total= $" + precio;
                    }
                }
            }
            else
            {
                lblTotal.Text = "";
            }
            
        }

        private void txtHectareas_TextChanged(object sender, EventArgs e)
        {
            if (txtPorcentaje.Text != "")
            {
                if (txtHectareas.Text != "")
                {
                    if (txtMontoPorc.Text != "")
                    {
                        string dia = "";
                        string precio = "";
                        int hectareasXprecios = 0;
                        int hectareas = Convert.ToInt32(txtHectareas.Text);
                        int precioporha = Convert.ToInt32(txtMontoPorc.Text);
                        double porcentaje = Convert.ToInt32(txtPorcentaje.Text);
                        double porcentajefin = 0;
                        double preciofinal = 0;
                        hectareasXprecios = hectareas * precioporha;
                        porcentajefin = porcentaje / 100;
                        preciofinal = hectareasXprecios * porcentajefin;
                        precio = preciofinal.ToString();
                        lblTotal.Text = "Total= $" + precio;
                    }
                }
                else
                {
                    lblTotal.Text = "";
                }
            }
        }

        private void txtMontoPorc_TextChanged(object sender, EventArgs e)
        {
            if (txtPorcentaje.Text != "")
            {
                if (txtHectareas.Text != "")
                {
                    if (txtMontoPorc.Text != "")
                    {
                        string dia = "";
                        string precio = "";
                        int hectareasXprecios = 0;
                        int hectareas = Convert.ToInt32(txtHectareas.Text);
                        int precioporha = Convert.ToInt32(txtMontoPorc.Text);
                        double porcentaje = Convert.ToInt32(txtPorcentaje.Text);
                        double porcentajefin = 0;
                        double preciofinal = 0;
                        hectareasXprecios = hectareas * precioporha;
                        porcentajefin = porcentaje / 100;
                        preciofinal = hectareasXprecios * porcentajefin;
                        precio = preciofinal.ToString();
                        lblTotal.Text = "Total= $" + precio;
                    }
                    else
                    {
                        lblTotal.Text = "";
                    }
                }
            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento
            }
        }

        private void txtHectareas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento
            }
        }

        private void txtMontoPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            cmdVolver2_Click(sender, e);
        }

        private bool isProgrammaticChange = false;

        private void MedioDia_CheckedChanged(object sender, EventArgs e)
        {
            if (MedioDia.Checked)
            {
                int precio = preciotxt / 2;
                int redondeado = (int)Math.Round(precio / 10.0) * 10;
                isProgrammaticChange = true; // Indicar que es un cambio programático

                txtPrecio.Text = redondeado.ToString();
                isProgrammaticChange = false; // Restaurar bandera
                lblPlata.Text = ("(Plata x 1/2 Día)");
                precioglobal = redondeado;
                lblPrecioXHora.Text = ("Valor x hora $" + precioxhora.ToString());
                nudHorasExtra_ValueChanged(sender, e);
                dia = "1/2 Día";
            }

        }
            
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (UnDia.Checked) 
            {
                isProgrammaticChange = true; // Indicar que es un cambio programático
                txtPrecio.Text = preciotxt.ToString();
                isProgrammaticChange = false; // Restaurar bandera

                lblPlata.Text = ("(Plata x 1 Día)");
                precioglobal = preciotxt;
                lblPrecioXHora.Text = ("Valor x hora $"+precioxhora.ToString());
                dia = "1 Día";
                nudHorasExtra_ValueChanged(sender, e);
            }
            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!isProgrammaticChange && txtPrecio.Text != "") 
            {
                if (MedioDia.Checked)
                {
                    int preciomedio = Convert.ToInt32(txtPrecio.Text);
                    preciotxt = preciomedio * 2;
                    precioglobal = preciotxt;
                }
                else 
                {
                    preciotxt = Convert.ToInt32(txtPrecio.Text);
                    precioglobal = preciotxt;
                }
                funcion_precioxhora(sender, e);
            }
            nudHorasExtra_ValueChanged(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nudHorasExtra_ValueChanged(object sender, EventArgs e)
        {
            int horasExtra = 0;
            int contador = 0;
            if (txtPrecio.Text != "" && txtPrecio.Text != "0")
            {
                if (nudHorasExtra.Value != 0)
                {
                    StreamReader pr = new StreamReader("Config/redondeo.txt");
                    string Linea2 = "";
                    Linea2 = pr.ReadLine();
                    pr.Close();
                    pr.Dispose();
                    StreamReader cr = new StreamReader("Config/redondeo2.txt");
                    string Linea3 = "";
                    Linea3 = cr.ReadLine();
                    cr.Close();
                    cr.Dispose();
                    contador = Convert.ToInt32(nudHorasExtra.Value);
                    horasExtra = precioxhora * contador;
                    precioextra = precioglobal + horasExtra;
                    if (Linea3 == "Arriba")
                    {
                        if (Linea2 == "1")
                        {
                            int redondeado = (int)Math.Ceiling(precioextra / 10.0) * 10;
                            precioextra = redondeado;
                        }
                        if (Linea2 == "2")
                        {
                            int redondeado = (int)Math.Ceiling(precioextra / 100.0) * 100;
                            precioextra = redondeado;
                        }
                        if (Linea2 == "3")
                        {
                            int redondeado = (int)Math.Ceiling(precioextra / 1000.0) * 1000;
                            precioextra = redondeado;
                        }
                        if (Linea2 == "4")
                        {
                            int redondeado = (int)Math.Ceiling(precioextra / 10000.0) * 10000;
                            precioextra = redondeado;
                        }
                    }
                    if (Linea3 == "Abajo")
                    {
                        if (Linea2 == "1")
                        {
                            int redondeado = (int)Math.Floor(precioextra / 10.0) * 10;
                            precioextra = redondeado;
                        }
                        if (Linea2 == "2")
                        {
                            int redondeado = (int)Math.Floor(precioextra / 100.0) * 100;
                            precioextra = redondeado;
                        }
                        if (Linea2 == "3")
                        {
                            int redondeado = (int)Math.Floor(precioextra / 1000.0) * 1000;
                            precioextra = redondeado;
                        }
                        if (Linea2 == "4")
                        {
                            int redondeado = (int)Math.Floor(precioextra / 10000.0) * 10000;
                            precioextra = redondeado;
                        }
                    }
                    
                    lblHorasExtra.Text = ("+ $" + horasExtra.ToString() + " = $" + precioextra);
                    horas = contador;
                }
                else
                {
                    lblHorasExtra.Text = ("");
                }
            }
            else 
            {
                lblHorasExtra.Text = ("");
            }
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (tanto números como la tecla de retroceso)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Cancela la acción si la tecla no es un número o retroceso
            }
        }
    }
}
