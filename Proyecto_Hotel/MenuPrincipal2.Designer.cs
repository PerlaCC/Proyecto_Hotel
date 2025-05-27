namespace Proyecto_Hotel
{
    partial class MenuPrincipal2
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
            this.LblHotelElSol = new System.Windows.Forms.Label();
            this.LblBienvenidoalMenu = new System.Windows.Forms.Label();
            this.BtnRegistrodeHabitaciones = new System.Windows.Forms.Button();
            this.BtnConsultarHabitaciones = new System.Windows.Forms.Button();
            this.BtnSalidadeHuespedes = new System.Windows.Forms.Button();
            this.BtnImprimirFactura = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHotelElSol
            // 
            this.LblHotelElSol.AutoSize = true;
            this.LblHotelElSol.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHotelElSol.Location = new System.Drawing.Point(106, 31);
            this.LblHotelElSol.Name = "LblHotelElSol";
            this.LblHotelElSol.Size = new System.Drawing.Size(202, 47);
            this.LblHotelElSol.TabIndex = 0;
            this.LblHotelElSol.Text = "Hotel \"El Sol\"";
            // 
            // LblBienvenidoalMenu
            // 
            this.LblBienvenidoalMenu.AutoSize = true;
            this.LblBienvenidoalMenu.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenidoalMenu.ForeColor = System.Drawing.Color.Blue;
            this.LblBienvenidoalMenu.Location = new System.Drawing.Point(96, 90);
            this.LblBienvenidoalMenu.Name = "LblBienvenidoalMenu";
            this.LblBienvenidoalMenu.Size = new System.Drawing.Size(201, 20);
            this.LblBienvenidoalMenu.TabIndex = 1;
            this.LblBienvenidoalMenu.Text = "Bienvenido al Menu Principal";
            // 
            // BtnRegistrodeHabitaciones
            // 
            this.BtnRegistrodeHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRegistrodeHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrodeHabitaciones.Location = new System.Drawing.Point(62, 134);
            this.BtnRegistrodeHabitaciones.Name = "BtnRegistrodeHabitaciones";
            this.BtnRegistrodeHabitaciones.Size = new System.Drawing.Size(131, 51);
            this.BtnRegistrodeHabitaciones.TabIndex = 2;
            this.BtnRegistrodeHabitaciones.Text = "Registro de habitaciones";
            this.BtnRegistrodeHabitaciones.UseVisualStyleBackColor = false;
            this.BtnRegistrodeHabitaciones.Click += new System.EventHandler(this.BtnRegistrodeHabitaciones_Click);
            // 
            // BtnConsultarHabitaciones
            // 
            this.BtnConsultarHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnConsultarHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarHabitaciones.Location = new System.Drawing.Point(240, 134);
            this.BtnConsultarHabitaciones.Name = "BtnConsultarHabitaciones";
            this.BtnConsultarHabitaciones.Size = new System.Drawing.Size(123, 51);
            this.BtnConsultarHabitaciones.TabIndex = 3;
            this.BtnConsultarHabitaciones.Text = "Consultar habitaciones";
            this.BtnConsultarHabitaciones.UseVisualStyleBackColor = false;
            this.BtnConsultarHabitaciones.Click += new System.EventHandler(this.BtnConsultarHabitaciones_Click);
            // 
            // BtnSalidadeHuespedes
            // 
            this.BtnSalidadeHuespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSalidadeHuespedes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidadeHuespedes.Location = new System.Drawing.Point(62, 211);
            this.BtnSalidadeHuespedes.Name = "BtnSalidadeHuespedes";
            this.BtnSalidadeHuespedes.Size = new System.Drawing.Size(131, 51);
            this.BtnSalidadeHuespedes.TabIndex = 4;
            this.BtnSalidadeHuespedes.Text = "Salida de huespedes";
            this.BtnSalidadeHuespedes.UseVisualStyleBackColor = false;
            this.BtnSalidadeHuespedes.Click += new System.EventHandler(this.BtnSalidadeHuespedes_Click);
            // 
            // BtnImprimirFactura
            // 
            this.BtnImprimirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnImprimirFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirFactura.Location = new System.Drawing.Point(240, 211);
            this.BtnImprimirFactura.Name = "BtnImprimirFactura";
            this.BtnImprimirFactura.Size = new System.Drawing.Size(123, 51);
            this.BtnImprimirFactura.TabIndex = 5;
            this.BtnImprimirFactura.Text = "Imprimir factura";
            this.BtnImprimirFactura.UseVisualStyleBackColor = false;
            this.BtnImprimirFactura.Click += new System.EventHandler(this.BtnImprimirFactura_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(163, 293);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 32);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // MenuPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(437, 337);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnImprimirFactura);
            this.Controls.Add(this.BtnSalidadeHuespedes);
            this.Controls.Add(this.BtnConsultarHabitaciones);
            this.Controls.Add(this.BtnRegistrodeHabitaciones);
            this.Controls.Add(this.LblBienvenidoalMenu);
            this.Controls.Add(this.LblHotelElSol);
            this.Name = "MenuPrincipal2";
            this.Text = "MenuPrincipal2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHotelElSol;
        private System.Windows.Forms.Label LblBienvenidoalMenu;
        private System.Windows.Forms.Button BtnRegistrodeHabitaciones;
        private System.Windows.Forms.Button BtnConsultarHabitaciones;
        private System.Windows.Forms.Button BtnSalidadeHuespedes;
        private System.Windows.Forms.Button BtnImprimirFactura;
        private System.Windows.Forms.Button BtnSalir;
    }
}