using System;
using System.Windows.Forms;
using BibliotecaML.EN;
using BibliotecaML.LN;

namespace BibliotecaML.UI
{
    public partial class FrmEstudiantes : Form
    {
        private EstudianteLN estudianteLN = new EstudianteLN();
        private int idEstudianteSeleccionado = 0;

        // Declaración de controles
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblTipoUsuario;
        private TextBox txtTipoUsuario;

        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;

        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e) => CargarTabla();

        private void CargarTabla()
        {
            // Apunta al nombre real del DataGridView
            dataGridView1.DataSource = estudianteLN.ObtenerEstudiantes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Estudiante estudiante = new Estudiante
            {
                IdEstudiante = idEstudianteSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Documento = txtDocumento.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim()
            };

            bool ok = idEstudianteSeleccionado == 0 ? estudianteLN.Agregar(estudiante) : estudianteLN.Actualizar(estudiante);

            if (ok)
            {
                MessageBox.Show("Estudiante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEstudianteSeleccionado > 0)
            {
                if (MessageBox.Show("¿Desea eliminar este estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (estudianteLN.Eliminar(idEstudianteSeleccionado))
                    {
                        MessageBox.Show("Estudiante eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarTabla();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        // Evita el error del diseñador
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idEstudianteSeleccionado = Convert.ToInt32(row.Cells["IdEstudiante"].Value);
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value?.ToString();
                txtDocumento.Text = row.Cells["Documento"].Value?.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value?.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString();
            }
        }

        private void LimpiarCampos()
        {
            idEstudianteSeleccionado = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();

            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblTipoUsuario = new Label();
            txtTipoUsuario = new TextBox();

            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();

            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736218;
            groupBox1.Location = new System.Drawing.Point(344, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(200, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;

            // 
            // groupBox2 (Contenedor de Inputs)
            // 
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(lblApellido);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(lblDocumento);
            groupBox2.Controls.Add(txtDocumento);
            groupBox2.Controls.Add(lblCorreo);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(lblTelefono);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(lblTipoUsuario);
            groupBox2.Controls.Add(txtTipoUsuario);
            groupBox2.Location = new System.Drawing.Point(127, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(642, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;

            // Campos de Texto y Labels
            lblNombre.Text = "Nombre:";
            lblNombre.Location = new System.Drawing.Point(20, 20);
            txtNombre.Location = new System.Drawing.Point(90, 17);

            lblApellido.Text = "Apellido:";
            lblApellido.Location = new System.Drawing.Point(220, 20);
            txtApellido.Location = new System.Drawing.Point(290, 17);

            lblDocumento.Text = "Documento:";
            lblDocumento.Location = new System.Drawing.Point(420, 20);
            txtDocumento.Location = new System.Drawing.Point(500, 17);

            lblCorreo.Text = "Correo:";
            lblCorreo.Location = new System.Drawing.Point(20, 60);
            txtCorreo.Location = new System.Drawing.Point(90, 57);

            lblTelefono.Text = "Teléfono:";
            lblTelefono.Location = new System.Drawing.Point(220, 60);
            txtTelefono.Location = new System.Drawing.Point(290, 57);

            lblTipoUsuario.Text = "Tipo:";
            lblTipoUsuario.Location = new System.Drawing.Point(420, 60);
            txtTipoUsuario.Location = new System.Drawing.Point(500, 57);

            // 
            // groupBox3 (Contenedor de Botones)
            // 
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Location = new System.Drawing.Point(127, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(642, 43);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;

            btnAgregar.Text = "Guardar";
            btnAgregar.Location = new System.Drawing.Point(150, 12);
            btnAgregar.Click += new EventHandler(btnAgregar_Click);

            btnEliminar.Text = "Eliminar";
            btnEliminar.Location = new System.Drawing.Point(280, 12);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);

            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Location = new System.Drawing.Point(410, 12);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);

            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(127, 364);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(642, 100);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            // 
            // FrmEstudiantes
            // 
            ClientSize = new System.Drawing.Size(891, 480);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmEstudiantes";
            Text = "GESTIÓN DE ESTUDIANTES";
            Load += new EventHandler(FrmEstudiantes_Load);

            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}