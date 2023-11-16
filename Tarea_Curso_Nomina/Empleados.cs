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
            cboestadocivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbosexo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public DataGridViewRowCollection ObtenerDatos()
        {
            return dvgdatos.Rows;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnadd_Click(object sender, EventArgs e)
        {

        }
        private void btnimprimir_Click(object sender, EventArgs e)
        {

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
        private void btnadd_Click_1(object sender, EventArgs e)
        {

            if (txtcodigo.Text == "" || txtprimernombre.Text == "" || txtsegundonombre.Text == "" || txtprimerapellido.Text == "" || txtsegundoapellido.Text == "" || txtcedula.Text == "" || txtdireccion.Text == "" || txttelefono.Text == "" || txtcelular.Text == "" || txtinss.Text == "" || txtruc.Text == "" || txtsalporhora.Text == "" || txthorastrabajadas.Text == "" || txthorasextras.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                Empleado obj = new Empleado();
                Calcular_Nomina calcular_Nomina = new Calcular_Nomina();

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
                obj.Salarioporhora = Convert.ToInt32(txtsalporhora.Text);
                obj.Horastrabajadas = Convert.ToInt32(txthorastrabajadas.Text);
                obj.HorasExtras = Convert.ToInt32(txthorasextras.Text);

                dvgdatos.Rows.Add(obj.NumeroEmpleado.ToString(), obj.NumeroINSS, obj.NumeroRUC, obj.PrimerNombre, obj.SegundoNombre, obj.PrimerApellido, obj.SegundoApellido,
                                       obj.NumeroCedula, obj.FechaNacimiento, obj.Direccion, obj.EstadoCivil, obj.Sexo, obj.Telefono, obj.Celular, obj.FechaContratacion,
                                                          obj.FechaCierreContrato, obj.Salarioporhora, obj.Horastrabajadas);
            }
            Limpiar();
        }
        private void Limpiar()
        {
            txtcodigo.Text = "";
            txtprimernombre.Text = "";
            txtsegundonombre.Text = "";
            txtprimerapellido.Text = "";
            txtsegundoapellido.Text = "";
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtcelular.Text = "";
            txtinss.Text = "";
            txtruc.Text = "";
            txtsalporhora.Text = "";
            txthorastrabajadas.Text = "";
            txthorasextras.Text = "";
        }

        private void btnimprimir_Click_1(object sender, EventArgs e)
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtcodigo.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtcodigo.Text = txtcodigo.Text.Remove(txtcodigo.Text.Length - 1);
            }
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtcedula.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtcedula.Text = txtcedula.Text.Remove(txtcedula.Text.Length - 1);
            }
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txttelefono.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txttelefono.Text = txttelefono.Text.Remove(txttelefono.Text.Length - 1);
            }
        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtcelular.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtcelular.Text = txtcelular.Text.Remove(txtcelular.Text.Length - 1);
            }
        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtruc.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtruc.Text = txtruc.Text.Remove(txtruc.Text.Length - 1);
            }
        }

        private void txtinss_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtinss.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtinss.Text = txtinss.Text.Remove(txtinss.Text.Length - 1);
            }
        }

        private void txtsalporhora_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtsalporhora.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtsalporhora.Text = txtsalporhora.Text.Remove(txtsalporhora.Text.Length - 1);
            }
        }

        private void txthorastrabajadas_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txthorastrabajadas.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txthorastrabajadas.Text = txthorastrabajadas.Text.Remove(txthorastrabajadas.Text.Length - 1);
            }
        }

        private void txthorasextras_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txthorasextras.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txthorasextras.Text = txthorasextras.Text.Remove(txthorasextras.Text.Length - 1);
            }
        }

        private void txtprimernombre_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprimernombre.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Solo ingrese letras!!");
                txtprimernombre.Text = txtprimernombre.Text.Remove(txtprimernombre.Text.Length - 1);
            }
        }

        private void txtsegundonombre_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtsegundonombre.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Solo ingrese letras!!");
                txtsegundonombre.Text = txtsegundonombre.Text.Remove(txtsegundonombre.Text.Length - 1);
            }
        }

        private void txtprimerapellido_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprimerapellido.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Solo ingrese letras!!");
                txtprimerapellido.Text = txtprimerapellido.Text.Remove(txtprimerapellido.Text.Length - 1);
            }
        }

        private void txtsegundoapellido_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtsegundoapellido.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Solo ingrese letras!!");
                txtsegundoapellido.Text = txtsegundoapellido.Text.Remove(txtsegundoapellido.Text.Length - 1);
            }
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtdireccion.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Solo ingrese letras y numeros!!");
                txtdireccion.Text = txtdireccion.Text.Remove(txtdireccion.Text.Length - 1);
            }
        }

        private void cbosexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboestadocivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
