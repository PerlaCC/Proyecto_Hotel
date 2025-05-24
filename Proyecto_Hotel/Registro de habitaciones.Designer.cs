namespace Proyecto_Hotel
{
    partial class RegistrodeHabitaciones
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
            this.CmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.LblTipoHabitacion = new System.Windows.Forms.Label();
            this.LblNumerodeHabitacion = new System.Windows.Forms.Label();
            this.LblTarifaporNoche = new System.Windows.Forms.Label();
            this.TxtTarifaporNoche = new System.Windows.Forms.TextBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.LblFechadeIngreso = new System.Windows.Forms.Label();
            this.DtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.BtnRegistrarHabitacion = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.CmbNumerodeHabitacion = new System.Windows.Forms.ComboBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblDocumentoIdentificacion = new System.Windows.Forms.Label();
            this.CmbIdentificacion = new System.Windows.Forms.ComboBox();
            this.LblRFC = new System.Windows.Forms.Label();
            this.TxtRFC = new System.Windows.Forms.TextBox();
            this.LblAdultos = new System.Windows.Forms.Label();
            this.LblNiños = new System.Windows.Forms.Label();
            this.LblNumerodeDias = new System.Windows.Forms.Label();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblIVA = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.NumAdultos = new System.Windows.Forms.NumericUpDown();
            this.NumNiños = new System.Windows.Forms.NumericUpDown();
            this.NumDiashospedarse = new System.Windows.Forms.NumericUpDown();
            this.BtnImprimirFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNiños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDiashospedarse)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbTipoHabitacion
            // 
            this.CmbTipoHabitacion.FormattingEnabled = true;
            this.CmbTipoHabitacion.Location = new System.Drawing.Point(118, 169);
            this.CmbTipoHabitacion.Name = "CmbTipoHabitacion";
            this.CmbTipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoHabitacion.TabIndex = 0;
            this.CmbTipoHabitacion.Tag = "cd";
            this.CmbTipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.CmbTipoHabitacion_SelectedIndexChanged_1);
            // 
            // LblTipoHabitacion
            // 
            this.LblTipoHabitacion.AutoSize = true;
            this.LblTipoHabitacion.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoHabitacion.Location = new System.Drawing.Point(6, 176);
            this.LblTipoHabitacion.Name = "LblTipoHabitacion";
            this.LblTipoHabitacion.Size = new System.Drawing.Size(106, 16);
            this.LblTipoHabitacion.TabIndex = 1;
            this.LblTipoHabitacion.Text = "Tipo de habitacion";
            this.LblTipoHabitacion.Click += new System.EventHandler(this.LblTipoHabitacion_Click);
            // 
            // LblNumerodeHabitacion
            // 
            this.LblNumerodeHabitacion.AutoSize = true;
            this.LblNumerodeHabitacion.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumerodeHabitacion.Location = new System.Drawing.Point(6, 143);
            this.LblNumerodeHabitacion.Name = "LblNumerodeHabitacion";
            this.LblNumerodeHabitacion.Size = new System.Drawing.Size(126, 16);
            this.LblNumerodeHabitacion.TabIndex = 2;
            this.LblNumerodeHabitacion.Text = "Numero de habitacion";
            // 
            // LblTarifaporNoche
            // 
            this.LblTarifaporNoche.AutoSize = true;
            this.LblTarifaporNoche.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarifaporNoche.Location = new System.Drawing.Point(2, 211);
            this.LblTarifaporNoche.Name = "LblTarifaporNoche";
            this.LblTarifaporNoche.Size = new System.Drawing.Size(97, 16);
            this.LblTarifaporNoche.TabIndex = 4;
            this.LblTarifaporNoche.Text = "Tarifa por noche ";
            // 
            // TxtTarifaporNoche
            // 
            this.TxtTarifaporNoche.Location = new System.Drawing.Point(105, 207);
            this.TxtTarifaporNoche.Name = "TxtTarifaporNoche";
            this.TxtTarifaporNoche.Size = new System.Drawing.Size(121, 20);
            this.TxtTarifaporNoche.TabIndex = 5;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(362, 89);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(43, 16);
            this.LblEstado.TabIndex = 6;
            this.LblEstado.Text = "Estado";
            this.LblEstado.Click += new System.EventHandler(this.LblEstado_Click);
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(421, 84);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(121, 21);
            this.CmbEstado.TabIndex = 7;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(35, 20);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 16);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Text = "Nombre ";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Location = new System.Drawing.Point(105, 12);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(121, 20);
            this.TxtNombreCliente.TabIndex = 9;
            // 
            // LblFechadeIngreso
            // 
            this.LblFechadeIngreso.AutoSize = true;
            this.LblFechadeIngreso.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechadeIngreso.Location = new System.Drawing.Point(249, 34);
            this.LblFechadeIngreso.Name = "LblFechadeIngreso";
            this.LblFechadeIngreso.Size = new System.Drawing.Size(97, 16);
            this.LblFechadeIngreso.TabIndex = 10;
            this.LblFechadeIngreso.Text = "Fecha de ingreso";
            // 
            // DtpFechaIngreso
            // 
            this.DtpFechaIngreso.Location = new System.Drawing.Point(347, 30);
            this.DtpFechaIngreso.Name = "DtpFechaIngreso";
            this.DtpFechaIngreso.Size = new System.Drawing.Size(195, 20);
            this.DtpFechaIngreso.TabIndex = 11;
            // 
            // BtnRegistrarHabitacion
            // 
            this.BtnRegistrarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnRegistrarHabitacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarHabitacion.ForeColor = System.Drawing.Color.Red;
            this.BtnRegistrarHabitacion.Location = new System.Drawing.Point(380, 352);
            this.BtnRegistrarHabitacion.Name = "BtnRegistrarHabitacion";
            this.BtnRegistrarHabitacion.Size = new System.Drawing.Size(141, 23);
            this.BtnRegistrarHabitacion.TabIndex = 12;
            this.BtnRegistrarHabitacion.Text = "Registrar Habitacion";
            this.BtnRegistrarHabitacion.UseVisualStyleBackColor = false;
            this.BtnRegistrarHabitacion.Click += new System.EventHandler(this.BtnRegistrarHabitacion_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnRegresar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.Red;
            this.BtnRegresar.Location = new System.Drawing.Point(57, 352);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegresar.TabIndex = 14;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // CmbNumerodeHabitacion
            // 
            this.CmbNumerodeHabitacion.FormattingEnabled = true;
            this.CmbNumerodeHabitacion.Location = new System.Drawing.Point(130, 142);
            this.CmbNumerodeHabitacion.Name = "CmbNumerodeHabitacion";
            this.CmbNumerodeHabitacion.Size = new System.Drawing.Size(121, 21);
            this.CmbNumerodeHabitacion.TabIndex = 15;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(36, 50);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(57, 16);
            this.LblApellidos.TabIndex = 16;
            this.LblApellidos.Text = "Apellidos";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(105, 43);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(121, 20);
            this.TxtApellidos.TabIndex = 17;
            // 
            // LblDocumentoIdentificacion
            // 
            this.LblDocumentoIdentificacion.AutoSize = true;
            this.LblDocumentoIdentificacion.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDocumentoIdentificacion.Location = new System.Drawing.Point(-2, 84);
            this.LblDocumentoIdentificacion.Name = "LblDocumentoIdentificacion";
            this.LblDocumentoIdentificacion.Size = new System.Drawing.Size(161, 16);
            this.LblDocumentoIdentificacion.TabIndex = 18;
            this.LblDocumentoIdentificacion.Text = "Documento de Identificacion";
            // 
            // CmbIdentificacion
            // 
            this.CmbIdentificacion.FormattingEnabled = true;
            this.CmbIdentificacion.Location = new System.Drawing.Point(165, 79);
            this.CmbIdentificacion.Name = "CmbIdentificacion";
            this.CmbIdentificacion.Size = new System.Drawing.Size(121, 21);
            this.CmbIdentificacion.TabIndex = 19;
            // 
            // LblRFC
            // 
            this.LblRFC.AutoSize = true;
            this.LblRFC.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRFC.Location = new System.Drawing.Point(35, 116);
            this.LblRFC.Name = "LblRFC";
            this.LblRFC.Size = new System.Drawing.Size(28, 16);
            this.LblRFC.TabIndex = 20;
            this.LblRFC.Text = "RFC";
            // 
            // TxtRFC
            // 
            this.TxtRFC.Location = new System.Drawing.Point(105, 113);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(121, 20);
            this.TxtRFC.TabIndex = 21;
            // 
            // LblAdultos
            // 
            this.LblAdultos.AutoSize = true;
            this.LblAdultos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdultos.Location = new System.Drawing.Point(1, 242);
            this.LblAdultos.Name = "LblAdultos";
            this.LblAdultos.Size = new System.Drawing.Size(110, 16);
            this.LblAdultos.TabIndex = 22;
            this.LblAdultos.Text = "Adultos a hospedar";
            this.LblAdultos.Click += new System.EventHandler(this.LblAdultos_Click);
            // 
            // LblNiños
            // 
            this.LblNiños.AutoSize = true;
            this.LblNiños.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNiños.Location = new System.Drawing.Point(6, 271);
            this.LblNiños.Name = "LblNiños";
            this.LblNiños.Size = new System.Drawing.Size(100, 16);
            this.LblNiños.TabIndex = 23;
            this.LblNiños.Text = "Niños a hospedar";
            // 
            // LblNumerodeDias
            // 
            this.LblNumerodeDias.AutoSize = true;
            this.LblNumerodeDias.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumerodeDias.Location = new System.Drawing.Point(1, 307);
            this.LblNumerodeDias.Name = "LblNumerodeDias";
            this.LblNumerodeDias.Size = new System.Drawing.Size(163, 16);
            this.LblNumerodeDias.TabIndex = 24;
            this.LblNumerodeDias.Text = "Numero de dias a hospedarse";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.Location = new System.Drawing.Point(353, 142);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(52, 16);
            this.LblSubtotal.TabIndex = 28;
            this.LblSubtotal.Text = "Subtotal";
            // 
            // LblIVA
            // 
            this.LblIVA.AutoSize = true;
            this.LblIVA.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIVA.Location = new System.Drawing.Point(365, 175);
            this.LblIVA.Name = "LblIVA";
            this.LblIVA.Size = new System.Drawing.Size(26, 16);
            this.LblIVA.TabIndex = 29;
            this.LblIVA.Text = "IVA";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(329, 215);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(76, 16);
            this.LblTotal.TabIndex = 30;
            this.LblTotal.Text = "Total a pagar";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(421, 138);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.ReadOnly = true;
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.TxtSubtotal.TabIndex = 31;
            // 
            // TxtIVA
            // 
            this.TxtIVA.Location = new System.Drawing.Point(421, 175);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.ReadOnly = true;
            this.TxtIVA.Size = new System.Drawing.Size(100, 20);
            this.TxtIVA.TabIndex = 32;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(421, 211);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 33;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Red;
            this.BtnCancelar.Location = new System.Drawing.Point(151, 352);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 34;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NumAdultos
            // 
            this.NumAdultos.Location = new System.Drawing.Point(122, 238);
            this.NumAdultos.Name = "NumAdultos";
            this.NumAdultos.Size = new System.Drawing.Size(120, 20);
            this.NumAdultos.TabIndex = 35;
            // 
            // NumNiños
            // 
            this.NumNiños.Location = new System.Drawing.Point(119, 264);
            this.NumNiños.Name = "NumNiños";
            this.NumNiños.Size = new System.Drawing.Size(120, 20);
            this.NumNiños.TabIndex = 36;
            // 
            // NumDiashospedarse
            // 
            this.NumDiashospedarse.Location = new System.Drawing.Point(170, 303);
            this.NumDiashospedarse.Name = "NumDiashospedarse";
            this.NumDiashospedarse.Size = new System.Drawing.Size(120, 20);
            this.NumDiashospedarse.TabIndex = 37;
            // 
            // BtnImprimirFactura
            // 
            this.BtnImprimirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnImprimirFactura.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirFactura.ForeColor = System.Drawing.Color.Red;
            this.BtnImprimirFactura.Location = new System.Drawing.Point(252, 352);
            this.BtnImprimirFactura.Name = "BtnImprimirFactura";
            this.BtnImprimirFactura.Size = new System.Drawing.Size(101, 23);
            this.BtnImprimirFactura.TabIndex = 38;
            this.BtnImprimirFactura.Text = "Imprimir Factura";
            this.BtnImprimirFactura.UseVisualStyleBackColor = false;
            this.BtnImprimirFactura.Click += new System.EventHandler(this.BtnImprimirFactura_Click);
            // 
            // RegistrodeHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(550, 405);
            this.Controls.Add(this.BtnImprimirFactura);
            this.Controls.Add(this.NumDiashospedarse);
            this.Controls.Add(this.NumNiños);
            this.Controls.Add(this.NumAdultos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtIVA);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblIVA);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.LblNumerodeDias);
            this.Controls.Add(this.LblNiños);
            this.Controls.Add(this.LblAdultos);
            this.Controls.Add(this.TxtRFC);
            this.Controls.Add(this.LblRFC);
            this.Controls.Add(this.CmbIdentificacion);
            this.Controls.Add(this.LblDocumentoIdentificacion);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.CmbNumerodeHabitacion);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnRegistrarHabitacion);
            this.Controls.Add(this.DtpFechaIngreso);
            this.Controls.Add(this.LblFechadeIngreso);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.TxtTarifaporNoche);
            this.Controls.Add(this.LblTarifaporNoche);
            this.Controls.Add(this.LblNumerodeHabitacion);
            this.Controls.Add(this.LblTipoHabitacion);
            this.Controls.Add(this.CmbTipoHabitacion);
            this.Name = "RegistrodeHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de habitaciones";
            this.Load += new System.EventHandler(this.RegistrodeHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNiños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDiashospedarse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTipoHabitacion;
        private System.Windows.Forms.Label LblTipoHabitacion;
        private System.Windows.Forms.Label LblNumerodeHabitacion;
        private System.Windows.Forms.Label LblTarifaporNoche;
        private System.Windows.Forms.TextBox TxtTarifaporNoche;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label LblFechadeIngreso;
        private System.Windows.Forms.DateTimePicker DtpFechaIngreso;
        private System.Windows.Forms.Button BtnRegistrarHabitacion;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.ComboBox CmbNumerodeHabitacion;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblDocumentoIdentificacion;
        private System.Windows.Forms.ComboBox CmbIdentificacion;
        private System.Windows.Forms.Label LblRFC;
        private System.Windows.Forms.TextBox TxtRFC;
        private System.Windows.Forms.Label LblAdultos;
        private System.Windows.Forms.Label LblNiños;
        private System.Windows.Forms.Label LblNumerodeDias;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblIVA;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown NumAdultos;
        private System.Windows.Forms.NumericUpDown NumNiños;
        private System.Windows.Forms.NumericUpDown NumDiashospedarse;
        private System.Windows.Forms.Button BtnImprimirFactura;
    }
}