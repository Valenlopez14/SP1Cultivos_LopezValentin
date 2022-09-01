namespace pry.SP1.LopezValentin
{
    partial class frmCultivos
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
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtCultivo = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mskCultivos = new System.Windows.Forms.MaskedTextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(12, 20);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(42, 13);
            this.lblCultivo.TabIndex = 0;
            this.lblCultivo.Text = "Cultivo:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 56);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // txtCultivo
            // 
            this.txtCultivo.Location = new System.Drawing.Point(61, 20);
            this.txtCultivo.Name = "txtCultivo";
            this.txtCultivo.Size = new System.Drawing.Size(81, 20);
            this.txtCultivo.TabIndex = 3;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(236, 114);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 5;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // mskCultivos
            // 
            this.mskCultivos.Location = new System.Drawing.Point(89, 56);
            this.mskCultivos.Mask = "9-99";
            this.mskCultivos.Name = "mskCultivos";
            this.mskCultivos.Size = new System.Drawing.Size(26, 20);
            this.mskCultivos.TabIndex = 6;
            this.mskCultivos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(7, 114);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 7;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 149);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.mskCultivos);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.txtCultivo);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblCultivo);
            this.Name = "frmCultivos";
            this.Text = "Cargar Cultivos";
            this.Load += new System.EventHandler(this.frmCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtCultivo;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.MaskedTextBox mskCultivos;
        private System.Windows.Forms.Button cmdBorrar;
    }
}