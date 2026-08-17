namespace BibliotecaML.UI
{
    partial class FrmEstudiantes
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
            Datos = new GroupBox();
            lblDatos = new Label();
            txtIdTelefono = new TextBox();
            lblIdTelefono = new Label();
            txIdCorreo = new TextBox();
            lblIdCorreo = new Label();
            txtIdDocumento = new TextBox();
            llIdDocumento = new Label();
            txtIdApellido = new TextBox();
            lblIdApellido = new Label();
            txtIdNombre = new TextBox();
            lblIdNombre = new Label();
            txtEstudiante = new TextBox();
            lblIdEstudiante = new Label();
            grpBotones = new GroupBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            dataGridView1 = new DataGridView();
            ColIdEstudiante = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            Datos.SuspendLayout();
            grpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Datos
            // 
            Datos.Controls.Add(lblDatos);
            Datos.Controls.Add(txtIdTelefono);
            Datos.Controls.Add(lblIdTelefono);
            Datos.Controls.Add(txIdCorreo);
            Datos.Controls.Add(lblIdCorreo);
            Datos.Controls.Add(txtIdDocumento);
            Datos.Controls.Add(llIdDocumento);
            Datos.Controls.Add(txtIdApellido);
            Datos.Controls.Add(lblIdApellido);
            Datos.Controls.Add(txtIdNombre);
            Datos.Controls.Add(lblIdNombre);
            Datos.Controls.Add(txtEstudiante);
            Datos.Controls.Add(lblIdEstudiante);
            Datos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Datos.Location = new Point(118, 183);
            Datos.Name = "Datos";
            Datos.Size = new Size(654, 93);
            Datos.TabIndex = 1;
            Datos.TabStop = false;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.Location = new Point(6, 0);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(58, 19);
            lblDatos.TabIndex = 12;
            lblDatos.Text = "Datos ";
            // 
            // txtIdTelefono
            // 
            txtIdTelefono.BackColor = SystemColors.InactiveCaption;
            txtIdTelefono.Location = new Point(540, 61);
            txtIdTelefono.Name = "txtIdTelefono";
            txtIdTelefono.Size = new Size(100, 21);
            txtIdTelefono.TabIndex = 11;
            // 
            // lblIdTelefono
            // 
            lblIdTelefono.AutoSize = true;
            lblIdTelefono.Location = new Point(450, 61);
            lblIdTelefono.Name = "lblIdTelefono";
            lblIdTelefono.Size = new Size(74, 15);
            lblIdTelefono.TabIndex = 10;
            lblIdTelefono.Text = "Id Telèfono :";
            // 
            // txIdCorreo
            // 
            txIdCorreo.BackColor = SystemColors.InactiveCaption;
            txIdCorreo.Location = new Point(335, 61);
            txIdCorreo.Name = "txIdCorreo";
            txIdCorreo.Size = new Size(100, 21);
            txIdCorreo.TabIndex = 9;
            // 
            // lblIdCorreo
            // 
            lblIdCorreo.AutoSize = true;
            lblIdCorreo.Location = new Point(234, 61);
            lblIdCorreo.Name = "lblIdCorreo";
            lblIdCorreo.Size = new Size(65, 15);
            lblIdCorreo.TabIndex = 8;
            lblIdCorreo.Text = "Id Correo :";
            // 
            // txtIdDocumento
            // 
            txtIdDocumento.BackColor = SystemColors.InactiveCaption;
            txtIdDocumento.Location = new Point(111, 58);
            txtIdDocumento.Name = "txtIdDocumento";
            txtIdDocumento.Size = new Size(100, 21);
            txtIdDocumento.TabIndex = 7;
            // 
            // llIdDocumento
            // 
            llIdDocumento.AutoSize = true;
            llIdDocumento.Location = new Point(14, 61);
            llIdDocumento.Name = "llIdDocumento";
            llIdDocumento.Size = new Size(91, 15);
            llIdDocumento.TabIndex = 6;
            llIdDocumento.Text = "Id Documento :";
            // 
            // txtIdApellido
            // 
            txtIdApellido.BackColor = SystemColors.InactiveCaption;
            txtIdApellido.ForeColor = SystemColors.InactiveCaption;
            txtIdApellido.Location = new Point(540, 30);
            txtIdApellido.Name = "txtIdApellido";
            txtIdApellido.Size = new Size(100, 21);
            txtIdApellido.TabIndex = 5;
            // 
            // lblIdApellido
            // 
            lblIdApellido.AutoSize = true;
            lblIdApellido.Location = new Point(450, 30);
            lblIdApellido.Name = "lblIdApellido";
            lblIdApellido.Size = new Size(71, 15);
            lblIdApellido.TabIndex = 4;
            lblIdApellido.Text = "Id Apellido :";
            // 
            // txtIdNombre
            // 
            txtIdNombre.BackColor = SystemColors.InactiveCaption;
            txtIdNombre.Location = new Point(335, 30);
            txtIdNombre.Name = "txtIdNombre";
            txtIdNombre.Size = new Size(100, 21);
            txtIdNombre.TabIndex = 3;
            // 
            // lblIdNombre
            // 
            lblIdNombre.AutoSize = true;
            lblIdNombre.Location = new Point(234, 30);
            lblIdNombre.Name = "lblIdNombre";
            lblIdNombre.Size = new Size(71, 15);
            lblIdNombre.TabIndex = 2;
            lblIdNombre.Text = "Id Nombre :";
            // 
            // txtEstudiante
            // 
            txtEstudiante.BackColor = SystemColors.InactiveCaption;
            txtEstudiante.Location = new Point(111, 30);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(100, 21);
            txtEstudiante.TabIndex = 1;
            // 
            // lblIdEstudiante
            // 
            lblIdEstudiante.AutoSize = true;
            lblIdEstudiante.Location = new Point(19, 30);
            lblIdEstudiante.Name = "lblIdEstudiante";
            lblIdEstudiante.Size = new Size(86, 15);
            lblIdEstudiante.TabIndex = 0;
            lblIdEstudiante.Text = "Id Estudiante :";
            // 
            // grpBotones
            // 
            grpBotones.Controls.Add(btnLimpiar);
            grpBotones.Controls.Add(btnEliminar);
            grpBotones.Controls.Add(btnActualizar);
            grpBotones.Controls.Add(btnAgregar);
            grpBotones.Controls.Add(btnNuevo);
            grpBotones.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBotones.Location = new Point(118, 282);
            grpBotones.Name = "grpBotones";
            grpBotones.Size = new Size(654, 50);
            grpBotones.TabIndex = 2;
            grpBotones.TabStop = false;
            grpBotones.Text = "Botones ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(551, 25);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(424, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(295, 25);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ScrollBar;
            btnAgregar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(158, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ScrollBar;
            btnNuevo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(19, 25);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColIdEstudiante, colNombre, colApellido, colDocumento, colCorreo, colTelefono });
            dataGridView1.Location = new Point(118, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(654, 89);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColIdEstudiante
            // 
            ColIdEstudiante.HeaderText = "Id Estudiante";
            ColIdEstudiante.Name = "ColIdEstudiante";
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Aellido";
            colApellido.Name = "colApellido";
            // 
            // colDocumento
            // 
            colDocumento.HeaderText = "Documento";
            colDocumento.Name = "colDocumento";
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.Name = "colCorreo";
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telèfono";
            colTelefono.Name = "colTelefono";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736217;
            groupBox1.Location = new Point(317, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 165);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // FrmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._110728;
            ClientSize = new Size(859, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(grpBotones);
            Controls.Add(Datos);
            Name = "FrmEstudiantes";
            Text = "FrmEstudiantes";
            Datos.ResumeLayout(false);
            Datos.PerformLayout();
            grpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grDatos;
        private Label IdNombre;
        private Label lblIdEstudiate;
        private Label lblNombre;
        private TextBox txtIdEstudiante;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private GroupBox Datos;
        private Label lblIdEstudiante;
        private TextBox txtEstudiante;
        private TextBox txtIdNombre;
        private Label lblIdNombre;
        private TextBox txtIdApellido;
        private Label lblIdApellido;
        private Label lblIdTelefono;
        private TextBox txIdCorreo;
        private Label lblIdCorreo;
        private TextBox txtIdDocumento;
        private Label llIdDocumento;
        private TextBox txtIdTelefono;
        private GroupBox grpBotones;
        private Label lblDatos;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColIdEstudiante;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colTelefono;
        private GroupBox groupBox1;
    }
}