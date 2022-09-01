using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.SP1.LopezValentin
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalidades frmLocalidades = new frmLocalidades();
            frmLocalidades.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCultivos frmCultivos = new frmCultivos();
            frmCultivos.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmProduccion frmProduccion = new frmProduccion();
            frmProduccion.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public struct agricultura
        {
            public string localidad;
            public string cultivo;
            public int codigoLocalidad;
            public int codigoCultivo;
        }
        float[,] vecToneladas = new float[10, 10];

    }
}
