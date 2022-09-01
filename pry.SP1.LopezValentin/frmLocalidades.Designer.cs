namespace pry.SP1.LopezValentin
{
    partial class frmLocalidades
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
            this.lblNumeroLoc = new System.Windows.Forms.Label();
            this.mskNroLoc = new System.Windows.Forms.MaskedTextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroLoc
            // 
            this.lblNumeroLoc.AutoSize = true;
            this.lblNumeroLoc.Location = new System.Drawing.Point(12, 24);
            this.lblNumeroLoc.Name = "lblNumeroLoc";
            this.lblNumeroLoc.Size = new System.Drawing.Size(143, 13);
            this.lblNumeroLoc.TabIndex = 0;
            this.lblNumeroLoc.Text = "Ingrese numero de localidad:";
            // 
            // mskNroLoc
            // 
            this.mskNroLoc.Location = new System.Drawing.Point(162, 24);
            this.mskNroLoc.Mask = "9999";
            this.mskNroLoc.Name = "mskNroLoc";
            this.mskNroLoc.Size = new System.Drawing.Size(32, 20);
            this.mskNroLoc.TabIndex = 1;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(13, 56);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(143, 13);
            this.lblLocalidad.TabIndex = 2;
            this.lblLocalidad.Text = "Ingrese nombre de localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(162, 56);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(71, 20);
            this.txtLocalidad.TabIndex = 3;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(12, 109);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 4;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(231, 109);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 5;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 144);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.mskNroLoc);
            this.Controls.Add(this.lblNumeroLoc);
            this.Name = "frmLocalidades";
            this.Text = "Cargar Localidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroLoc;
        private System.Windows.Forms.MaskedTextBox mskNroLoc;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdCargar;
    }
}