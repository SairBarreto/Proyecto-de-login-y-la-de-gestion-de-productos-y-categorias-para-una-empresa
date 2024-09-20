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
    public partial class FormJuegoBando : Form
    {
        private static FormJuegoBando instanciaFormJuegoBando = null;
        public static FormJuegoBando ventanaUnica()
        {
            if (instanciaFormJuegoBando == null || instanciaFormJuegoBando.IsDisposed)
            {
                instanciaFormJuegoBando = new FormJuegoBando();
                return instanciaFormJuegoBando;
            }

            return instanciaFormJuegoBando;
        }
        JuegoBandoLogin juegoBando;
        List<JuegoBandoLogin> listaJuegoBando;
        public FormJuegoBando()
        {
            InitializeComponent();
            juegoBando = new JuegoBandoLogin();
            listaJuegoBando = new List<JuegoBandoLogin>();
        }

        private void cargarListaJuegoBando()
        {
            listaJuegoBando.Clear();
            juegoBando.cargarListaJugoBando(listaJuegoBando);
        }

        private void mostrarEnDGV(DataGridView DGV, object lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void FormJuegoBando_Load(object sender, EventArgs e)
        {
            cargarListaJuegoBando();
            mostrarEnDGV(dgvJuegosBandos, listaJuegoBando.ToList());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var id_juego = Interaction.InputBox("Id Juego");
                if (!Information.IsNumeric(id_juego)) throw new Exception("El Id del Juego debe ser numerico");
                if (!juegoBando.verificaQueIdJuegoExista(Convert.ToInt32(id_juego))) throw new Exception($"El id {id_juego} del Juego no existe");

                var id_jugador = Interaction.InputBox("Id Jugador");
                if (!Information.IsNumeric(id_jugador)) throw new Exception("El Id del Jugador debe ser numerico");
                if(!juegoBando.verificaQueIdJugadorExista(Convert.ToInt32(id_jugador))) throw new Exception($"El id {id_jugador} del Jugador no existe");

                juegoBando.agregarJuegoBando(Convert.ToInt32(id_juego), Convert.ToInt32(id_jugador));
                cargarListaJuegoBando();
                mostrarEnDGV(dgvJuegosBandos, listaJuegoBando.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJuegosBandos.Rows.Count == 0) throw new Exception("No hay nada para borrar");
                var id_juego = dgvJuegosBandos.SelectedRows[0].Cells[0].Value;
                var id_jugador = dgvJuegosBandos.SelectedRows[0].Cells[1].Value;

                juegoBando.borrarJurgoBando(Convert.ToInt32(id_juego), Convert.ToInt32(id_jugador));
                cargarListaJuegoBando();
                mostrarEnDGV(dgvJuegosBandos, listaJuegoBando.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJuegosBandos.Rows.Count == 0) throw new Exception("No hay nada para modificar");
                
                var id_juego = Interaction.InputBox("Id Juego", "Modificando Id Juego", dgvJuegosBandos.SelectedRows[0].Cells[0].Value.ToString());
                if (!Information.IsNumeric(id_juego)) throw new Exception("El Id del Juego debe ser numerico");
                if (!juegoBando.verificaQueIdJuegoExista(Convert.ToInt32(id_juego))) throw new Exception($"El id {id_juego} del Juego no existe");

                var id_jugador = Interaction.InputBox("Id Jugador", "Modificando Id Jugador", dgvJuegosBandos.SelectedRows[0].Cells[1].Value.ToString());
                if (!Information.IsNumeric(id_jugador)) throw new Exception("El Id del Jugador debe ser numerico");
                if (!juegoBando.verificaQueIdJugadorExista(Convert.ToInt32(id_jugador))) throw new Exception($"El id {id_jugador} del Jugador no existe");

                juegoBando.agregarJuegoBando(Convert.ToInt32(id_juego), Convert.ToInt32(id_jugador));
                cargarListaJuegoBando();
                mostrarEnDGV(dgvJuegosBandos, listaJuegoBando.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
