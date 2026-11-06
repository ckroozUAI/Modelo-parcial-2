using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private AplicacionBss aplicacionBss = new AplicacionBss();
        private CategoriaBss categoriaBss = new CategoriaBss(); 
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
                this.comboBox1.DataSource= this.categoriaBss.getAll(); 

                this.comboBox1.DisplayMember = "Descripcion";
                this.comboBox1.ValueMember   = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar los datos.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
