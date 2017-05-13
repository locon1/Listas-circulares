namespace Listas_circulares
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.cmdRecorrido = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblHora_Fin = new System.Windows.Forms.Label();
            this.lblHora_Inicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.cmdAgregar_Inicio = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.cmdEliminar_Inicio = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRecorridos = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(354, 36);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(149, 20);
            this.txtRecorrido.TabIndex = 6;
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Location = new System.Drawing.Point(279, 39);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(47, 13);
            this.lblRecorrido.TabIndex = 6;
            this.lblRecorrido.Text = "Nombre:";
            // 
            // cmdRecorrido
            // 
            this.cmdRecorrido.AutoSize = true;
            this.cmdRecorrido.Location = new System.Drawing.Point(427, 131);
            this.cmdRecorrido.Name = "cmdRecorrido";
            this.cmdRecorrido.Size = new System.Drawing.Size(76, 30);
            this.cmdRecorrido.TabIndex = 13;
            this.cmdRecorrido.Text = "Recorrido";
            this.cmdRecorrido.UseVisualStyleBackColor = true;
            this.cmdRecorrido.Click += new System.EventHandler(this.cmdRecorrido_Click);
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "HH:mm";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(354, 105);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(149, 20);
            this.dtpFin.TabIndex = 13;
            // 
            // lblHora_Fin
            // 
            this.lblHora_Fin.AutoSize = true;
            this.lblHora_Fin.Location = new System.Drawing.Point(279, 110);
            this.lblHora_Fin.Name = "lblHora_Fin";
            this.lblHora_Fin.Size = new System.Drawing.Size(62, 13);
            this.lblHora_Fin.TabIndex = 12;
            this.lblHora_Fin.Text = "Hora de fin:";
            // 
            // lblHora_Inicio
            // 
            this.lblHora_Inicio.AutoSize = true;
            this.lblHora_Inicio.Location = new System.Drawing.Point(279, 76);
            this.lblHora_Inicio.Name = "lblHora_Inicio";
            this.lblHora_Inicio.Size = new System.Drawing.Size(75, 13);
            this.lblHora_Inicio.TabIndex = 6;
            this.lblHora_Inicio.Text = "Hora de inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(354, 74);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(149, 20);
            this.dtpInicio.TabIndex = 11;
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.AutoSize = true;
            this.cmdInsertar.Location = new System.Drawing.Point(180, 208);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(77, 50);
            this.cmdInsertar.TabIndex = 23;
            this.cmdInsertar.Text = "Insertar";
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            // 
            // cmdAgregar_Inicio
            // 
            this.cmdAgregar_Inicio.AutoSize = true;
            this.cmdAgregar_Inicio.Location = new System.Drawing.Point(16, 208);
            this.cmdAgregar_Inicio.Name = "cmdAgregar_Inicio";
            this.cmdAgregar_Inicio.Size = new System.Drawing.Size(76, 50);
            this.cmdAgregar_Inicio.TabIndex = 22;
            this.cmdAgregar_Inicio.Text = "Agregar\r\nal inicio";
            this.cmdAgregar_Inicio.UseVisualStyleBackColor = true;
            this.cmdAgregar_Inicio.Click += new System.EventHandler(this.cmdAgregar_Inicio_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.AutoSize = true;
            this.cmdReporte.Location = new System.Drawing.Point(180, 152);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(77, 50);
            this.cmdReporte.TabIndex = 21;
            this.cmdReporte.Text = "Reporte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(520, 14);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(203, 244);
            this.txtLista.TabIndex = 20;
            // 
            // cmdEliminar_Inicio
            // 
            this.cmdEliminar_Inicio.AutoSize = true;
            this.cmdEliminar_Inicio.Location = new System.Drawing.Point(98, 208);
            this.cmdEliminar_Inicio.Name = "cmdEliminar_Inicio";
            this.cmdEliminar_Inicio.Size = new System.Drawing.Size(76, 50);
            this.cmdEliminar_Inicio.TabIndex = 19;
            this.cmdEliminar_Inicio.Text = "Eliminar\r\nal inicio";
            this.cmdEliminar_Inicio.UseVisualStyleBackColor = true;
            this.cmdEliminar_Inicio.Click += new System.EventHandler(this.cmdEliminar_Inicio_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.AutoSize = true;
            this.cmdEliminar.Location = new System.Drawing.Point(98, 152);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(76, 50);
            this.cmdEliminar.TabIndex = 18;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.AutoSize = true;
            this.cmdBuscar.Location = new System.Drawing.Point(427, 205);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(76, 30);
            this.cmdBuscar.TabIndex = 17;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(279, 182);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(328, 179);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(175, 20);
            this.txtBuscar.TabIndex = 15;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.AutoSize = true;
            this.cmdAgregar.Location = new System.Drawing.Point(16, 152);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(76, 50);
            this.cmdAgregar.TabIndex = 14;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(23, 73);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(45, 13);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(98, 73);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(149, 20);
            this.txtTiempo.TabIndex = 3;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(23, 107);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(44, 26);
            this.lblRuta.TabIndex = 4;
            this.lblRuta.Text = "Nombre\r\nruta:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(98, 107);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(149, 20);
            this.txtRuta.TabIndex = 5;
            // 
            // lblRecorridos
            // 
            this.lblRecorridos.AutoSize = true;
            this.lblRecorridos.Location = new System.Drawing.Point(351, 14);
            this.lblRecorridos.Name = "lblRecorridos";
            this.lblRecorridos.Size = new System.Drawing.Size(53, 13);
            this.lblRecorridos.TabIndex = 24;
            this.lblRecorridos.Text = "Recorrido";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(84, 14);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 25;
            this.lblBase.Text = "Base";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 270);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblRecorridos);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRecorrido);
            this.Controls.Add(this.cmdRecorrido);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblHora_Fin);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.lblHora_Inicio);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cmdAgregar_Inicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.cmdEliminar_Inicio);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.Button cmdRecorrido;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblHora_Fin;
        private System.Windows.Forms.Label lblHora_Inicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.Button cmdAgregar_Inicio;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button cmdEliminar_Inicio;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRecorridos;
        private System.Windows.Forms.Label lblBase;
    }
}

