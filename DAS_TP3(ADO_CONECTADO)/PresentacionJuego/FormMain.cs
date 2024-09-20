namespace PresentacionJuego
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBando formBando = FormBando.ventanaUnica();
            formBando.MdiParent = this;
            formBando.Show();
            formBando.BringToFront(); //Pone el foco en la ventana
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJugadores formJugadores = FormJugadores.ventanaUnica();
            formJugadores.MdiParent = this;
            formJugadores.Show();
            formJugadores.BringToFront();
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJuego formJuego = FormJuego.ventanaUnica();
            formJuego.MdiParent = this;
            formJuego.Show();
            formJuego.BringToFront();
        }

        private void juegoBandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJuegoBando formJuegoBando = FormJuegoBando.ventanaUnica();
            formJuegoBando.MdiParent = this;
            formJuegoBando.Show();
            formJuegoBando.BringToFront();
        }
    }
}
