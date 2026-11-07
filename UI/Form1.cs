using BLL;
using ENTITIES;

namespace UI
{
    public partial class Form1 : Form
    {
        private AplicacionBss aplicacionBss = new AplicacionBss();
        private CategoriaBss categoriaBss = new CategoriaBss();
        private List<AplicacionEntity> listado = new List<AplicacionEntity>();
        public Form1()
        {
            InitializeComponent();
            recargar();
        }

        public void recargar()
        {
            try
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = this.aplicacionBss.getAll();

                this.comboBox1.DataSource = null;
                this.comboBox1.DataSource = this.categoriaBss.getAll();

                this.comboBox1.DisplayMember = "Descripcion";
                this.comboBox1.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar los datos.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionEntity entity = new AplicacionEntity();

                entity.Desarrolladora = txtAltaDesarrolladora.Text;
                entity.Descripcion = txtAltaDescripcion.Text;
                entity.Precio = Convert.ToDecimal(txtAltaPrecio.Text.Length == 0 ? "0" : txtAltaPrecio.Text);
                entity.Titulo = txtAltaTitulo.Text;
                entity.IdCategoria = (int)this.comboBox1.SelectedValue!;

                listado.Add(entity);
                MessageBox.Show("Agregado.");
                lblCantidad.Text = listado.Count.ToString();
                this.clear();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Ocurrio un error al agregar.");
            }
        }

        public void clear()
        {
            txtAltaDesarrolladora.Text = "";
            txtAltaDescripcion.Text = "";
            txtAltaPrecio.Text = "";
            txtAltaTitulo.Text = "";

            txtModificacionId.Text = "";
            txtModificacionDesarrolladora.Text = "";
            txtModificacionDescripcion.Text = "";
            txtModificacionPrecio.Text = "";
            txtModificacionTitulo.Text = "";
        }

        private void btnAltaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listado.Count == 0) throw new Exception("No hay datos cargados.");

                this.aplicacionBss.save(listado);
                MessageBox.Show("Datos guardados! .");
                this.recargar();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            finally
            {
                this.listado.Clear();
                lblCantidad.Text = listado.Count.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionEntity entity = new AplicacionEntity();

                entity.Desarrolladora = txtModificacionDesarrolladora.Text;
                entity.Descripcion = txtModificacionDescripcion.Text;
                entity.Precio = Convert.ToDecimal(txtModificacionPrecio.Text.Length == 0 ? "0" : txtModificacionPrecio.Text);
                entity.Titulo = txtModificacionTitulo.Text;
                entity.IdCategoria = (int)this.comboBox1.SelectedValue!;
                entity.Id = Convert.ToInt32(txtModificacionId.Text);

                this.aplicacionBss.update(entity);
                MessageBox.Show("Modificado!");
                this.clear();
                this.recargar();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            { 
                this.aplicacionBss.delete(Convert.ToInt32(txtEliminar.Text));
                MessageBox.Show("Eliminado!");
                this.clear();
                this.recargar();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
    }
}

