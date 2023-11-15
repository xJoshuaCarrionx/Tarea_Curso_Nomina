namespace Tarea_Curso_Nomina
{
    partial class Sesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sesion));
            pnlContenedor = new Panel();
            btnsesion = new Button();
            checkBox1 = new CheckBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(224, 224, 224);
            pnlContenedor.Controls.Add(btnsesion);
            pnlContenedor.Controls.Add(checkBox1);
            pnlContenedor.Controls.Add(txtContraseña);
            pnlContenedor.Controls.Add(txtUsuario);
            pnlContenedor.Controls.Add(pictureBox1);
            pnlContenedor.Controls.Add(label3);
            pnlContenedor.Controls.Add(label2);
            pnlContenedor.Controls.Add(label1);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = SystemColors.ActiveCaptionText;
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(392, 353);
            pnlContenedor.TabIndex = 1;
            // 
            // btnsesion
            // 
            btnsesion.Location = new Point(128, 262);
            btnsesion.Name = "btnsesion";
            btnsesion.Size = new Size(95, 23);
            btnsesion.TabIndex = 7;
            btnsesion.Text = "Iniciar sesion";
            btnsesion.UseVisualStyleBackColor = true;
            btnsesion.Click += btnsesion_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(128, 219);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Mostrar Contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(128, 179);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(149, 23);
            txtContraseña.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(128, 136);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(149, 23);
            txtUsuario.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 182);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 139);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 26);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesion";
            // 
            // Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 353);
            ControlBox = false;
            Controls.Add(pnlContenedor);
            Name = "Sesion";
            StartPosition = FormStartPosition.CenterScreen;
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContenedor;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private CheckBox checkBox1;
        private Button btnsesion;
    }
}