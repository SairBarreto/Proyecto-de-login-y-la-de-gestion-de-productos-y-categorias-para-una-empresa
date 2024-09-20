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
    public partial class ProvinciaForm : Form
    {
        private static ProvinciaForm instanciaProvinciaForm = null;
        public static ProvinciaForm ventanaUnica()
        {
            if (instanciaProvinciaForm == null || instanciaProvinciaForm.IsDisposed)
            {
                instanciaProvinciaForm = new ProvinciaForm();
                return instanciaProvinciaForm;
            }

            return instanciaProvinciaForm;
        }
        public void btnHabilitacion(bool estado)
        {
            btnAgregarEnBD.Enabled = estado;
            btnBorrarEnBD.Enabled = estado;
            btnModificarEnBD.Enabled = estado;
        }

        List<Provincia> listaProvincias;
        SqlConnection conexion;
        SqlCommand cmd;
        public ProvinciaForm()
        {
            InitializeComponent();
        }

        private void ProvinciaForm_Load(object sender, EventArgs e)
        {
            listaProvincias = new List<Provincia>();
            conexion = ((MainForm)this.MdiParent).conexion;
            cmd = new SqlCommand("Select * from Provincia", conexion);

            var mainForm = (MainForm)this.MdiParent;
            if (mainForm != null)
            {
                mainForm.ConexionCambiada += btnHabilitacion;
            }
        }

        private void ProvinciaForm_FormClosed(object sender, FormClosedEventArgs e)
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
                string id_Provincia = Interaction.InputBox("Id de Provincia");
                if (!Information.IsNumeric(id_Provincia)) throw new Exception($"El id {id_Provincia} de la provincia debe ser numerico");
                if (provinciaExiste(id_Provincia)) throw new Exception($"El Id {id_Provincia} ya existe");
                string nombre = Interaction.InputBox("Nombre de Provincia");

                cmd.CommandText = $"Insert into Provincia (Id_Provincia, Nombre) values ({id_Provincia}, '{nombre}')";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void cargarProvincias()
        {
            cmd.CommandText = "Select * from Provincia";
            listaProvincias.Clear();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Object[] datosProvincias = new object[dr.FieldCount];
                dr.GetValues(datosProvincias);
                listaProvincias.Add(new Provincia(datosProvincias));
            }
            dr.Close();
        }

        private void mostrarEnDGV()
        {
            cargarProvincias();
            dgvInfoProvincias.DataSource = null;
            dgvInfoProvincias.DataSource = listaProvincias.ToList();
        }

        private bool provinciaExiste(string id_provincia)
        {
            bool existe = false;
            foreach (var provincia in listaProvincias)
            {
                if (provincia.Id_Provincia == Convert.ToInt32(id_provincia)) { existe = true; break; }
            }
            return existe;
        }

        private void btnBorrarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInfoProvincias.Rows.Count == 0) throw new Exception("No hay provincias para borrar");
                string id_Provincia = dgvInfoProvincias.SelectedRows[0].Cells[0].Value.ToString();

                cmd.CommandText = $"Delete from Provincia where Id_Provincia={id_Provincia}";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInfoProvincias.Rows.Count == 0) throw new Exception("No hay provincias para modificar");
                string id_Provincia = dgvInfoProvincias.SelectedRows[0].Cells[0].Value.ToString();

                string nombre = Interaction.InputBox("Nombre de Provincia", "Modificando Nombre", dgvInfoProvincias.SelectedRows[0].Cells[1].Value.ToString());

                cmd.CommandText = $"Update Provincia set Nombre='{nombre}' where Id_Provincia={id_Provincia}";
                cmd.ExecuteNonQuery();
                mostrarEnDGV();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
