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
            PnlBarraDeTitulo.Margin = new Padding(3, 4, 3, 4);
            PnlBarraDeTitulo.Name = "PnlBarraDeTitulo";
            PnlBarraDeTitulo.Size = new Size(914, 47);
            PnlBarraDeTitulo.TabIndex = 0;
            PnlBarraDeTitulo.Paint += PnlBarraDeTitulo_Paint;
            PnlBarraDeTitulo.MouseDown += PnlBarraDeTitulo_MouseDown;
            // 
            // BtnMaximizar
            // 
            BtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximizar.Cursor = Cursors.Hand;
            BtnMaximizar.FlatStyle = FlatStyle.Flat;
            BtnMaximizar.ForeColor = Color.FromArgb(0, 80, 200);
            BtnMaximizar.Image = (Image)resources.GetObject("BtnMaximizar.Image");
            BtnMaximizar.Location = new Point(824, 7);
            BtnMaximizar.Margin = new Padding(3, 4, 3, 4);
            BtnMaximizar.Name = "BtnMaximizar";
            BtnMaximizar.Size = new Size(34, 33);
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
            BtnRestaurar.Location = new Point(824, -1);
            BtnRestaurar.Margin = new Padding(3, 4, 3, 4);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(41, 47);
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
            BtnMinimizar.Location = new Point(777, 7);
            BtnMinimizar.Margin = new Padding(3, 4, 3, 4);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(29, 33);
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
            BtnSalir.Location = new Point(872, 5);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(29, 33);
            BtnSalir.TabIndex = 0;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // PnMenuVertical
            // 
            PnMenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            PnMenuVertical.Controls.Add(PnlMenu);
            PnMenuVertical.Dock = DockStyle.Left;
            PnMenuVertical.Location = new Point(0, 47);
            PnMenuVertical.Margin = new Padding(3, 4, 3, 4);
            PnMenuVertical.Name = "PnMenuVertical";
            PnMenuVertical.Size = new Size(229, 553);
            PnMenuVertical.TabIndex = 1;
            // 
            // PnlMenu
            // 
            PnlMenu.Controls.Add(btnUsuario);
            PnlMenu.Controls.Add(pictureBox1);
            PnlMenu.Controls.Add(BtnEmpleados);
            PnlMenu.Dock = DockStyle.Fill;
            PnlMenu.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PnlMenu.Location = new Point(0, 0);
            PnlMenu.Margin = new Padding(3, 4, 3, 4);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(229, 553);
            PnlMenu.TabIndex = 0;
            PnlMenu.Paint += PnlMenu_Paint;
            // 
            // btnUsuario
            // 
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Book Antiqua", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnUsuario.ForeColor = SystemColors.ControlLightLight;
            btnUsuario.Image = (Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(25, 267);
            btnUsuario.Margin = new Padding(3, 4, 3, 4);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(177, 55);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 105);
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
            BtnEmpleados.Location = new Point(25, 347);
            BtnEmpleados.Margin = new Padding(3, 4, 3, 4);
            BtnEmpleados.Name = "BtnEmpleados";
            BtnEmpleados.Size = new Size(177, 55);
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
            PnlContenedor.Location = new Point(229, 47);
            PnlContenedor.Margin = new Padding(3, 4, 3, 4);
            PnlContenedor.Name = "PnlContenedor";
            PnlContenedor.Size = new Size(685, 553);
            PnlContenedor.TabIndex = 2;
            PnlContenedor.Paint += PnlContenedor_Paint;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(PnlContenedor);
            Controls.Add(PnMenuVertical);
            Controls.Add(PnlBarraDeTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button BtnSalir;
        private Button BtnMaximizar;
        private Button BtnMinimizar;
        private Button BtnRestaurar;
        private System.Windows.Forms.Timer tmExpandir;
        private System.Windows.Forms.Timer TmContraer;
        private PictureBox pictureBox1;
        public Button BtnEmpleados;
        public Button btnUsuario;
        public Panel PnlMenu;
        public Panel PnlContenedor;
    }
}