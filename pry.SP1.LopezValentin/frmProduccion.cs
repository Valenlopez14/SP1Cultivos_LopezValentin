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
            produccion.WriteLine(lstLocalidad.Text + "," +  lstCultivos.Text + "," + txtToneladas.Text);
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
            //Leer el archivo de txt 
            StreamReader lectorLocalidad = new StreamReader("./Localidad.txt");
            //Mientras no esté en fin de archivo:
            while (!lectorLocalidad.EndOfStream)
            {
                //Lee la linea de caracteres en el txt y agrega los datos a la lista desplegable
                string saltoNro = lectorLocalidad.ReadLine();

                lstLocalidad.Items.Add(saltoNro.Substring(4));
            }
            lectorLocalidad.Close();

            StreamReader lectorCultivos = new StreamReader("./Cultivos.txt");
            while (!lectorCultivos.EndOfStream)
            {
                string saltoNro2 = lectorCultivos.ReadLine();
                //Lee la linea de caracteres en el txt y agrega los datos a la lista desplegable 
                //Substring corta los caracteres que están antes de lo que quiero agregar a la lista
                lstCultivos.Items.Add(saltoNro2.Substring(4));
            }
            lectorCultivos.Close();
        }
    }
}
