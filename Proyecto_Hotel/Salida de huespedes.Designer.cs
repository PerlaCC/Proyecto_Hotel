namespace Proyecto_Hotel
{
    partial class SalidadeHuespedes
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
            this.LblNumeroHabitaciones = new System.Windows.Forms.Label();
            this.CmbNumHabitacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblRealizosupago = new System.Windows.Forms.Label();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.BtnConfirmarSalida = new System.Windows.Forms.Button();
            this.CmbPago = new System.Windows.Forms.ComboBox();
            this.LblEntregoLlaves = new System.Windows.Forms.Label();
            this.CmbEntregoLlaves = new System.Windows.Forms.ComboBox();
            this.LblFechaSalida = new System.Windows.Forms.Label();
            this.DtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNumeroHabitaciones
            // 
            this.LblNumeroHabitaciones.AutoSize = true;
            this.LblNumeroHabitaciones.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroHabitaciones.Location = new System.Drawing.Point(32, 33);
            this.LblNumeroHabitaciones.Name = "LblNumeroHabitaciones";
            this.LblNumeroHabitaciones.Size = new System.Drawing.Size(126, 16);
            this.LblNumeroHabitaciones.TabIndex = 0;
            this.LblNumeroHabitaciones.Text = "Numero de habitacion";
            // 
            // CmbNumHabitacion
            // 
            this.CmbNumHabitacion.FormattingEnabled = true;
            this.CmbNumHabitacion.Location = new System.Drawing.Point(161, 30);
            this.CmbNumHabitacion.Name = "CmbNumHabitacion";
            this.CmbNumHabitacion.Size = new System.Drawing.Size(121, 21);
            this.CmbNumHabitacion.TabIndex = 1;
            this.CmbNumHabitacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dias de estancia";
            // 
            // LblRealizosupago
            // 
            this.LblRealizosupago.AutoSize = true;
            this.LblRealizosupago.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRealizosupago.Location = new System.Drawing.Point(55, 104);
            this.LblRealizosupago.Name = "LblRealizosupago";
            this.LblRealizosupago.Size = new System.Drawing.Size(90, 16);
            this.LblRealizosupago.TabIndex = 3;
            this.LblRealizosupago.Text = "Realizo su pago";
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(161, 70);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(121, 20);
            this.TxtDias.TabIndex = 4;
            // 
            // BtnConfirmarSalida
            // 
            this.BtnConfirmarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnConfirmarSalida.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarSalida.Location = new System.Drawing.Point(249, 232);
            this.BtnConfirmarSalida.Name = "BtnConfirmarSalida";
            this.BtnConfirmarSalida.Size = new System.Drawing.Size(102, 23);
            this.BtnConfirmarSalida.TabIndex = 6;
            this.BtnConfirmarSalida.Text = "Confirmar Salida";
            this.BtnConfirmarSalida.UseVisualStyleBackColor = false;
            this.BtnConfirmarSalida.Click += new System.EventHandler(this.BtnConfirmarSalida_Click);
            // 
            // CmbPago
            // 
            this.CmbPago.FormattingEnabled = true;
            this.CmbPago.Location = new System.Drawing.Point(161, 99);
            this.CmbPago.Name = "CmbPago";
            this.CmbPago.Size = new System.Drawing.Size(121, 21);
            this.CmbPago.TabIndex = 7;
            // 
            // LblEntregoLlaves
            // 
            this.LblEntregoLlaves.AutoSize = true;
            this.LblEntregoLlaves.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntregoLlaves.Location = new System.Drawing.Point(64, 142);
            this.LblEntregoLlaves.Name = "LblEntregoLlaves";
            this.LblEntregoLlaves.Size = new System.Drawing.Size(81, 16);
            this.LblEntregoLlaves.TabIndex = 8;
            this.LblEntregoLlaves.Text = "Entrego llaves";
            // 
            // CmbEntregoLlaves
            // 
            this.CmbEntregoLlaves.FormattingEnabled = true;
            this.CmbEntregoLlaves.Location = new System.Drawing.Point(161, 137);
            this.CmbEntregoLlaves.Name = "CmbEntregoLlaves";
            this.CmbEntregoLlaves.Size = new System.Drawing.Size(121, 21);
            this.CmbEntregoLlaves.TabIndex = 9;
            // 
            // LblFechaSalida
            // 
            this.LblFechaSalida.AutoSize = true;
            this.LblFechaSalida.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaSalida.Location = new System.Drawing.Point(57, 182);
            this.LblFechaSalida.Name = "LblFechaSalida";
            this.LblFechaSalida.Size = new System.Drawing.Size(88, 16);
            this.LblFechaSalida.TabIndex = 10;
            this.LblFechaSalida.Text = "Fecha de salida";
            // 
            // DtpFechaSalida
            // 
            this.DtpFechaSalida.Location = new System.Drawing.Point(161, 178);
            this.DtpFechaSalida.Name = "DtpFechaSalida";
            this.DtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaSalida.TabIndex = 11;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(125, 232);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // SalidadeHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(388, 267);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DtpFechaSalida);
            this.Controls.Add(this.LblFechaSalida);
            this.Controls.Add(this.CmbEntregoLlaves);
            this.Controls.Add(this.LblEntregoLlaves);
            this.Controls.Add(this.CmbPago);
            this.Controls.Add(this.BtnConfirmarSalida);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.LblRealizosupago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbNumHabitacion);
            this.Controls.Add(this.LblNumeroHabitaciones);
            this.Name = "SalidadeHuespedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida de huespedes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumeroHabitaciones;
        private System.Windows.Forms.ComboBox CmbNumHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRealizosupago;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Button BtnConfirmarSalida;
        private System.Windows.Forms.ComboBox CmbPago;
        private System.Windows.Forms.Label LblEntregoLlaves;
        private System.Windows.Forms.ComboBox CmbEntregoLlaves;
        private System.Windows.Forms.Label LblFechaSalida;
        private System.Windows.Forms.DateTimePicker DtpFechaSalida;
        private System.Windows.Forms.Button BtnCancelar;
    }
}