using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionJuego
{
    public partial class FormBando : Form
    {
        private static FormBando instanciaFormBando = null;
        public static FormBando ventanaUnica()
        {
            if (instanciaFormBando == null || instanciaFormBando.IsDisposed)
            {
                instanciaFormBando = new FormBando();
                return instanciaFormBando;
            }

            return instanciaFormBando;
        }
        BandoLogin bando;
        List<BandoLogin> listaBandos;
        public FormBando()
        {
            InitializeComponent();
            bando = new BandoLogin();
            listaBandos = new List<BandoLogin>();
        }

        private void cargarListaBandos()
        {
            listaBandos.Clear();
            bando.cargarListaBandos(listaBandos);
        }

        private void mostrarEnDGV(DataGridView DGV, object lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void FormBando_Load(object sender, EventArgs e)
        {
            cargarListaBandos();
            mostrarEnDGV(dgvBandos, listaBandos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = Interaction.InputBox("Nombre de Bando");
                if (nombre == "") throw new Exception("Debe ingresar un nombre del Bando");

                bando.agregarBando(nombre);
                cargarListaBandos();
                mostrarEnDGV(dgvBandos, listaBandos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBandos.Rows.Count == 0) throw new Exception("No hay bandos para borrar");
                var id_bando = dgvBandos.SelectedRows[0].Cells[0].Value;

                bando.borrarBando(Convert.ToInt32(id_bando));
                cargarListaBandos();
                mostrarEnDGV(dgvBandos, listaBandos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBandos.Rows.Count == 0) throw new Exception("No hay bandos para borrar");
                var id_bando = dgvBandos.SelectedRows[0].Cells[0].Value;

                var nombre = Interaction.InputBox("Nombre de Bando", "Actualizando Nombre", dgvBandos.SelectedRows[0].Cells[1].Value.ToString());
                if (nombre == "") throw new Exception("Debe ingresar un nombre del Bando");

                bando.actualizarBando(new BandoLogin(Convert.ToInt32(id_bando), nombre));
                cargarListaBandos();
                mostrarEnDGV(dgvBandos, listaBandos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
