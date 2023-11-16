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
            Column9 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Deu = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            chboxestado = new CheckBox();
            label16 = new Label();
            txtinss = new TextBox();
            label15 = new Label();
            txtruc = new TextBox();
            datecierrecintrato = new DateTimePicker();
            datecontrato = new DateTimePicker();
            datenacimiento = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            cbosexo = new ComboBox();
            cboestadocivil = new ComboBox();
            label12 = new Label();
            txtcelular = new TextBox();
            label11 = new Label();
            txttelefono = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtdireccion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtprimerapellido = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtsegundonombre = new TextBox();
            txtcedula = new TextBox();
            txtsegundoapellido = new TextBox();
            txtprimernombre = new TextBox();
            txtcodigo = new TextBox();
            btnimprimir = new Button();
            btnadd = new Button();
            Ingresos = new GroupBox();
            label19 = new Label();
            txthorasextras = new TextBox();
            label18 = new Label();
            txthorastrabajadas = new TextBox();
            label17 = new Label();
            txtsalporhora = new TextBox();
            btnelmininar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).BeginInit();
            groupBox1.SuspendLayout();
            Ingresos.SuspendLayout();
            SuspendLayout();
            // 
            // dvgdatos
            // 
            dvgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdatos.Columns.AddRange(new DataGridViewColumn[] { code, ninss, nruc, pnombre, snombre, papellido, sapellido, cedula, fnacimiento, direccion, ecivil, sexo, telefono, celular, fcontratacion, fcierrecontrato, Column9, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Deu, Column8 });
            dvgdatos.Location = new Point(12, 574);
            dvgdatos.Name = "dvgdatos";
            dvgdatos.RowHeadersWidth = 51;
            dvgdatos.RowTemplate.Height = 29;
            dvgdatos.ScrollBars = ScrollBars.Horizontal;
            dvgdatos.Size = new Size(1307, 277);
            dvgdatos.TabIndex = 27;
            dvgdatos.CellClick += dvgdatos_CellClick_1;
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
            // Column9
            // 
            Column9.HeaderText = "Estado del empleado";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Salario/Hora";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Horas Trabajadas";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Salario";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Horas Extras";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Salario Bruto";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Salario Anual";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Deduccion de IR";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Deu
            // 
            Deu.HeaderText = "Deduccion de Inss";
            Deu.MinimumWidth = 6;
            Deu.Name = "Deu";
            Deu.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Salario Neto";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chboxestado);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtinss);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtruc);
            groupBox1.Controls.Add(datecierrecintrato);
            groupBox1.Controls.Add(datecontrato);
            groupBox1.Controls.Add(datenacimiento);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cbosexo);
            groupBox1.Controls.Add(cboestadocivil);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtcelular);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txttelefono);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtprimerapellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtsegundonombre);
            groupBox1.Controls.Add(txtcedula);
            groupBox1.Controls.Add(txtsegundoapellido);
            groupBox1.Controls.Add(txtprimernombre);
            groupBox1.Controls.Add(txtcodigo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1329, 305);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // chboxestado
            // 
            chboxestado.AutoSize = true;
            chboxestado.Location = new Point(1118, 182);
            chboxestado.Name = "chboxestado";
            chboxestado.Size = new Size(173, 24);
            chboxestado.TabIndex = 76;
            chboxestado.Text = "Estado del empleado";
            chboxestado.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(595, 254);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 75;
            label16.Text = "Numero Inss";
            // 
            // txtinss
            // 
            txtinss.Location = new Point(693, 248);
            txtinss.Name = "txtinss";
            txtinss.Size = new Size(126, 27);
            txtinss.TabIndex = 74;
            txtinss.TextChanged += txtinss_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(832, 254);
            label15.Name = "label15";
            label15.Size = new Size(95, 20);
            label15.TabIndex = 73;
            label15.Text = "Numero RUC";
            // 
            // txtruc
            // 
            txtruc.Location = new Point(934, 248);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(126, 27);
            txtruc.TabIndex = 72;
            txtruc.TextChanged += txtruc_TextChanged;
            // 
            // datecierrecintrato
            // 
            datecierrecintrato.Location = new Point(1212, 104);
            datecierrecintrato.Name = "datecierrecintrato";
            datecierrecintrato.Size = new Size(106, 27);
            datecierrecintrato.TabIndex = 70;
            // 
            // datecontrato
            // 
            datecontrato.Location = new Point(1212, 38);
            datecontrato.Name = "datecontrato";
            datecontrato.Size = new Size(106, 27);
            datecontrato.TabIndex = 69;
            // 
            // datenacimiento
            // 
            datenacimiento.Location = new Point(725, 32);
            datenacimiento.Name = "datenacimiento";
            datenacimiento.Size = new Size(106, 27);
            datenacimiento.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1050, 104);
            label14.Name = "label14";
            label14.Size = new Size(152, 20);
            label14.TabIndex = 66;
            label14.Text = "Fecha Cierre Contrato";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1070, 42);
            label13.Name = "label13";
            label13.Size = new Size(136, 20);
            label13.TabIndex = 65;
            label13.Text = "Fecha Contratacion";
            // 
            // cbosexo
            // 
            cbosexo.FormattingEnabled = true;
            cbosexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbosexo.Location = new Point(933, 36);
            cbosexo.Name = "cbosexo";
            cbosexo.Size = new Size(113, 28);
            cbosexo.TabIndex = 64;
            cbosexo.SelectedIndexChanged += cbosexo_SelectedIndexChanged;
            // 
            // cboestadocivil
            // 
            cboestadocivil.FormattingEnabled = true;
            cboestadocivil.Items.AddRange(new object[] { "Casado", "Soltero" });
            cboestadocivil.Location = new Point(666, 174);
            cboestadocivil.Name = "cboestadocivil";
            cboestadocivil.Size = new Size(113, 28);
            cboestadocivil.TabIndex = 63;
            cboestadocivil.SelectedIndexChanged += cboestadocivil_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(832, 174);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 62;
            label12.Text = "Celular";
            // 
            // txtcelular
            // 
            txtcelular.Location = new Point(930, 171);
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(126, 27);
            txtcelular.TabIndex = 61;
            txtcelular.TextChanged += txtcelular_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(812, 102);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 60;
            label11.Text = "Telefono";
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(909, 98);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(126, 27);
            txttelefono.TabIndex = 59;
            txttelefono.TextChanged += txttelefono_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(869, 40);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 58;
            label10.Text = "Sexo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(573, 182);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 57;
            label9.Text = "Estado Civil";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(573, 104);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 56;
            label8.Text = "Direccion";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(670, 98);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(126, 27);
            txtdireccion.TabIndex = 55;
            txtdireccion.TextChanged += txtdireccion_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(573, 40);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 54;
            label7.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 42);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 53;
            label6.Text = "Primer Apellido";
            // 
            // txtprimerapellido
            // 
            txtprimerapellido.Location = new Point(430, 38);
            txtprimerapellido.Name = "txtprimerapellido";
            txtprimerapellido.Size = new Size(126, 27);
            txtprimerapellido.TabIndex = 52;
            txtprimerapellido.TextChanged += txtprimerapellido_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 110);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 51;
            label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 182);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 50;
            label4.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 178);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 49;
            label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 110);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 48;
            label2.Text = "Primer Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 47;
            label1.Text = "Codigo";
            // 
            // txtsegundonombre
            // 
            txtsegundonombre.Location = new Point(150, 174);
            txtsegundonombre.Name = "txtsegundonombre";
            txtsegundonombre.Size = new Size(126, 27);
            txtsegundonombre.TabIndex = 46;
            txtsegundonombre.TextChanged += txtsegundonombre_TextChanged;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(392, 178);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(164, 27);
            txtcedula.TabIndex = 45;
            txtcedula.TextChanged += txtcedula_TextChanged;
            // 
            // txtsegundoapellido
            // 
            txtsegundoapellido.Location = new Point(430, 104);
            txtsegundoapellido.Name = "txtsegundoapellido";
            txtsegundoapellido.Size = new Size(126, 27);
            txtsegundoapellido.TabIndex = 44;
            txtsegundoapellido.TextChanged += txtsegundoapellido_TextChanged;
            // 
            // txtprimernombre
            // 
            txtprimernombre.Location = new Point(150, 104);
            txtprimernombre.Name = "txtprimernombre";
            txtprimernombre.Size = new Size(126, 27);
            txtprimernombre.TabIndex = 43;
            txtprimernombre.TextChanged += txtprimernombre_TextChanged;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(150, 42);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(126, 27);
            txtcodigo.TabIndex = 42;
            txtcodigo.TextChanged += txtcodigo_TextChanged;
            // 
            // btnimprimir
            // 
            btnimprimir.Location = new Point(607, 485);
            btnimprimir.Margin = new Padding(3, 4, 3, 4);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(131, 31);
            btnimprimir.TabIndex = 71;
            btnimprimir.Text = "IMPRIMIR DATOS";
            btnimprimir.UseVisualStyleBackColor = true;
            btnimprimir.Click += btnimprimir_Click_1;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(757, 485);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(86, 31);
            btnadd.TabIndex = 67;
            btnadd.Text = "Agregar";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click_1;
            // 
            // Ingresos
            // 
            Ingresos.Controls.Add(label19);
            Ingresos.Controls.Add(txthorasextras);
            Ingresos.Controls.Add(label18);
            Ingresos.Controls.Add(txthorastrabajadas);
            Ingresos.Controls.Add(label17);
            Ingresos.Controls.Add(txtsalporhora);
            Ingresos.Location = new Point(12, 323);
            Ingresos.Name = "Ingresos";
            Ingresos.Size = new Size(556, 193);
            Ingresos.TabIndex = 29;
            Ingresos.TabStop = false;
            Ingresos.Text = "Ingresos";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 135);
            label19.Name = "label19";
            label19.Size = new Size(91, 20);
            label19.TabIndex = 81;
            label19.Text = "Horas Extras";
            // 
            // txthorasextras
            // 
            txthorasextras.Location = new Point(133, 129);
            txthorasextras.Name = "txthorasextras";
            txthorasextras.Size = new Size(94, 27);
            txthorasextras.TabIndex = 80;
            txthorasextras.TextChanged += txthorasextras_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 90);
            label18.Name = "label18";
            label18.Size = new Size(124, 20);
            label18.TabIndex = 79;
            label18.Text = "Horas Trabajadas";
            // 
            // txthorastrabajadas
            // 
            txthorastrabajadas.Location = new Point(136, 84);
            txthorastrabajadas.Name = "txthorastrabajadas";
            txthorastrabajadas.Size = new Size(94, 27);
            txthorastrabajadas.TabIndex = 78;
            txthorastrabajadas.TextChanged += txthorastrabajadas_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 44);
            label17.Name = "label17";
            label17.Size = new Size(91, 20);
            label17.TabIndex = 77;
            label17.Text = "Salario/hora";
            // 
            // txtsalporhora
            // 
            txtsalporhora.Location = new Point(104, 38);
            txtsalporhora.Name = "txtsalporhora";
            txtsalporhora.Size = new Size(126, 27);
            txtsalporhora.TabIndex = 76;
            txtsalporhora.TextChanged += txtsalporhora_TextChanged;
            // 
            // btnelmininar
            // 
            btnelmininar.Location = new Point(869, 485);
            btnelmininar.Margin = new Padding(3, 4, 3, 4);
            btnelmininar.Name = "btnelmininar";
            btnelmininar.Size = new Size(86, 31);
            btnelmininar.TabIndex = 72;
            btnelmininar.Text = "Eliminar";
            btnelmininar.UseVisualStyleBackColor = true;
            btnelmininar.Click += btnelmininar_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 863);
            Controls.Add(btnelmininar);
            Controls.Add(Ingresos);
            Controls.Add(groupBox1);
            Controls.Add(dvgdatos);
            Controls.Add(btnimprimir);
            Controls.Add(btnadd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Empleados";
            Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)dvgdatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Ingresos.ResumeLayout(false);
            Ingresos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dvgdatos;
        private GroupBox groupBox1;
        private Label label16;
        private TextBox txtinss;
        private Label label15;
        private TextBox txtruc;
        private Button btnimprimir;
        private DateTimePicker datecierrecintrato;
        private DateTimePicker datecontrato;
        private DateTimePicker datenacimiento;
        private Button btnadd;
        private Label label14;
        private Label label13;
        private ComboBox cbosexo;
        private ComboBox cboestadocivil;
        private Label label12;
        private TextBox txtcelular;
        private Label label11;
        private TextBox txttelefono;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtdireccion;
        private Label label7;
        private Label label6;
        private TextBox txtprimerapellido;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtsegundonombre;
        private TextBox txtcedula;
        private TextBox txtsegundoapellido;
        private TextBox txtprimernombre;
        private TextBox txtcodigo;
        private GroupBox Ingresos;
        private Label label18;
        private TextBox txthorastrabajadas;
        private Label label17;
        private TextBox txtsalporhora;
        private Label label19;
        private TextBox txthorasextras;
        private CheckBox chboxestado;
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
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Deu;
        private DataGridViewTextBoxColumn Column8;
        private Button btnelmininar;
    }
}