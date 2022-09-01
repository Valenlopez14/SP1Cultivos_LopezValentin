namespace pry.SP1.LopezValentin
{
    partial class frmProduccion
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
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCultivos = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lstCultivos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(13, 22);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 0;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Location = new System.Drawing.Point(13, 56);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(47, 13);
            this.lblCultivos.TabIndex = 1;
            this.lblCultivos.Text = "Cultivos:";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(13, 88);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(60, 13);
            this.lblToneladas.TabIndex = 2;
            this.lblToneladas.Text = "Toneladas:";
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(244, 128);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 3;
            this.cmdCrear.Text = "Cargar";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(75, 19);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(88, 21);
            this.lstLocalidad.TabIndex = 4;
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(80, 88);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(44, 20);
            this.txtToneladas.TabIndex = 6;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(13, 127);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 8;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // lstCultivos
            // 
            this.lstCultivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivos.FormattingEnabled = true;
            this.lstCultivos.Location = new System.Drawing.Point(75, 56);
            this.lstCultivos.Name = "lstCultivos";
            this.lstCultivos.Size = new System.Drawing.Size(72, 21);
            this.lstCultivos.TabIndex = 9;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 163);
            this.Controls.Add(this.lstCultivos);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmProduccion";
            this.Text = "Cargar Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.ComboBox lstCultivos;
    }
}