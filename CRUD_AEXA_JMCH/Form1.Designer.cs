namespace CRUD_AEXA_JMCH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminarLogico = new Button();
            btnEliminarFisico = new Button();
            dgvEmpleados = new DataGridView();
            chkInactivos = new CheckBox();
            labelName = new Label();
            label1 = new Label();
            label2 = new Label();
            chkReactivar = new CheckBox();
            labelAgregar = new Label();
            labelActualizar = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(182, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(526, 133);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(292, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(12, 523);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 49);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Agregar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(122, 523);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 49);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminarLogico
            // 
            btnEliminarLogico.Location = new Point(541, 543);
            btnEliminarLogico.Name = "btnEliminarLogico";
            btnEliminarLogico.Size = new Size(259, 29);
            btnEliminarLogico.TabIndex = 4;
            btnEliminarLogico.Text = "Marcar como inactivo al Usuario";
            btnEliminarLogico.UseVisualStyleBackColor = true;
            btnEliminarLogico.Click += btnEliminarLogico_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Location = new Point(426, 523);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(94, 49);
            btnEliminarFisico.TabIndex = 5;
            btnEliminarFisico.Text = "Eliminar";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(12, 185);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(801, 322);
            dgvEmpleados.TabIndex = 6;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // chkInactivos
            // 
            chkInactivos.AutoSize = true;
            chkInactivos.Location = new Point(541, 513);
            chkInactivos.Name = "chkInactivos";
            chkInactivos.Size = new Size(252, 24);
            chkInactivos.TabIndex = 7;
            chkInactivos.Text = "Mostar a los Empleados Inactivos";
            chkInactivos.UseVisualStyleBackColor = true;
            chkInactivos.CheckedChanged += chkInactivos_CheckedChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 140);
            labelName.Name = "labelName";
            labelName.Size = new Size(164, 20);
            labelName.TabIndex = 8;
            labelName.Text = "Nombre del Empleado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 133);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 10;
            label2.Text = "Descripción del Empleado:";
            // 
            // chkReactivar
            // 
            chkReactivar.AutoSize = true;
            chkReactivar.Location = new Point(222, 536);
            chkReactivar.Name = "chkReactivar";
            chkReactivar.Size = new Size(185, 24);
            chkReactivar.TabIndex = 11;
            chkReactivar.Text = "Actualizar como Activo";
            chkReactivar.UseVisualStyleBackColor = true;
            // 
            // labelAgregar
            // 
            labelAgregar.AutoSize = true;
            labelAgregar.Location = new Point(12, 16);
            labelAgregar.Name = "labelAgregar";
            labelAgregar.Size = new Size(556, 20);
            labelAgregar.TabIndex = 12;
            labelAgregar.Text = "Para [Agregar] un empleado llene los campos de Nombre y Descripción, por favor.";
            // 
            // labelActualizar
            // 
            labelActualizar.AutoSize = true;
            labelActualizar.Location = new Point(12, 47);
            labelActualizar.Name = "labelActualizar";
            labelActualizar.Size = new Size(796, 20);
            labelActualizar.TabIndex = 13;
            labelActualizar.Text = "Para [Actualizar] un empleano llene o deje vavios los campos de nombre y descripción, una vez selecione al empleado.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(586, 20);
            label3.TabIndex = 14;
            label3.Text = "Puede [Eliminar] o marcar como [Inactivo] a un empleado al momento de selecionarlo.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 584);
            Controls.Add(label3);
            Controls.Add(labelActualizar);
            Controls.Add(labelAgregar);
            Controls.Add(chkReactivar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelName);
            Controls.Add(chkInactivos);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnEliminarLogico);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "CRUD-AEXA-JMCH";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminarLogico;
        private Button btnEliminarFisico;
        private DataGridView dgvEmpleados;
        private CheckBox chkInactivos;
        private Label labelName;
        private Label label1;
        private Label label2;
        private CheckBox chkReactivar;
        private Label labelAgregar;
        private Label labelActualizar;
        private Label label3;
    }
}
