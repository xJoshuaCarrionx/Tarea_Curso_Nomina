using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea_Curso_Nomina
{
    public partial class Loguin : Form
    {
        private string CorrectUserName1 = "Gabriel Rojas";
        private string CorrectPassword1 = "161004";
        private string CorrectUserName2 = "Joshua Carrion";
        private string CorrectPassword2 = "08082022";
        private int LoginAttempts = 0;
        public Loguin()
        {
            InitializeComponent();
            txtusuario.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IngresarUsuaruio = txtusuario.Text;
            string IngresarContraseña = txtcontra.Text;
            if (string.IsNullOrWhiteSpace(IngresarUsuaruio) || string.IsNullOrWhiteSpace(IngresarContraseña))
            {
                MessageBox.Show("No pueden quedar los campos de texto en blanco,por favor ingrese datos.");
                return;

            }

            if (IngresarUsuaruio == CorrectUserName1  && IngresarContraseña == CorrectPassword1)
            {
                MessageBox.Show("!Inicio de sesiòn Exitoso");
                MessageBox.Show("Bienvenido al programa de Nomina Empleado,usuario.");

                Menu obj = new Menu();
                StartLoginProcess();
                this.Hide();
                obj.Show();
                this.Hide();




            }else if (IngresarUsuaruio == CorrectUserName2 && IngresarContraseña == CorrectPassword2)
            {
                MessageBox.Show("!Inicio de sesiòn Exitoso");
                MessageBox.Show("Bienvenido al programa de Nomina Empleado,usuario.");

                Menu obj = new Menu();
                StartLoginProcess();
                this.Hide();
                obj.Show();
                this.Hide();

            }
            else
            {
                LoginAttempts++;
                if (LoginAttempts >= 3)
                {
                    MessageBox.Show("Limite de intentos,Cierre el programa.");
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.Intentos restantes : " +
                        "" + (3 - LoginAttempts));
                }

            }
        }

        private void StartLoginProcess()
        {
            int totalSteps = 100;
            int currentStep = 0;

            while (currentStep <= totalSteps)
            {
                progressBar1.Value = currentStep;
                Application.DoEvents();
                System.Threading.Thread.Sleep(30);

                currentStep++;
            }

            progressBar1.Value = 0;
            progressBar1.Visible = false;
            button1.Enabled = true;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtcontra.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }


    }
}
