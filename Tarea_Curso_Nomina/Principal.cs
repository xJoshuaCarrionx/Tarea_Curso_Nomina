namespace Tarea_Curso_Nomina
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            empleado.MdiParent = this;
            empleado.Show();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados obj = new Empleados();
            obj.Close();
        }

        private void revisarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Nomina nomina = new Nomina();

            nomina.MdiParent = this;
            nomina.Show();
        }
    }
}