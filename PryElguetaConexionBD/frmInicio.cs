using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElguetaConexionBD
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        clsConexionBD conexion = new clsConexionBD();
        private void Form1_Load(object sender, EventArgs e)
        {
            //conexion.ConectarBD(); <--- Este metodo ya se incluye directamente en el mostrarDatos
            conexion.MostrarDatos(dgvContactos);
        }
    }
}
