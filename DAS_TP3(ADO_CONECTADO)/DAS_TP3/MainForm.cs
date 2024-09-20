using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAS_TP3
{
    public partial class MainForm : Form
    {
        public SqlConnection conexion;
        public event Action<bool> ConexionCambiada;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(@"Data Source=; Initial Catalog=DAS_TP3; Integrated Security=True");
            conexion.StateChange += EstadoConexion;
        }
        private void EstadoConexion(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Open)
            {
                btnConectarBD.BackColor = Color.Lime;
                btnDesconectarBD.BackColor = Color.White;
            }
            else { btnDesconectarBD.BackColor = Color.Red; btnConectarBD.BackColor = Color.White; }
        }
        private bool conexionAbierta() => conexion.State == ConnectionState.Open;

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SociosForm sociosForm = SociosForm.ventanaUnica();
            sociosForm.MdiParent = this;
            sociosForm.Show();
            sociosForm.BringToFront(); //Pone el foco en la ventana
            sociosForm.btnHabilitacion(conexionAbierta());
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaisForm paisForm = PaisForm.ventanaUnica();
            paisForm.MdiParent = this;
            paisForm.Show();
            paisForm.BringToFront();
            paisForm.btnHabilitacion(conexionAbierta());
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinciaForm provinciasForm = ProvinciaForm.ventanaUnica();
            provinciasForm.MdiParent = this;
            provinciasForm.Show();
            provinciasForm.BringToFront();
            provinciasForm.btnHabilitacion(conexionAbierta());
        }

        private void btnConectarBD_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
                ConexionCambiada?.Invoke(conexionAbierta());
            }
        }

        private void btnDesconectarBD_Click(object sender, EventArgs e)
        {
            conexion.Close();
            ConexionCambiada?.Invoke(conexionAbierta());
        }
    }
}
