using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDeDatos;

namespace PresentacionAdministradorDeProductos
{
    public partial class FormRegistros : Form
    {
        private static FormRegistros instanciaRegistroForm = null;
        public static FormRegistros ventanaUnica()
        {
            if (instanciaRegistroForm == null || instanciaRegistroForm.IsDisposed)
            {
                instanciaRegistroForm = new FormRegistros();
                return instanciaRegistroForm;
            }

            return instanciaRegistroForm;
        }
        List<Log> listaDeRegistros;
        public FormRegistros()
        {
            InitializeComponent();
            listaDeRegistros = new List<Log>();
        }
        private void cargarRegistros()
        {
            Log registros = new Log();
            listaDeRegistros.Clear();
            registros.cargarListaLog(listaDeRegistros);
        }
        public void mostrarEnDGV(DataGridView DGV, object lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            cargarRegistros();
            mostrarEnDGV(dgvRegistrosLog, listaDeRegistros.ToList());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarRegistros();
                mostrarEnDGV(dgvRegistrosLog, listaDeRegistros.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
