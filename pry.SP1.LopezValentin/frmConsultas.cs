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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader srProduccion = new StreamReader("./Produccion.txt");

            while (!srProduccion.EndOfStream)
            {
                string Cultivo = srProduccion.ReadLine();
                string[] Consulta = Cultivo.Split(','); 

                GrlConsultas.Rows.Add(Consulta[0], Consulta[1], Consulta[2]);
            }
            srProduccion.Close();
        }
    }
}
