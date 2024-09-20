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
using Microsoft.VisualBasic;

namespace DAS_TP3
{
    public partial class PaisForm : Form
    {
        private static PaisForm instanciaPaisForm = null;
        public static PaisForm ventanaUnica()
        {
            if (instanciaPaisForm == null || instanciaPaisForm.IsDisposed)
            {
                instanciaPaisForm = new PaisForm();
                return instanciaPaisForm;
            }

            return instanciaPaisForm;
        }

        public void btnHabilitacion(bool estado)
        {
            btnAgregarEnBD.Enabled = estado;
            btnBorrarEnBD.Enabled = estado;
            btnModificarEnBD.Enabled = estado;
        }

        List<Pais> listaPaises;
        SqlConnection conexion;
        SqlCommand cmd;
        public PaisForm()
        {
            InitializeComponent();
        }
        private void PaisForm_Load(object sender, EventArgs e)
        {
            listaPaises = new List<Pais>();
            conexion = ((MainForm)this.MdiParent).conexion;
            cmd = new SqlCommand("Select * from Pais", conexion);

            var mainForm = (MainForm)this.MdiParent;
            if (mainForm != null)
            {
                mainForm.ConexionCambiada += btnHabilitacion;
            }
        }
        private void PaisForm_FormClosed(object sender, FormClosedEventArgs e)
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
                string id_Pais = Interaction.InputBox("Id de País");
                if (!Information.IsNumeric(id_Pais)) throw new Exception($"El id {id_Pais} del pais debe ser numerico");
                if (paisExiste(id_Pais)) throw new Exception($"El Id {id_Pais} ya existe");
                string nombre = Interaction.InputBox("Nombre de País");

                cmd.CommandText = $"Insert into Pais (Id_Pais, Nombre) values ({id_Pais}, '{nombre}')";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cargarPaises()
        {
            cmd.CommandText = "Select * from Pais";
            listaPaises.Clear();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Object[] datosPaises = new object[dr.FieldCount];
                dr.GetValues(datosPaises);
                listaPaises.Add(new Pais(datosPaises));
            }
            dr.Close();
        }

        private void mostrarEnDGV()
        {
            cargarPaises();
            dgvInfoPaises.DataSource = null;
            dgvInfoPaises.DataSource = listaPaises.ToList();
        }

        private bool paisExiste(string id_pais)
        {
            bool existe = false;
            foreach (var pais in listaPaises)
            {
                if (pais.Id_Pais == Convert.ToInt32(id_pais)) { existe = true; break; }
            }
            return existe;
        }

        private void btnBorrarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInfoPaises.Rows.Count == 0) throw new Exception("No hay paises para borrar");
                string id_Pais = dgvInfoPaises.SelectedRows[0].Cells[0].Value.ToString();

                cmd.CommandText = $"Delete from Pais where Id_Pais={id_Pais}";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInfoPaises.Rows.Count == 0) throw new Exception("No hay paises para modificar");
                string id_Pais = dgvInfoPaises.SelectedRows[0].Cells[0].Value.ToString();

                string nombre = Interaction.InputBox("Nombre de País", "Modificando Nombre", dgvInfoPaises.SelectedRows[0].Cells[1].Value.ToString());

                cmd.CommandText = $"Update Pais set Nombre='{nombre}' where Id_Pais={id_Pais}";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
