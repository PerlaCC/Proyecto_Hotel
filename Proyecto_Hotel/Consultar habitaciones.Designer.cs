namespace Proyecto_Hotel
{
    partial class ConsultarHabitaciones
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
            this.LblTotalDeHabitacionesLibres = new System.Windows.Forms.Label();
            this.DgvHabitaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTotalDeHabitacionesLibres
            // 
            this.LblTotalDeHabitacionesLibres.AutoSize = true;
            this.LblTotalDeHabitacionesLibres.Location = new System.Drawing.Point(34, 200);
            this.LblTotalDeHabitacionesLibres.Name = "LblTotalDeHabitacionesLibres";
            this.LblTotalDeHabitacionesLibres.Size = new System.Drawing.Size(0, 13);
            this.LblTotalDeHabitacionesLibres.TabIndex = 3;
            this.LblTotalDeHabitacionesLibres.Click += new System.EventHandler(this.LblTotalDeHabitacionesLibres_Click);
            // 
            // DgvHabitaciones
            // 
            this.DgvHabitaciones.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DgvHabitaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHabitaciones.Location = new System.Drawing.Point(12, 12);
            this.DgvHabitaciones.Name = "DgvHabitaciones";
            this.DgvHabitaciones.Size = new System.Drawing.Size(341, 266);
            this.DgvHabitaciones.TabIndex = 4;
            this.DgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitaciones_CellContentClick);
            // 
            // ConsultarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(365, 290);
            this.Controls.Add(this.DgvHabitaciones);
            this.Controls.Add(this.LblTotalDeHabitacionesLibres);
            this.Name = "ConsultarHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTotalDeHabitacionesLibres;
        private System.Windows.Forms.DataGridView DgvHabitaciones;
    }
}