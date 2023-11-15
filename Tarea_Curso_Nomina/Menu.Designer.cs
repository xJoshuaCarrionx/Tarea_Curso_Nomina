namespace Tarea_Curso_Nomina
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            PnlBarraDeTitulo = new Panel();
            BtnMaximizar = new Button();
            BtnRestaurar = new Button();
            BtnMinimizar = new Button();
            BtnSalir = new Button();
            PnMenuVertical = new Panel();
            PnlMenu = new Panel();
            btnUsuario = new Button();
            BtnNomina = new Button();
            pictureBox1 = new PictureBox();
            BtnEmpleados = new Button();
            PnlContenedor = new Panel();
            tmExpandir = new System.Windows.Forms.Timer(components);
            TmContraer = new System.Windows.Forms.Timer(components);
            PnlBarraDeTitulo.SuspendLayout();
            PnMenuVertical.SuspendLayout();
            PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlBarraDeTitulo
            // 
            PnlBarraDeTitulo.BackColor = Color.FromArgb(0, 80, 200);
            PnlBarraDeTitulo.Controls.Add(BtnMaximizar);
            PnlBarraDeTitulo.Controls.Add(BtnRestaurar);
            PnlBarraDeTitulo.Controls.Add(BtnMinimizar);
            PnlBarraDeTitulo.Controls.Add(BtnSalir);
            PnlBarraDeTitulo.Dock = DockStyle.Top;
            PnlBarraDeTitulo.Location = new Point(0, 0);
            PnlBarraDeTitulo.Name = "PnlBarraDeTitulo";
            PnlBarraDeTitulo.Size = new Size(800, 35);
            PnlBarraDeTitulo.TabIndex = 0;
            PnlBarraDeTitulo.MouseDown += PnlBarraDeTitulo_MouseDown;
            // 
            // BtnMaximizar
            // 
            BtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximizar.Cursor = Cursors.Hand;
            BtnMaximizar.FlatStyle = FlatStyle.Flat;
            BtnMaximizar.ForeColor = Color.FromArgb(0, 80, 200);
            BtnMaximizar.Image = (Image)resources.GetObject("BtnMaximizar.Image");
            BtnMaximizar.Location = new Point(721, 5);
            BtnMaximizar.Name = "BtnMaximizar";
            BtnMaximizar.Size = new Size(30, 25);
            BtnMaximizar.TabIndex = 1;
            BtnMaximizar.UseVisualStyleBackColor = true;
            BtnMaximizar.Click += BtnMaximizar_Click;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.FlatStyle = FlatStyle.Flat;
            BtnRestaurar.ForeColor = Color.FromArgb(0, 80, 200);
            BtnRestaurar.Image = (Image)resources.GetObject("BtnRestaurar.Image");
            BtnRestaurar.Location = new Point(721, -1);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(36, 35);
            BtnRestaurar.TabIndex = 0;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.FlatStyle = FlatStyle.Flat;
            BtnMinimizar.ForeColor = Color.FromArgb(0, 80, 200);
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(680, 5);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(25, 25);
            BtnMinimizar.TabIndex = 2;
            BtnMinimizar.UseVisualStyleBackColor = true;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.ForeColor = Color.FromArgb(0, 80, 200);
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(763, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(25, 25);
            BtnSalir.TabIndex = 0;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // PnMenuVertical
            // 
            PnMenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            PnMenuVertical.Controls.Add(PnlMenu);
            PnMenuVertical.Dock = DockStyle.Left;
            PnMenuVertical.Location = new Point(0, 35);
            PnMenuVertical.Name = "PnMenuVertical";
            PnMenuVertical.Size = new Size(200, 415);
            PnMenuVertical.TabIndex = 1;
            // 
            // PnlMenu
            // 
            PnlMenu.Controls.Add(btnUsuario);
            PnlMenu.Controls.Add(BtnNomina);
            PnlMenu.Controls.Add(pictureBox1);
            PnlMenu.Controls.Add(BtnEmpleados);
            PnlMenu.Dock = DockStyle.Fill;
            PnlMenu.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PnlMenu.Location = new Point(0, 0);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(200, 415);
            PnlMenu.TabIndex = 0;
            // 
            // btnUsuario
            // 
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnUsuario.ForeColor = SystemColors.ControlLightLight;
            btnUsuario.Image = (Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(12, 200);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(155, 41);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // BtnNomina
            // 
            BtnNomina.Cursor = Cursors.Hand;
            BtnNomina.FlatStyle = FlatStyle.Flat;
            BtnNomina.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnNomina.ForeColor = Color.White;
            BtnNomina.Image = (Image)resources.GetObject("BtnNomina.Image");
            BtnNomina.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNomina.Location = new Point(12, 323);
            BtnNomina.Name = "BtnNomina";
            BtnNomina.Size = new Size(155, 41);
            BtnNomina.TabIndex = 2;
            BtnNomina.Text = "Nomina";
            BtnNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNomina.UseVisualStyleBackColor = true;
            BtnNomina.Click += BtnNomina_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnEmpleados
            // 
            BtnEmpleados.Cursor = Cursors.Hand;
            BtnEmpleados.FlatStyle = FlatStyle.Flat;
            BtnEmpleados.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnEmpleados.ForeColor = SystemColors.ControlLightLight;
            BtnEmpleados.Image = (Image)resources.GetObject("BtnEmpleados.Image");
            BtnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEmpleados.Location = new Point(12, 260);
            BtnEmpleados.Name = "BtnEmpleados";
            BtnEmpleados.Size = new Size(155, 41);
            BtnEmpleados.TabIndex = 0;
            BtnEmpleados.Text = "Empleados";
            BtnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEmpleados.UseVisualStyleBackColor = true;
            BtnEmpleados.Click += BtnPrincipal_Click;
            // 
            // PnlContenedor
            // 
            PnlContenedor.BackColor = Color.FromArgb(0, 0, 64);
            PnlContenedor.Dock = DockStyle.Fill;
            PnlContenedor.Location = new Point(200, 35);
            PnlContenedor.Name = "PnlContenedor";
            PnlContenedor.Size = new Size(600, 415);
            PnlContenedor.TabIndex = 2;
            // 
            // tmExpandir
            // 
            tmExpandir.Tick += tmExpandir_Tick;
            // 
            // TmContraer
            // 
            TmContraer.Tick += TmContraer_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlContenedor);
            Controls.Add(PnMenuVertical);
            Controls.Add(PnlBarraDeTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            PnlBarraDeTitulo.ResumeLayout(false);
            PnMenuVertical.ResumeLayout(false);
            PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlBarraDeTitulo;
        private Panel PnMenuVertical;
        private Panel PnlMenu;
        private Panel PnlContenedor;
        private Button BtnSalir;
        private Button BtnMaximizar;
        private Button BtnMinimizar;
        private Button BtnRestaurar;
        private System.Windows.Forms.Timer tmExpandir;
        private System.Windows.Forms.Timer TmContraer;
        private Button BtnEmpleados;
        private PictureBox pictureBox1;
        private Button BtnNomina;
        private Button btnUsuario;
    }
}