namespace Proyecto_Hotel
{
    partial class Gestion_de_Huespedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_Huespedes));
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.TsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsbModificar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(12, 45);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(414, 292);
            this.DgvClientes.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Blue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbAgregar,
            this.TsbEliminar,
            this.TsbModificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(438, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbAgregar
            // 
            this.TsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("TsbAgregar.Image")));
            this.TsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAgregar.Name = "TsbAgregar";
            this.TsbAgregar.Size = new System.Drawing.Size(29, 29);
            this.TsbAgregar.Text = "TsBAgregar";
            this.TsbAgregar.Click += new System.EventHandler(this.TsbAgregar_Click);
            // 
            // TsbEliminar
            // 
            this.TsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEliminar.Image")));
            this.TsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEliminar.Name = "TsbEliminar";
            this.TsbEliminar.Size = new System.Drawing.Size(29, 29);
            this.TsbEliminar.Text = "TsbEliminar";
            this.TsbEliminar.Click += new System.EventHandler(this.TsbEliminar_Click);
            // 
            // TsbModificar
            // 
            this.TsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("TsbModificar.Image")));
            this.TsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbModificar.Name = "TsbModificar";
            this.TsbModificar.Size = new System.Drawing.Size(29, 29);
            this.TsbModificar.Text = "TsbModificar";
            this.TsbModificar.Click += new System.EventHandler(this.TsbModificar_Click);
            // 
            // Gestion_de_Huespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(438, 349);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DgvClientes);
            this.Name = "Gestion_de_Huespedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_de_Huespedes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbAgregar;
        private System.Windows.Forms.ToolStripButton TsbEliminar;
        private System.Windows.Forms.ToolStripButton TsbModificar;
    }
}