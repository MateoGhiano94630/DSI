namespace PPAI_CU_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            cmbTipoReseña.Items.Add("Normales");
            cmbTipoReseña.Items.Add("de Sommelier");
            cmbTipoReseña.Items.Add("de Amigos");
            cmbTipoReseña.Items.Add("");

        }

        private void btnGenerarRanking_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            DateTime fechaDesde = cmbFechaDesde.Value;
            DateTime fechaHasta = cmbFechaHasta.Value;


            resultado = ValidarFecha(fechaDesde, fechaHasta);
            if (resultado)
            {
                DialogResult confirmacion = MessageBox.Show("Esta seguro que desea generar el ranking?", "Generacion ranking", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.OK)
                {
                    MessageBox.Show("gol");
                }
            }
            else
            {
                MessageBox.Show("Las fechas no son validas");
            }

           
        }

        private bool ValidarFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            int resultado = fechaHasta.CompareTo(fechaDesde);
            if (resultado == -1)
            {
                bool res = false;
                return res;
            }
            else if (resultado == 1)
            {
                bool res = true;
                return res;
            }
            else
            {
                bool res = false;
                return res;
            }
        }

        private void limpiarCampos()
        {
            cmbFechaDesde.Text = "";
            cmbFechaHasta.Text = "";
            rdPDF.Checked = false;
            rdExcel.Checked = false;
            rdPantalla.Checked = false;

        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
