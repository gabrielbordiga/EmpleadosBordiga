namespace Gestión_Empleados
{
    partial class frmSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdRegistrarDias = new System.Windows.Forms.Button();
            this.cmdAñadirEmpleado = new System.Windows.Forms.Button();
            this.cmdModificarPrecio = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdCuentaEmpleado = new System.Windows.Forms.Button();
            this.cmdRetirarDinero = new System.Windows.Forms.Button();
            this.cmdDetalles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRegistrarDias
            // 
            this.cmdRegistrarDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarDias.Location = new System.Drawing.Point(37, 33);
            this.cmdRegistrarDias.Name = "cmdRegistrarDias";
            this.cmdRegistrarDias.Size = new System.Drawing.Size(440, 159);
            this.cmdRegistrarDias.TabIndex = 0;
            this.cmdRegistrarDias.Text = "REGISTRAR DÍAS";
            this.cmdRegistrarDias.UseVisualStyleBackColor = true;
            this.cmdRegistrarDias.Click += new System.EventHandler(this.cmdRegistrarDias_Click);
            // 
            // cmdAñadirEmpleado
            // 
            this.cmdAñadirEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAñadirEmpleado.Location = new System.Drawing.Point(37, 221);
            this.cmdAñadirEmpleado.Name = "cmdAñadirEmpleado";
            this.cmdAñadirEmpleado.Size = new System.Drawing.Size(440, 159);
            this.cmdAñadirEmpleado.TabIndex = 0;
            this.cmdAñadirEmpleado.Text = "AÑADIR EMPLEADO";
            this.cmdAñadirEmpleado.UseVisualStyleBackColor = true;
            this.cmdAñadirEmpleado.Click += new System.EventHandler(this.cmdAñadirEmpleado_Click);
            // 
            // cmdModificarPrecio
            // 
            this.cmdModificarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarPrecio.Location = new System.Drawing.Point(37, 408);
            this.cmdModificarPrecio.Name = "cmdModificarPrecio";
            this.cmdModificarPrecio.Size = new System.Drawing.Size(440, 159);
            this.cmdModificarPrecio.TabIndex = 0;
            this.cmdModificarPrecio.Text = "MODIFICAR PRECIO X DÍA";
            this.cmdModificarPrecio.UseVisualStyleBackColor = true;
            this.cmdModificarPrecio.Click += new System.EventHandler(this.cmdModificarPrecio_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(868, 585);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(90, 37);
            this.cmdSalir.TabIndex = 1;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCuentaEmpleado
            // 
            this.cmdCuentaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCuentaEmpleado.Location = new System.Drawing.Point(509, 34);
            this.cmdCuentaEmpleado.Name = "cmdCuentaEmpleado";
            this.cmdCuentaEmpleado.Size = new System.Drawing.Size(440, 158);
            this.cmdCuentaEmpleado.TabIndex = 3;
            this.cmdCuentaEmpleado.Text = "CUENTA EMPLEADO";
            this.cmdCuentaEmpleado.UseVisualStyleBackColor = true;
            this.cmdCuentaEmpleado.Click += new System.EventHandler(this.cmdCuentaEmpleado_Click);
            // 
            // cmdRetirarDinero
            // 
            this.cmdRetirarDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRetirarDinero.Location = new System.Drawing.Point(509, 221);
            this.cmdRetirarDinero.Name = "cmdRetirarDinero";
            this.cmdRetirarDinero.Size = new System.Drawing.Size(439, 158);
            this.cmdRetirarDinero.TabIndex = 4;
            this.cmdRetirarDinero.Text = "RETIRAR DINERO";
            this.cmdRetirarDinero.UseVisualStyleBackColor = true;
            this.cmdRetirarDinero.Click += new System.EventHandler(this.cmdRetirarDinero_Click);
            // 
            // cmdDetalles
            // 
            this.cmdDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDetalles.Location = new System.Drawing.Point(509, 408);
            this.cmdDetalles.Name = "cmdDetalles";
            this.cmdDetalles.Size = new System.Drawing.Size(439, 159);
            this.cmdDetalles.TabIndex = 5;
            this.cmdDetalles.Text = "DETALLES";
            this.cmdDetalles.UseVisualStyleBackColor = true;
            this.cmdDetalles.Click += new System.EventHandler(this.cmdDetalles_Click);
            // 
            // frmSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 634);
            this.Controls.Add(this.cmdDetalles);
            this.Controls.Add(this.cmdRetirarDinero);
            this.Controls.Add(this.cmdCuentaEmpleado);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdModificarPrecio);
            this.Controls.Add(this.cmdAñadirEmpleado);
            this.Controls.Add(this.cmdRegistrarDias);
            this.Name = "frmSelector";
            this.Text = "SELECTOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarDias;
        private System.Windows.Forms.Button cmdAñadirEmpleado;
        private System.Windows.Forms.Button cmdModificarPrecio;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdCuentaEmpleado;
        private System.Windows.Forms.Button cmdRetirarDinero;
        private System.Windows.Forms.Button cmdDetalles;
    }
}