namespace wWellMindTracker
{
    partial class frmRegistrarEmocion
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerProgerso = new System.Windows.Forms.Button();
            this.lblBienvedida = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbEmociones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(183, 223);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 77);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerProgerso
            // 
            this.btnVerProgerso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProgerso.Location = new System.Drawing.Point(380, 223);
            this.btnVerProgerso.Name = "btnVerProgerso";
            this.btnVerProgerso.Size = new System.Drawing.Size(167, 77);
            this.btnVerProgerso.TabIndex = 1;
            this.btnVerProgerso.Text = "Ver Progreso";
            this.btnVerProgerso.UseVisualStyleBackColor = true;
            this.btnVerProgerso.Click += new System.EventHandler(this.btnVerProgerso_Click);
            // 
            // lblBienvedida
            // 
            this.lblBienvedida.AutoSize = true;
            this.lblBienvedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvedida.Location = new System.Drawing.Point(80, 64);
            this.lblBienvedida.Name = "lblBienvedida";
            this.lblBienvedida.Size = new System.Drawing.Size(559, 34);
            this.lblBienvedida.TabIndex = 2;
            this.lblBienvedida.Text = "Hola [Nombre], Como Te Sientes Hoy";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(333, 318);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 34);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "----";
            // 
            // cmbEmociones
            // 
            this.cmbEmociones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmociones.FormattingEnabled = true;
            this.cmbEmociones.Location = new System.Drawing.Point(249, 132);
            this.cmbEmociones.Name = "cmbEmociones";
            this.cmbEmociones.Size = new System.Drawing.Size(217, 42);
            this.cmbEmociones.TabIndex = 4;
            // 
            // frmRegistrarEmocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.cmbEmociones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblBienvedida);
            this.Controls.Add(this.btnVerProgerso);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmRegistrarEmocion";
            this.Text = "RegistrarEmocion";
            this.Load += new System.EventHandler(this.frmRegistrarEmocion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerProgerso;
        private System.Windows.Forms.Label lblBienvedida;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbEmociones;
    }
}