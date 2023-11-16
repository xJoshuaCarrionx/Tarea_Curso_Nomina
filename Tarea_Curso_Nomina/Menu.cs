using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Clases_Nomina;


namespace Tarea_Curso_Nomina
{
    public partial class Menu : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwind, int wMsg, int WPara, int lParam);
        public Menu()
        {
            InitializeComponent();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir?",
               "Inicio de sesion", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }
        private void tmExpandir_Tick(object sender, EventArgs e)
        {
            if (PnlMenu.Width >= 200)
                tmExpandir.Stop();
            else
                PnlMenu.Width += 5;
        }
        private void TmContraer_Tick(object sender, EventArgs e)
        {
            if (PnlMenu.Width <= 35
                )
                TmContraer.Stop();
            else
                PnlMenu.Width -= 5;
        }
        public void AbrirEmpleados(object Empleados1)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Empleados frm = Empleados1 as Empleados;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(frm);
            this.PnlContenedor.Tag = frm;
            frm.Show();
        }
        private void PnlBarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            AbrirEmpleados(new Empleados());
        }
        private void AbrirNomina(object Nomina1)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Nomina frmNo = Nomina1 as Nomina;
            frmNo.TopLevel = false;
            frmNo.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(frmNo);
            this.PnlContenedor.Tag = frmNo;
            frmNo.Show();
        }
        private void BtnNomina_Click(object sender, EventArgs e)
        {
            AbrirNomina(new Nomina());
        }
        private void AbrirSesion(object Sesion1)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Sesion frmSe = Sesion1 as Sesion;
            frmSe.TopLevel = false;
            frmSe.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(frmSe);
            this.PnlContenedor.Tag = frmSe;
            frmSe.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirSesion(new Sesion());
        }
        private void PnlBarraDeTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
