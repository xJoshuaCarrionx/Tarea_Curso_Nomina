using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Nomina;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.Logging;
using objExcel = Microsoft.Office.Interop.Excel;
namespace Tarea_Curso_Nomina
{
    public partial class Empleados : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Empleados()
        {
            InitializeComponent();

        }
        public DataGridViewRowCollection ObtenerDatos()
        {
            return dvgdatos.Rows;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Empleado obj = new Empleado();

            obj.NumeroEmpleado = Convert.ToInt32(txtcodigo.Text);
            obj.PrimerNombre = txtprimernombre.Text;
            obj.SegundoNombre = txtsegundonombre.Text;
            obj.PrimerApellido = txtprimerapellido.Text;
            obj.SegundoApellido = txtsegundoapellido.Text;
            obj.NumeroCedula = txtcedula.Text;
            obj.FechaNacimiento = datenacimiento.Value;
            obj.Direccion = txtdireccion.Text;
            obj.EstadoCivil = cboestadocivil.Text;
            obj.Sexo = cbosexo.Text;
            obj.Telefono = txttelefono.Text;
            obj.Celular = txtcelular.Text;
            obj.FechaContratacion = datecontrato.Value;
            obj.FechaCierreContrato = datecierrecintrato.Value;
            obj.NumeroINSS = txtinss.Text;
            obj.NumeroRUC = txtruc.Text;


            dvgdatos.Rows.Add(obj.NumeroEmpleado, obj.NumeroINSS, obj.NumeroRUC, obj.PrimerNombre, obj.SegundoNombre, obj.PrimerApellido, obj.SegundoApellido,
                obj.NumeroCedula, obj.FechaNacimiento, obj.Direccion, obj.EstadoCivil, obj.Sexo, obj.Telefono, obj.Celular, obj.FechaContratacion,
                obj.FechaCierreContrato);

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

            objExcel.Application objAplicacion = new objExcel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

            objAplicacion.Visible = false;



            foreach (DataGridViewColumn columna in dvgdatos.Columns)
            {
                objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dvgdatos.Rows)
                {
                    objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }

            objLibro.SaveAs(ruta + "\\Lista de empleados.xlsx");
            objLibro.Close();
            MessageBox.Show("El archivo se creó correctamente, revise su escritorio");

        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            dvgdatos.ReadOnly = false;
            dvgdatos.AllowUserToAddRows = false;
            dvgdatos.EditMode = DataGridViewEditMode.EditOnEnter;

            dvgdatos.CellClick += dvgdatos_CellClick;
        }

        private void dvgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgdatos.BeginEdit(true);
        }

    }
}
