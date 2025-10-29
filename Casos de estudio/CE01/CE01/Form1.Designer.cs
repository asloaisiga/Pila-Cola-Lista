namespace CE01
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpNuevaAcción = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.grpUltima = new System.Windows.Forms.GroupBox();
            this.lblUltima = new System.Windows.Forms.Label();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.grpNuevaAcción.SuspendLayout();
            this.grpUltima.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(220, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE VERSIONES (LIFO - UNDO)";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(636, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(638, 31);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(104, 42);
            this.btnDeshacer.TabIndex = 5;
            this.btnDeshacer.Text = "DESHACER";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 575);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total de Acciones:";
            // 
            // grpNuevaAcción
            // 
            this.grpNuevaAcción.Controls.Add(this.txtDescripcion);
            this.grpNuevaAcción.Controls.Add(this.lblDescripcion);
            this.grpNuevaAcción.Controls.Add(this.cmbTipo);
            this.grpNuevaAcción.Controls.Add(this.label2);
            this.grpNuevaAcción.Controls.Add(this.btnAgregar);
            this.grpNuevaAcción.Location = new System.Drawing.Point(98, 72);
            this.grpNuevaAcción.Name = "grpNuevaAcción";
            this.grpNuevaAcción.Size = new System.Drawing.Size(777, 100);
            this.grpNuevaAcción.TabIndex = 9;
            this.grpNuevaAcción.TabStop = false;
            this.grpNuevaAcción.Text = "Nueva Acción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(59, 27);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(214, 24);
            this.cmbTipo.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 62);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(439, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // grpUltima
            // 
            this.grpUltima.Controls.Add(this.lblUltima);
            this.grpUltima.Controls.Add(this.btnDeshacer);
            this.grpUltima.Location = new System.Drawing.Point(98, 209);
            this.grpUltima.Name = "grpUltima";
            this.grpUltima.Size = new System.Drawing.Size(777, 100);
            this.grpUltima.TabIndex = 10;
            this.grpUltima.TabStop = false;
            this.grpUltima.Text = "Última Acción";
            // 
            // lblUltima
            // 
            this.lblUltima.AutoSize = true;
            this.lblUltima.Location = new System.Drawing.Point(15, 31);
            this.lblUltima.Name = "lblUltima";
            this.lblUltima.Size = new System.Drawing.Size(48, 16);
            this.lblUltima.TabIndex = 6;
            this.lblUltima.Text = "Última:";
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.lstHistorial);
            this.grpHistorial.Location = new System.Drawing.Point(98, 347);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(777, 194);
            this.grpHistorial.TabIndex = 11;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial (más reciente primero)";
            // 
            // lstHistorial
            // 
            this.lstHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.IntegralHeight = false;
            this.lstHistorial.ItemHeight = 16;
            this.lstHistorial.Location = new System.Drawing.Point(3, 18);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(771, 173);
            this.lstHistorial.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 600);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.grpUltima);
            this.Controls.Add(this.grpNuevaAcción);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpNuevaAcción.ResumeLayout(false);
            this.grpNuevaAcción.PerformLayout();
            this.grpUltima.ResumeLayout(false);
            this.grpUltima.PerformLayout();
            this.grpHistorial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpNuevaAcción;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpUltima;
        private System.Windows.Forms.Label lblUltima;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}

