using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Tarea_Curso_Nomina
{
    public partial class Sesion : Form
    {
        private string CorrectUserName1 = "Gabriel Rojas";
        private string CorrectPassword1 = "161004";
        private string CorrectUserName2 = "Joshua Carrion";
        private string CorrectPassword2 = "08082022";
        private int LoginAttempts = 0;
        Menu menu = new Menu();
        
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwind, int wMsg, int WPara, int lParam);
        public Sesion()
        {
            InitializeComponent();
            txtUsuario.Focus();
            
        }
        private void btnsesion_Click(object sender, EventArgs e)
        {
            string IngresarUsuaruio = txtUsuario.Text;
            string IngresarContraseña = txtContraseña.Text;
            if (string.IsNullOrWhiteSpace(IngresarUsuaruio) || string.IsNullOrWhiteSpace(IngresarContraseña))
            {
                MessageBox.Show("No pueden quedar los campos de texto en blanco,por favor ingrese datos.", "Error!!");
                return;
            }
            else if (IngresarUsuaruio == CorrectUserName1 && IngresarContraseña == CorrectPassword1)
            {
                MessageBox.Show("¡Inicio de sesion Exitosa!", "Bienvenido!!");
                MessageBox.Show("Bienvenido al programa de Nomina Empleado,usuario.", "Bienvenido!!");
                menu.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                this.Hide();
                
            }
            else if (IngresarUsuaruio == CorrectUserName2 && IngresarContraseña == CorrectPassword2)
            {
                MessageBox.Show("¡Inicio de sesion Exitosa!", "Bienvenido!!");
                MessageBox.Show("Bienvenido al programa de Nomina Empleado,usuario.", "Bienvenido!!");
                menu.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                this.Hide();
            
            }
            else
            {
                LoginAttempts++;
                if (LoginAttempts >= 3)
                {
                    MessageBox.Show("Limite de intentos,Cierre el programa.", "Error!!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.Intentos restantes : " +
                        "" + (3 - LoginAttempts));
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
            }
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
        private void PnlBarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
