using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElguetaConexionBD
{
    internal class clsConexionBD
    {
        // Definicion de comando, conexion y adaptador.

        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsConexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./BBDDContactos.accdb;";
        }
        
        public void obtenerDatos(DataGridView dgvContactos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Contactos";

                DataTable tablaContactos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaContactos);

                dgvContactos.DataSource = tablaContactos;
                MessageBox.Show("✅ Conexión exitosa a la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }
        }
    }
}
