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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            StreamWriter produccion = new StreamWriter("./Produccion.txt", true);
            produccion.WriteLine(lstCultivos.Text + "" + lstLocalidad.Text + txtToneladas.Text);
            MessageBox.Show("Archivo escrito con exito.");
            produccion.Close();
            lstCultivos.Text = "";
            lstLocalidad.Text = "";
            txtToneladas.Text = "";
        }

        private void cmdCrearProd_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Produccion.txt");
            MessageBox.Show("Archivo borrado con éxito.");
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader lectorLocalidad = new StreamReader("./Localidad.txt");
            while (!lectorLocalidad.EndOfStream)
            {
                string saltoNro = lectorLocalidad.ReadLine();

                lstLocalidad.Items.Add(saltoNro.Substring(4));
            }
            lectorLocalidad.Close();

            StreamReader lectorCultivos = new StreamReader("./Cultivos.txt");
            while (!lectorCultivos.EndOfStream)
            {
                string saltoNro2 = lectorCultivos.ReadLine();

                lstCultivos.Items.Add(saltoNro2.Substring(4));
            }
            lectorCultivos.Close();
        }
    }
}
