namespace Tarea_Curso_Nomina
{
    partial class Nomina
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
            dvgdatos = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            ninss = new DataGridViewTextBoxColumn();
            nruc = new DataGridViewTextBoxColumn();
            pnombre = new DataGridViewTextBoxColumn();
            snombre = new DataGridViewTextBoxColumn();
            papellido = new DataGridViewTextBoxColumn();
            sapellido = new DataGridViewTextBoxColumn();
            cedula = new DataGridViewTextBoxColumn();
            fnacimiento = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            ecivil = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            celular = new DataGridViewTextBoxColumn();
            fcontratacion = new DataGridViewTextBoxColumn();
            fcierrecontrato = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).BeginInit();
            SuspendLayout();
            // 
            // dvgdatos
            // 
            dvgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdatos.Columns.AddRange(new DataGridViewColumn[] { code, ninss, nruc, pnombre, snombre, papellido, sapellido, cedula, fnacimiento, direccion, ecivil, sexo, telefono, celular, fcontratacion, fcierrecontrato });
            dvgdatos.Location = new Point(12, 303);
            dvgdatos.Name = "dvgdatos";
            dvgdatos.RowHeadersWidth = 51;
            dvgdatos.RowTemplate.Height = 29;
            dvgdatos.ScrollBars = ScrollBars.Horizontal;
            dvgdatos.Size = new Size(1307, 289);
            dvgdatos.TabIndex = 28;
            // 
            // code
            // 
            code.HeaderText = "Codigo";
            code.MinimumWidth = 6;
            code.Name = "code";
            code.Width = 125;
            // 
            // ninss
            // 
            ninss.HeaderText = "Numero Inss";
            ninss.MinimumWidth = 6;
            ninss.Name = "ninss";
            ninss.Width = 125;
            // 
            // nruc
            // 
            nruc.HeaderText = "Numero RUC";
            nruc.MinimumWidth = 6;
            nruc.Name = "nruc";
            nruc.Width = 125;
            // 
            // pnombre
            // 
            pnombre.HeaderText = "Primer Nombre";
            pnombre.MinimumWidth = 6;
            pnombre.Name = "pnombre";
            pnombre.Width = 125;
            // 
            // snombre
            // 
            snombre.HeaderText = "Segundo Nombre";
            snombre.MinimumWidth = 6;
            snombre.Name = "snombre";
            snombre.Width = 125;
            // 
            // papellido
            // 
            papellido.HeaderText = "Primer Apellido";
            papellido.MinimumWidth = 6;
            papellido.Name = "papellido";
            papellido.Width = 125;
            // 
            // sapellido
            // 
            sapellido.HeaderText = "Segundo apellido";
            sapellido.MinimumWidth = 6;
            sapellido.Name = "sapellido";
            sapellido.Width = 125;
            // 
            // cedula
            // 
            cedula.HeaderText = "Cedula";
            cedula.MinimumWidth = 6;
            cedula.Name = "cedula";
            cedula.Width = 125;
            // 
            // fnacimiento
            // 
            fnacimiento.HeaderText = "Fecha de nacimiento";
            fnacimiento.MinimumWidth = 6;
            fnacimiento.Name = "fnacimiento";
            fnacimiento.Width = 125;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.Width = 125;
            // 
            // ecivil
            // 
            ecivil.HeaderText = "Estado Civil";
            ecivil.MinimumWidth = 6;
            ecivil.Name = "ecivil";
            ecivil.Width = 125;
            // 
            // sexo
            // 
            sexo.HeaderText = "Sexo";
            sexo.MinimumWidth = 6;
            sexo.Name = "sexo";
            sexo.Width = 125;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.Width = 125;
            // 
            // celular
            // 
            celular.HeaderText = "Celular";
            celular.MinimumWidth = 6;
            celular.Name = "celular";
            celular.Width = 125;
            // 
            // fcontratacion
            // 
            fcontratacion.HeaderText = "Fecha de contratcion";
            fcontratacion.MinimumWidth = 6;
            fcontratacion.Name = "fcontratacion";
            fcontratacion.Width = 125;
            // 
            // fcierrecontrato
            // 
            fcierrecontrato.HeaderText = "Fecha cierre de contrato";
            fcierrecontrato.MinimumWidth = 6;
            fcierrecontrato.Name = "fcierrecontrato";
            fcierrecontrato.Width = 125;
            // 
            // Nomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 613);
            Controls.Add(dvgdatos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Nomina";
            Text = "Nomina";
            Load += Nomina_Load;
            ((System.ComponentModel.ISupportInitialize)dvgdatos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn ninss;
        private DataGridViewTextBoxColumn nruc;
        private DataGridViewTextBoxColumn pnombre;
        private DataGridViewTextBoxColumn snombre;
        private DataGridViewTextBoxColumn papellido;
        private DataGridViewTextBoxColumn sapellido;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn fnacimiento;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn ecivil;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn celular;
        private DataGridViewTextBoxColumn fcontratacion;
        private DataGridViewTextBoxColumn fcierrecontrato;
        public DataGridView dvgdatos;
    }
}