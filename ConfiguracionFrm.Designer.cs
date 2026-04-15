namespace UDB_PED_Biblioteca
{
    partial class ConfiguracionFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConfiguracion = new System.Windows.Forms.TabControl();
            this.pnlConfiguracion = new System.Windows.Forms.TabPage();
            this.pnlUsuarios = new System.Windows.Forms.TabPage();
            this.lblConfigVolver = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblConfigVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración";
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.Controls.Add(this.pnlConfiguracion);
            this.tabConfiguracion.Controls.Add(this.pnlUsuarios);
            this.tabConfiguracion.Location = new System.Drawing.Point(1, 55);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.SelectedIndex = 0;
            this.tabConfiguracion.Size = new System.Drawing.Size(1151, 647);
            this.tabConfiguracion.TabIndex = 1;
            // 
            // pnlConfiguracion
            // 
            this.pnlConfiguracion.Location = new System.Drawing.Point(4, 22);
            this.pnlConfiguracion.Name = "pnlConfiguracion";
            this.pnlConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.pnlConfiguracion.Size = new System.Drawing.Size(1143, 621);
            this.pnlConfiguracion.TabIndex = 0;
            this.pnlConfiguracion.Text = "Configuración";
            this.pnlConfiguracion.UseVisualStyleBackColor = true;
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Location = new System.Drawing.Point(4, 22);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.pnlUsuarios.Size = new System.Drawing.Size(1143, 621);
            this.pnlUsuarios.TabIndex = 1;
            this.pnlUsuarios.Text = "Usuarios";
            this.pnlUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblConfigVolver
            // 
            this.lblConfigVolver.AutoSize = true;
            this.lblConfigVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigVolver.ForeColor = System.Drawing.Color.Gold;
            this.lblConfigVolver.Location = new System.Drawing.Point(11, 15);
            this.lblConfigVolver.Name = "lblConfigVolver";
            this.lblConfigVolver.Size = new System.Drawing.Size(64, 16);
            this.lblConfigVolver.TabIndex = 1;
            this.lblConfigVolver.Text = "< Volver";
            this.lblConfigVolver.Click += new System.EventHandler(this.lblConfigVolver_Click);
            // 
            // ConfiguracionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.tabConfiguracion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguracionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabConfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabConfiguracion;
        private System.Windows.Forms.TabPage pnlConfiguracion;
        private System.Windows.Forms.TabPage pnlUsuarios;
        private System.Windows.Forms.Label lblConfigVolver;
    }
}