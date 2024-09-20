using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace DAS_TP3
{
    public partial class SociosForm : Form
    {
        private static SociosForm instanciaSociosForm = null;
        public static SociosForm ventanaUnica()
        {
            if (instanciaSociosForm == null || instanciaSociosForm.IsDisposed)
            {
                instanciaSociosForm = new SociosForm();
                return instanciaSociosForm;
            }

            return instanciaSociosForm;
        }
        public void btnHabilitacion(bool estado)
        {
            btnAgregarEnBD.Enabled = estado;
            btnBorrarEnBD.Enabled = estado;
            btnModificarEnBD.Enabled = estado;
        }

        List<Socio> listaSocios;
        SqlConnection conexion;
        SqlCommand cmd;
        public SociosForm()
        {
            InitializeComponent();
        }

        private void SociosForm_Load(object sender, EventArgs e)
        {
            listaSocios = new List<Socio>();
            conexion = ((MainForm)this.MdiParent).conexion;
            cmd = new SqlCommand("Select * from Socio", conexion);

            var mainForm = (MainForm)this.MdiParent;
            if (mainForm != null)
            {
                mainForm.ConexionCambiada += btnHabilitacion;
            }
        }

        private void SociosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = (MainForm)this.MdiParent;
            if (mainForm != null)
            {
                mainForm.ConexionCambiada -= btnHabilitacion; //Elimino el evento para que no haya error de referencia si abro otro vez el formulario
            }
        }

        private void btnAgregarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                string id_Socio = Interaction.InputBox("Id de Socio");
                if (!Information.IsNumeric(id_Socio)) throw new Exception($"El id {id_Socio} del socio debe ser numerico");
                if (socioExiste(id_Socio)) throw new Exception($"El Id {id_Socio} ya existe");

                string nombre = Interaction.InputBox("Nombre del Socio");
                string apellido = Interaction.InputBox("Apellido del Socio");
                string email = Interaction.InputBox("Email del Socio");

                string id_Pais = Interaction.InputBox("Id del Pais del Socio");
                if (!Information.IsNumeric(id_Pais)) throw new Exception($"El id {id_Pais} del pais debe ser numerico");
                string id_Provincia = Interaction.InputBox("Id de la Provincia del Socio");
                if (!Information.IsNumeric(id_Provincia)) throw new Exception($"El id {id_Provincia} de la provincia debe ser numerico");

                cmd.CommandText = $"Insert into Socio (Id_Socio, Nombre, Apellido, Email, Id_Pais, Id_Provincia, Activo) values ({id_Socio}, '{nombre}', '{apellido}', '{email}', {id_Pais}, {id_Provincia}, 1)";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void cargarSocios()
        {
            cmd.CommandText = "Select * from Socio";
            listaSocios.Clear();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Object[] datosSocios = new object[dr.FieldCount];
                dr.GetValues(datosSocios);
                Socio socio = new Socio(datosSocios);
                if (socio.socioActivo()) listaSocios.Add(socio);
            }
            dr.Close();
        }

        private void mostrarEnDGV()
        {
            cargarSocios();
            dgvInfoSocios.DataSource = null;
            dgvInfoSocios.DataSource = listaSocios.ToList();
        }

        private bool socioExiste(string id_socio)
        {
            bool existe = false;
            foreach (var socio in listaSocios)
            {
                if (socio.Id_Pais == Convert.ToInt32(id_socio)) { existe = true; break; }
            }
            return existe;
        }

        private void btnBorrarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInfoSocios.Rows.Count == 0) throw new Exception("No hay socios para borrar");
                string id_Socio = dgvInfoSocios.SelectedRows[0].Cells[0].Value.ToString();

                cmd.CommandText = $"Update Socio set Activo=0 where Id_Socio={id_Socio}";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInfoSocios.Rows.Count == 0) throw new Exception("No hay socios para borrar");
                string id_Socio = dgvInfoSocios.SelectedRows[0].Cells[0].Value.ToString();

                string nombre = Interaction.InputBox("Nombre del Socio", "Modificando Nombre", dgvInfoSocios.SelectedRows[0].Cells[1].Value.ToString());
                string apellido = Interaction.InputBox("Apellido del Socio", "Modificando Apellido", dgvInfoSocios.SelectedRows[0].Cells[2].Value.ToString());
                string email = Interaction.InputBox("Email del Socio", "Modificando Email", dgvInfoSocios.SelectedRows[0].Cells[3].Value.ToString());

                string id_Pais = Interaction.InputBox("Id del Pais del Socio", "Modificando id pais", dgvInfoSocios.SelectedRows[0].Cells[4].Value.ToString());
                if (!Information.IsNumeric(id_Pais)) throw new Exception($"El id {id_Pais} del pais debe ser numerico");
                string id_Provincia = Interaction.InputBox("Id de la Provincia del Socio", "Modificando id provincia", dgvInfoSocios.SelectedRows[0].Cells[5].Value.ToString());
                if (!Information.IsNumeric(id_Provincia)) throw new Exception($"El id {id_Provincia} de la provincia debe ser numerico");

                cmd.CommandText = $"Update Socio set Nombre='{nombre}', Apellido='{apellido}', Email='{email}', Id_Pais={id_Pais}, Id_Provincia={id_Provincia} where Id_Socio={id_Socio}";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
