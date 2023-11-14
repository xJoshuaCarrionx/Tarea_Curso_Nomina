namespace Tarea_Curso_Nomina
{
    partial class Empleados
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
            button1 = new Button();
            txtcodigo = new TextBox();
            txtprimernombre = new TextBox();
            txtsegundoapellido = new TextBox();
            txtcedula = new TextBox();
            txtsegundonombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtprimerapellido = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtdireccion = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txttelefono = new TextBox();
            label12 = new Label();
            txtcelular = new TextBox();
            cboestadocivil = new ComboBox();
            cbosexo = new ComboBox();
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
            label13 = new Label();
            label14 = new Label();
            btnadd = new Button();
            datenacimiento = new DateTimePicker();
            datecontrato = new DateTimePicker();
            datecierrecintrato = new DateTimePicker();
            btnimprimir = new Button();
            label15 = new Label();
            txtruc = new TextBox();
            label16 = new Label();
            txtinss = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1233, 195);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(145, 31);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(126, 27);
            txtcodigo.TabIndex = 1;
            txtcodigo.Text = "123321";
            // 
            // txtprimernombre
            // 
            txtprimernombre.Location = new Point(145, 93);
            txtprimernombre.Name = "txtprimernombre";
            txtprimernombre.Size = new Size(126, 27);
            txtprimernombre.TabIndex = 2;
            txtprimernombre.Text = "Leandro";
            // 
            // txtsegundoapellido
            // 
            txtsegundoapellido.Location = new Point(425, 93);
            txtsegundoapellido.Name = "txtsegundoapellido";
            txtsegundoapellido.Size = new Size(126, 27);
            txtsegundoapellido.TabIndex = 3;
            txtsegundoapellido.Text = "Matus";
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(387, 167);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(164, 27);
            txtcedula.TabIndex = 4;
            txtcedula.Text = "001-0911-1060";
            // 
            // txtsegundonombre
            // 
            txtsegundonombre.Location = new Point(145, 163);
            txtsegundonombre.Name = "txtsegundonombre";
            txtsegundonombre.Size = new Size(126, 27);
            txtsegundonombre.TabIndex = 5;
            txtsegundonombre.Text = "Enrique";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 35);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 6;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 99);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 7;
            label2.Text = "Primer Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 167);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 8;
            label3.Text = "Segundo Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 171);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 99);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 10;
            label5.Text = "Segundo Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 31);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 12;
            label6.Text = "Primer Apellido";
            // 
            // txtprimerapellido
            // 
            txtprimerapellido.Location = new Point(425, 27);
            txtprimerapellido.Name = "txtprimerapellido";
            txtprimerapellido.Size = new Size(126, 27);
            txtprimerapellido.TabIndex = 11;
            txtprimerapellido.Text = "Lacayo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(568, 29);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 14;
            label7.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(568, 93);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 16;
            label8.Text = "Direccion";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(665, 87);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(126, 27);
            txtdireccion.TabIndex = 15;
            txtdireccion.Text = "Residencial N-44";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(568, 171);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 18;
            label9.Text = "Estado Civil";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(864, 29);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 20;
            label10.Text = "Sexo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(807, 91);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 22;
            label11.Text = "Telefono";
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(904, 87);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(126, 27);
            txttelefono.TabIndex = 21;
            txttelefono.Text = "2222-4587";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(827, 163);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 24;
            label12.Text = "Celular";
            // 
            // txtcelular
            // 
            txtcelular.Location = new Point(925, 160);
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(126, 27);
            txtcelular.TabIndex = 23;
            txtcelular.Text = "8384-2742";
            // 
            // cboestadocivil
            // 
            cboestadocivil.FormattingEnabled = true;
            cboestadocivil.Items.AddRange(new object[] { "Casado", "Soltero" });
            cboestadocivil.Location = new Point(661, 163);
            cboestadocivil.Name = "cboestadocivil";
            cboestadocivil.Size = new Size(113, 28);
            cboestadocivil.TabIndex = 25;
            // 
            // cbosexo
            // 
            cbosexo.FormattingEnabled = true;
            cbosexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbosexo.Location = new Point(928, 25);
            cbosexo.Name = "cbosexo";
            cbosexo.Size = new Size(113, 28);
            cbosexo.TabIndex = 26;
            // 
            // dvgdatos
            // 
            dvgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdatos.Columns.AddRange(new DataGridViewColumn[] { code, ninss, nruc, pnombre, snombre, papellido, sapellido, cedula, fnacimiento, direccion, ecivil, sexo, telefono, celular, fcontratacion, fcierrecontrato });
            dvgdatos.Location = new Point(11, 287);
            dvgdatos.Name = "dvgdatos";
            dvgdatos.RowHeadersWidth = 51;
            dvgdatos.RowTemplate.Height = 29;
            dvgdatos.ScrollBars = ScrollBars.Horizontal;
            dvgdatos.Size = new Size(1307, 289);
            dvgdatos.TabIndex = 27;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1065, 31);
            label13.Name = "label13";
            label13.Size = new Size(136, 20);
            label13.TabIndex = 29;
            label13.Text = "Fecha Contratacion";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1045, 93);
            label14.Name = "label14";
            label14.Size = new Size(152, 20);
            label14.TabIndex = 31;
            label14.Text = "Fecha Cierre Contrato";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(1233, 235);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(86, 31);
            btnadd.TabIndex = 32;
            btnadd.Text = "Agregar";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // datenacimiento
            // 
            datenacimiento.Location = new Point(720, 21);
            datenacimiento.Name = "datenacimiento";
            datenacimiento.Size = new Size(106, 27);
            datenacimiento.TabIndex = 33;
            // 
            // datecontrato
            // 
            datecontrato.Location = new Point(1207, 27);
            datecontrato.Name = "datecontrato";
            datecontrato.Size = new Size(106, 27);
            datecontrato.TabIndex = 34;
            // 
            // datecierrecintrato
            // 
            datecierrecintrato.Location = new Point(1207, 93);
            datecierrecintrato.Name = "datecierrecintrato";
            datecierrecintrato.Size = new Size(106, 27);
            datecierrecintrato.TabIndex = 35;
            // 
            // btnimprimir
            // 
            btnimprimir.Location = new Point(1085, 236);
            btnimprimir.Margin = new Padding(3, 4, 3, 4);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(131, 31);
            btnimprimir.TabIndex = 36;
            btnimprimir.Text = "IMPRIMIR DATOS";
            btnimprimir.UseVisualStyleBackColor = true;
            btnimprimir.Click += btnimprimir_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(827, 243);
            label15.Name = "label15";
            label15.Size = new Size(95, 20);
            label15.TabIndex = 38;
            label15.Text = "Numero RUC";
            // 
            // txtruc
            // 
            txtruc.Location = new Point(929, 237);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(126, 27);
            txtruc.TabIndex = 37;
            txtruc.Text = "11-111-111";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(590, 243);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 40;
            label16.Text = "Numero Inss";
            // 
            // txtinss
            // 
            txtinss.Location = new Point(688, 237);
            txtinss.Name = "txtinss";
            txtinss.Size = new Size(126, 27);
            txtinss.TabIndex = 39;
            txtinss.Text = "777-777-77";
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 588);
            Controls.Add(label16);
            Controls.Add(txtinss);
            Controls.Add(label15);
            Controls.Add(txtruc);
            Controls.Add(btnimprimir);
            Controls.Add(datecierrecintrato);
            Controls.Add(datecontrato);
            Controls.Add(datenacimiento);
            Controls.Add(btnadd);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(dvgdatos);
            Controls.Add(cbosexo);
            Controls.Add(cboestadocivil);
            Controls.Add(label12);
            Controls.Add(txtcelular);
            Controls.Add(label11);
            Controls.Add(txttelefono);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtdireccion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtprimerapellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsegundonombre);
            Controls.Add(txtcedula);
            Controls.Add(txtsegundoapellido);
            Controls.Add(txtprimernombre);
            Controls.Add(txtcodigo);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Empleados";
            Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)dvgdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private TextBox txtcodigo;
        private TextBox txtprimernombre;
        private TextBox txtsegundoapellido;
        private TextBox txtcedula;
        private TextBox txtsegundonombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtprimerapellido;
        private Label label7;
        private Label label8;
        private TextBox txtdireccion;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txttelefono;
        private Label label12;
        private TextBox txtcelular;
        private ComboBox cboestadocivil;
        private ComboBox cbosexo;
        private DataGridView dvgdatos;
        private Label label13;
        private Label label14;
        private Button btnadd;
        private DateTimePicker datenacimiento;
        private DateTimePicker datecontrato;
        private DateTimePicker datecierrecintrato;
        private Button btnimprimir;
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
        private Label label15;
        private TextBox txtruc;
        private Label label16;
        private TextBox txtinss;
    }
}