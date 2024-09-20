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
    public partial class FormJuego : Form
    {
        private static FormJuego instanciaFormJuego = null;
        public static FormJuego ventanaUnica()
        {
            if (instanciaFormJuego == null || instanciaFormJuego.IsDisposed)
            {
                instanciaFormJuego = new FormJuego();
                return instanciaFormJuego;
            }

            return instanciaFormJuego;
        }
        JuegoLogin juego;
        List<JuegoLogin> listaJuegos;
        public FormJuego()
        {
            InitializeComponent();
            juego = new JuegoLogin();
            listaJuegos = new List<JuegoLogin>();
        }

        private void cargarListaJuegos()
        {
            listaJuegos.Clear();
            juego.cargarListaJuegos(listaJuegos);
        }

        private void mostrarEnDGV(DataGridView DGV, object lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            cargarListaJuegos();
            mostrarEnDGV(dgvJuegos, listaJuegos.ToList());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = Interaction.InputBox("Nombre del juego");
                if (nombre == "") throw new Exception("Debe ingresar un nombre para el juego");

                var descripcion = Interaction.InputBox("Descripcion del juego");
                if (descripcion == "") throw new Exception("Debe agregar una descripcion al juego");

                juego.agregarJuego(nombre, descripcion);
                cargarListaJuegos();
                mostrarEnDGV(dgvJuegos, listaJuegos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJuegos.Rows.Count == 0) throw new Exception("No hay nada para borrar");
                var id_juego = dgvJuegos.SelectedRows[0].Cells[0].Value;

                juego.borrarJuego(Convert.ToInt32(id_juego));
                cargarListaJuegos();
                mostrarEnDGV(dgvJuegos, listaJuegos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJuegos.Rows.Count == 0) throw new Exception("No hay nada para modificar");
                var id_juego = dgvJuegos.SelectedRows[0].Cells[0].Value;

                var nombre = Interaction.InputBox("Nombre del juego", "Actualizando Nombre", dgvJuegos.SelectedRows[0].Cells[1].Value.ToString());
                if (nombre == "") throw new Exception("Debe ingresar un nombre para el juego");

                var descripcion = Interaction.InputBox("Descripcion del juego", "Actualizando Descripcion", dgvJuegos.SelectedRows[0].Cells[2].Value.ToString());
                if (descripcion == "") throw new Exception("Debe agregar una descripcion al juego");

                juego.actualizarJuego(new JuegoLogin(Convert.ToInt32(id_juego), nombre, descripcion));
                cargarListaJuegos();
                mostrarEnDGV(dgvJuegos, listaJuegos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
