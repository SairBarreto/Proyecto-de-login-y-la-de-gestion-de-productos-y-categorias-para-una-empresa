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
    public partial class FormJugadores : Form
    {
        private static FormJugadores instanciaFormJugadores = null;
        public static FormJugadores ventanaUnica()
        {
            if (instanciaFormJugadores == null || instanciaFormJugadores.IsDisposed)
            {
                instanciaFormJugadores = new FormJugadores();
                return instanciaFormJugadores;
            }

            return instanciaFormJugadores;
        }
        JugadoresLogin jugador;
        List<JugadoresLogin> listaJugadores;

        public FormJugadores()
        {
            InitializeComponent();
            jugador = new JugadoresLogin();
            listaJugadores = new List<JugadoresLogin>();
        }

        private void cargarListaJugadores()
        {
            listaJugadores.Clear();
            jugador.cargarListaJugadores(listaJugadores);
        }

        private void mostrarDGV(DataGridView DGV, object lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void FormJugadores_Load(object sender, EventArgs e)
        {
            cargarListaJugadores();
            mostrarDGV(dgvJuegadores, listaJugadores.ToList());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = Interaction.InputBox("Nombre Jugador");
                if (nombre == "") throw new Exception("Debe ingresar un nombre para el jugador");

                var apellido = Interaction.InputBox("Apellido Jugador");
                if (apellido == "") throw new Exception("Debe ingresar un apellido para el jugador");

                var id_bando = Interaction.InputBox("Id del bando Jugador");
                if (!Information.IsNumeric(id_bando)) throw new Exception("El id de badno debe ser numerico");

                jugador.agregarJugadore(nombre, apellido, Convert.ToInt32(id_bando));
                cargarListaJugadores();
                mostrarDGV(dgvJuegadores, listaJugadores.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJuegadores.Rows.Count == 0) throw new Exception("No hay jugadores para borrar");
                var id_jugador = dgvJuegadores.SelectedRows[0].Cells[0].Value;

                jugador.borrarJugadores(Convert.ToInt32(id_jugador));
                cargarListaJugadores();
                mostrarDGV(dgvJuegadores, listaJugadores.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJuegadores.Rows.Count == 0) throw new Exception("No hay jugadores para modificar");
                var id_jugador = dgvJuegadores.SelectedRows[0].Cells[0].Value;

                var nombre = Interaction.InputBox("Nombre Jugador", "Actualizando nombre", dgvJuegadores.SelectedRows[0].Cells[1].Value.ToString());
                if (nombre == "") throw new Exception("Debe ingresar un nombre para el jugador");

                var apellido = Interaction.InputBox("Apellido Jugador", "Actualizando apellido", dgvJuegadores.SelectedRows[0].Cells[2].Value.ToString());
                if (apellido == "") throw new Exception("Debe ingresar un apellido para el jugador");

                var id_bando = Interaction.InputBox("Id del bando Jugador", "Actualizando Id de bando", dgvJuegadores.SelectedRows[0].Cells[3].Value.ToString());
                if (!Information.IsNumeric(id_bando)) throw new Exception("El id de badno debe ser numerico");

                jugador.actualizarJugador(new JugadoresLogin(Convert.ToInt32(id_jugador), nombre, apellido, Convert.ToInt32(id_bando)));
                cargarListaJugadores();
                mostrarDGV(dgvJuegadores, listaJugadores.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
