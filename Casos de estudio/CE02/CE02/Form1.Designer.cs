namespace CE02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.comboTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.btnVaciarCola = new System.Windows.Forms.Button();
            this.grpCarga = new System.Windows.Forms.GroupBox();
            this.txtCantidadPrueba = new System.Windows.Forms.TextBox();
            this.btnCargarPrueba = new System.Windows.Forms.Button();
            this.grpCola = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.grpCarga.SuspendLayout();
            this.grpCola.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtDescripcion);
            this.grpDatos.Controls.Add(this.lblDesc);
            this.grpDatos.Controls.Add(this.txtUsuario);
            this.grpDatos.Controls.Add(this.lblUsuario);
            this.grpDatos.Controls.Add(this.comboTipoSolicitud);
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Location = new System.Drawing.Point(66, 88);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(1071, 133);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de la Solicitud";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 35);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(109, 16);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo de solicitud:";
            // 
            // comboTipoSolicitud
            // 
            this.comboTipoSolicitud.FormattingEnabled = true;
            this.comboTipoSolicitud.Location = new System.Drawing.Point(151, 32);
            this.comboTipoSolicitud.Name = "comboTipoSolicitud";
            this.comboTipoSolicitud.Size = new System.Drawing.Size(249, 24);
            this.comboTipoSolicitud.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(21, 69);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(93, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(307, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(21, 102);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(82, 16);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 99);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(291, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnVaciarCola);
            this.grpAcciones.Controls.Add(this.btnPendientes);
            this.grpAcciones.Controls.Add(this.btnProxima);
            this.grpAcciones.Controls.Add(this.btnAtender);
            this.grpAcciones.Controls.Add(this.btnEncolar);
            this.grpAcciones.Location = new System.Drawing.Point(66, 237);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(1071, 100);
            this.grpAcciones.TabIndex = 1;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones de Control";
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(13, 43);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 33);
            this.btnEncolar.TabIndex = 0;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(194, 43);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 33);
            this.btnAtender.TabIndex = 1;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(421, 43);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(75, 33);
            this.btnProxima.TabIndex = 2;
            this.btnProxima.Text = "Próxima";
            this.btnProxima.UseVisualStyleBackColor = true;
            // 
            // btnPendientes
            // 
            this.btnPendientes.Location = new System.Drawing.Point(621, 43);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(122, 33);
            this.btnPendientes.TabIndex = 3;
            this.btnPendientes.Text = "¿Pendientes?";
            this.btnPendientes.UseVisualStyleBackColor = true;
            // 
            // btnVaciarCola
            // 
            this.btnVaciarCola.Location = new System.Drawing.Point(842, 43);
            this.btnVaciarCola.Name = "btnVaciarCola";
            this.btnVaciarCola.Size = new System.Drawing.Size(96, 33);
            this.btnVaciarCola.TabIndex = 4;
            this.btnVaciarCola.Text = "Vaciar cola";
            this.btnVaciarCola.UseVisualStyleBackColor = true;
            // 
            // grpCarga
            // 
            this.grpCarga.Controls.Add(this.btnCargarPrueba);
            this.grpCarga.Controls.Add(this.txtCantidadPrueba);
            this.grpCarga.Location = new System.Drawing.Point(67, 378);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.Size = new System.Drawing.Size(1070, 100);
            this.grpCarga.TabIndex = 2;
            this.grpCarga.TabStop = false;
            this.grpCarga.Text = "Generar Solicitudes de Prueba";
            // 
            // txtCantidadPrueba
            // 
            this.txtCantidadPrueba.Location = new System.Drawing.Point(23, 40);
            this.txtCantidadPrueba.Name = "txtCantidadPrueba";
            this.txtCantidadPrueba.Size = new System.Drawing.Size(258, 22);
            this.txtCantidadPrueba.TabIndex = 0;
            // 
            // btnCargarPrueba
            // 
            this.btnCargarPrueba.Location = new System.Drawing.Point(316, 34);
            this.btnCargarPrueba.Name = "btnCargarPrueba";
            this.btnCargarPrueba.Size = new System.Drawing.Size(130, 35);
            this.btnCargarPrueba.TabIndex = 1;
            this.btnCargarPrueba.Text = "Cargar prueba";
            this.btnCargarPrueba.UseVisualStyleBackColor = true;
            // 
            // grpCola
            // 
            this.grpCola.Controls.Add(this.lstCola);
            this.grpCola.Location = new System.Drawing.Point(67, 497);
            this.grpCola.Name = "grpCola";
            this.grpCola.Size = new System.Drawing.Size(1070, 209);
            this.grpCola.TabIndex = 3;
            this.grpCola.TabStop = false;
            this.grpCola.Text = "Cola de Solicitudes (FIFO)";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(23, 19);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(1030, 164);
            this.lstCola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(911, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "GESTIÓN DE SOLUCITUDES EN UN SERVIDOR WEB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCola);
            this.Controls.Add(this.grpCarga);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.grpCarga.ResumeLayout(false);
            this.grpCarga.PerformLayout();
            this.grpCola.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox comboTipoSolicitud;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnVaciarCola;
        private System.Windows.Forms.GroupBox grpCarga;
        private System.Windows.Forms.Button btnCargarPrueba;
        private System.Windows.Forms.TextBox txtCantidadPrueba;
        private System.Windows.Forms.GroupBox grpCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Label label1;
    }
}

