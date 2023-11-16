using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Curso_Nomina
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void Nomina_Load(object sender, EventArgs e)
        {


        }
        public void AgregarFila(string codigo, string PrimerNombre, string PrimerApellido)
        {

            dvgdatos.Rows.Add(codigo, PrimerNombre, PrimerApellido);
        }
    }
}
