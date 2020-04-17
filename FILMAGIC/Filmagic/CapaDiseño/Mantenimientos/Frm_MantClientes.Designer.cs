namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantClientes));
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.nombrecliente = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.codigocliente = new System.Windows.Forms.TextBox();
            this.membresia = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_estadoJornada = new System.Windows.Forms.Label();
            this.Lbl_horasJornada = new System.Windows.Forms.Label();
            this.Lbl_nombreJornada = new System.Windows.Forms.Label();
            this.Lbl_codigoJornada = new System.Windows.Forms.Label();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Lbl_MantenimientoJornada = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Gpb_datos.SuspendLayout();
            this.Pnl_nombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.nombrecliente);
            this.Gpb_datos.Controls.Add(this.telefono);
            this.Gpb_datos.Controls.Add(this.codigocliente);
            this.Gpb_datos.Controls.Add(this.membresia);
            this.Gpb_datos.Controls.Add(this.estado);
            this.Gpb_datos.Controls.Add(this.fechanacimiento);
            this.Gpb_datos.Controls.Add(this.label1);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Controls.Add(this.Lbl_estadoJornada);
            this.Gpb_datos.Controls.Add(this.Lbl_horasJornada);
            this.Gpb_datos.Controls.Add(this.Lbl_nombreJornada);
            this.Gpb_datos.Controls.Add(this.Lbl_codigoJornada);
            this.Gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(30, 172);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb_datos.Size = new System.Drawing.Size(619, 188);
            this.Gpb_datos.TabIndex = 80;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // nombrecliente
            // 
            this.nombrecliente.Location = new System.Drawing.Point(435, 34);
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.Size = new System.Drawing.Size(166, 23);
            this.nombrecliente.TabIndex = 18;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(110, 90);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 23);
            this.telefono.TabIndex = 17;
            // 
            // codigocliente
            // 
            this.codigocliente.Location = new System.Drawing.Point(142, 31);
            this.codigocliente.Name = "codigocliente";
            this.codigocliente.Size = new System.Drawing.Size(123, 23);
            this.codigocliente.TabIndex = 16;
            // 
            // membresia
            // 
            this.membresia.Location = new System.Drawing.Point(110, 142);
            this.membresia.Name = "membresia";
            this.membresia.Size = new System.Drawing.Size(100, 23);
            this.membresia.TabIndex = 15;
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estado.Location = new System.Drawing.Point(411, 140);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(133, 25);
            this.estado.TabIndex = 14;
            this.estado.SelectedIndexChanged += new System.EventHandler(this.estado_SelectedIndexChanged);
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechanacimiento.Location = new System.Drawing.Point(472, 93);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Size = new System.Drawing.Size(111, 23);
            this.fechanacimiento.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Membresia";
            // 
            // Lbl_estadoJornada
            // 
            this.Lbl_estadoJornada.AutoSize = true;
            this.Lbl_estadoJornada.Location = new System.Drawing.Point(327, 93);
            this.Lbl_estadoJornada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_estadoJornada.Name = "Lbl_estadoJornada";
            this.Lbl_estadoJornada.Size = new System.Drawing.Size(131, 17);
            this.Lbl_estadoJornada.TabIndex = 10;
            this.Lbl_estadoJornada.Text = "Fecha de naciminto";
            // 
            // Lbl_horasJornada
            // 
            this.Lbl_horasJornada.AutoSize = true;
            this.Lbl_horasJornada.Location = new System.Drawing.Point(20, 93);
            this.Lbl_horasJornada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_horasJornada.Name = "Lbl_horasJornada";
            this.Lbl_horasJornada.Size = new System.Drawing.Size(64, 17);
            this.Lbl_horasJornada.TabIndex = 8;
            this.Lbl_horasJornada.Text = "Telefono";
            // 
            // Lbl_nombreJornada
            // 
            this.Lbl_nombreJornada.AutoSize = true;
            this.Lbl_nombreJornada.Location = new System.Drawing.Point(327, 34);
            this.Lbl_nombreJornada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombreJornada.Name = "Lbl_nombreJornada";
            this.Lbl_nombreJornada.Size = new System.Drawing.Size(103, 17);
            this.Lbl_nombreJornada.TabIndex = 2;
            this.Lbl_nombreJornada.Text = "Nombre cliente";
            // 
            // Lbl_codigoJornada
            // 
            this.Lbl_codigoJornada.AutoSize = true;
            this.Lbl_codigoJornada.Location = new System.Drawing.Point(20, 34);
            this.Lbl_codigoJornada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigoJornada.Name = "Lbl_codigoJornada";
            this.Lbl_codigoJornada.Size = new System.Drawing.Size(117, 17);
            this.Lbl_codigoJornada.TabIndex = 1;
            this.Lbl_codigoJornada.Text = "Codigo de cliente";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(119)))));
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.ForeColor = System.Drawing.Color.White;
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(460, 64);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(140, 89);
            this.Btn_consultar.TabIndex = 79;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(119)))));
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.ForeColor = System.Drawing.Color.White;
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(375, 64);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(86, 89);
            this.Btn_borrar.TabIndex = 78;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(119)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(291, 64);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(86, 89);
            this.Btn_guardar.TabIndex = 77;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(119)))));
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.Color.White;
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(207, 64);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(86, 89);
            this.Btn_editar.TabIndex = 76;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(119)))));
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(123, 64);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(86, 89);
            this.Btn_ingresar.TabIndex = 75;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(119)))));
            this.Pnl_nombreForm.Controls.Add(this.Btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.Btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.Lbl_MantenimientoJornada);
            this.Pnl_nombreForm.Controls.Add(this.Btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(803, 51);
            this.Pnl_nombreForm.TabIndex = 74;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(616, 8);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.Btn_Ayuda.TabIndex = 11;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(581, 8);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.Btn_minimizar.TabIndex = 10;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Lbl_MantenimientoJornada
            // 
            this.Lbl_MantenimientoJornada.AutoSize = true;
            this.Lbl_MantenimientoJornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MantenimientoJornada.ForeColor = System.Drawing.Color.White;
            this.Lbl_MantenimientoJornada.Location = new System.Drawing.Point(20, 12);
            this.Lbl_MantenimientoJornada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_MantenimientoJornada.Name = "Lbl_MantenimientoJornada";
            this.Lbl_MantenimientoJornada.Size = new System.Drawing.Size(275, 20);
            this.Lbl_MantenimientoJornada.TabIndex = 0;
            this.Lbl_MantenimientoJornada.Text = "MANTENIMIENTO DE CLIENTES";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(654, 8);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.Btn_cerrar.TabIndex = 12;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Frm_MantClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 376);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MantClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantClientes";
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label Lbl_estadoJornada;
        private System.Windows.Forms.Label Lbl_horasJornada;
        private System.Windows.Forms.Label Lbl_nombreJornada;
        private System.Windows.Forms.Label Lbl_codigoJornada;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_MantenimientoJornada;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombrecliente;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox codigocliente;
        private System.Windows.Forms.TextBox membresia;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.DateTimePicker fechanacimiento;
    }
}