namespace UDB_PED_Biblioteca
{
    partial class HomeFrm
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
            this.btnCerrarHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGestiones = new System.Windows.Forms.Panel();
            this.pnlHomeConfig = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlGestiones.SuspendLayout();
            this.pnlHomeConfig.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrarHome);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrarHome
            // 
            this.btnCerrarHome.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarHome.Location = new System.Drawing.Point(1118, 11);
            this.btnCerrarHome.Name = "btnCerrarHome";
            this.btnCerrarHome.Size = new System.Drawing.Size(28, 26);
            this.btnCerrarHome.TabIndex = 1;
            this.btnCerrarHome.Text = "X";
            this.btnCerrarHome.UseVisualStyleBackColor = false;
            this.btnCerrarHome.Click += new System.EventHandler(this.btnCerrarHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(450, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de bibliotecario";
            // 
            // pnlGestiones
            // 
            this.pnlGestiones.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlGestiones.Controls.Add(this.label2);
            this.pnlGestiones.Location = new System.Drawing.Point(257, 159);
            this.pnlGestiones.Name = "pnlGestiones";
            this.pnlGestiones.Size = new System.Drawing.Size(250, 150);
            this.pnlGestiones.TabIndex = 1;
            this.pnlGestiones.Click += new System.EventHandler(this.pnlGestiones_Click);
            // 
            // pnlHomeConfig
            // 
            this.pnlHomeConfig.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlHomeConfig.Controls.Add(this.label3);
            this.pnlHomeConfig.Location = new System.Drawing.Point(622, 159);
            this.pnlHomeConfig.Name = "pnlHomeConfig";
            this.pnlHomeConfig.Size = new System.Drawing.Size(250, 150);
            this.pnlHomeConfig.TabIndex = 2;
            this.pnlHomeConfig.Click += new System.EventHandler(this.pnlHomeConfig_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(257, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 150);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Violet;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(622, 361);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 150);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestiones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Configuración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prestamos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Devoluciones";
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlHomeConfig);
            this.Controls.Add(this.pnlGestiones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGestiones.ResumeLayout(false);
            this.pnlGestiones.PerformLayout();
            this.pnlHomeConfig.ResumeLayout(false);
            this.pnlHomeConfig.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGestiones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlHomeConfig;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}