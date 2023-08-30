﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_Empleados
{
    public partial class frmSelector : Form
    {
        public frmSelector()
        {
            InitializeComponent();
        }

        private void cmdRegistrarDias_Click(object sender, EventArgs e)
        {
            frmRegistrarDias RegistrarDias = new frmRegistrarDias(); 
            RegistrarDias.Show(); 
            this.Hide(); 
        }

        private void cmdAñadirEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado AgregarEmpleado = new frmAgregarEmpleado(); 
            AgregarEmpleado.Show(); 
            this.Hide();
        }

        private void cmdModificarPrecio_Click(object sender, EventArgs e)
        {
            frmPrecioPorDia PrecioPorDia = new frmPrecioPorDia();
            PrecioPorDia.Show(); 
            this.Hide(); 
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCuentaEmpleado_Click(object sender, EventArgs e)
        {
            CuentaEmpleado Cuenta = new CuentaEmpleado(); Cuenta.Show();
            this.Hide();
        }

        private void cmdRetirarDinero_Click(object sender, EventArgs e)
        {
            frmRetirarDinero retirarDinero = new frmRetirarDinero(); retirarDinero.Show();
            this.Hide();
        }

        private void cmdDetalles_Click(object sender, EventArgs e)
        {
            frmDetalles Detalles = new frmDetalles(); Detalles.Show();
            this.Hide();
        }
    }
}
