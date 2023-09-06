using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;
using Timers = System.Timers;
using System.Threading;

namespace Gestión_Empleados
{
    public partial class frmInicio : Form
    {
        
        int contador = 0;


        public frmInicio()
        {
            InitializeComponent();

            // Crear el Timer
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer(); // Usar el nombre completo
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Iniciar el Timer
            timer1.Start();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); // Usar el nombre completo
            timer.Interval = 1400;
            timer.Tick += new EventHandler(timer2_Tick);

            // Iniciar el Timer

            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == 0) 
            {
                contador = contador + 1;
                frmSelector selector = new frmSelector();
                selector.Show();
                
            }
            this.Hide();



        }
        private void timer2_Tick(object sender, EventArgs e) 
        {
            
            
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e) 
        {
            
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
