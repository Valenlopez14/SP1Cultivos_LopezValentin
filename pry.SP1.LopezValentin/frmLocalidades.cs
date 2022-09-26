using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry.SP1.LopezValentin
{
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            File.Delete("./Localidad.txt");
            MessageBox.Show("Archivo borrado con éxito.");

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            //Leer archivo txt o si no existe crearlo 
            StreamWriter localidad = new StreamWriter("./Localidad.txt", true);
            //Cargar archivo txt con la informacion cargada por el usuario en la interfaz 
            localidad.WriteLine(mskNroLoc.Text + "" + txtLocalidad.Text);
            MessageBox.Show("Localidad cargada con exito.");
            localidad.Close();
            //Limpiar interfaz para volver a utilizarla
            txtLocalidad.Text = "";
            mskNroLoc.Text = "";

        }
    }
}
