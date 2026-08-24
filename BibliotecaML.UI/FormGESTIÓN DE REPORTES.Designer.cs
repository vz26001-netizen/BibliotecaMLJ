namespace BibliotecaML.UI
{
    partial class FormGESTIÓN_DE_REPORTES
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
<<<<<<< HEAD:BibliotecaML.UI/FormGESTIÓN DE REPORTES.Designer.cs
            lblTipoDeReporte = new Label();
            FechaInicial = new Label();
=======
            txtTipoReporte = new TextBox();
            lblTipoDeReporte = new Label();
            txtFechaFinal = new TextBox();
            FechaFinal = new Label();
            txtFechaInicial = new TextBox();
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormGESTIÒN DE REPORTES.Designer.cs
            lblFechaInicial = new Label();
            groupBox3 = new GroupBox();
            btnLimpiar = new Button();
            btnExportarPDF = new Button();
            btnImprimir = new Button();
<<<<<<< HEAD:BibliotecaML.UI/FormGESTIÓN DE REPORTES.Designer.cs
            dgvReportes = new DataGridView();
            dtpFechaInicial = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            cmbTipoReporte = new ComboBox();
=======
            dataGridView1 = new DataGridView();
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormGESTIÒN DE REPORTES.Designer.cs
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736213;
            groupBox1.Location = new Point(319, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(200, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
<<<<<<< HEAD:BibliotecaML.UI/FormGESTIÓN DE REPORTES.Designer.cs
            groupBox2.Controls.Add(cmbTipoReporte);
            groupBox2.Controls.Add(dtpFechaFinal);
            groupBox2.Controls.Add(dtpFechaInicial);
            groupBox2.Controls.Add(lblTipoDeReporte);
            groupBox2.Controls.Add(FechaInicial);
=======
            groupBox2.Controls.Add(txtTipoReporte);
            groupBox2.Controls.Add(lblTipoDeReporte);
            groupBox2.Controls.Add(txtFechaFinal);
            groupBox2.Controls.Add(FechaFinal);
            groupBox2.Controls.Add(txtFechaInicial);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormGESTIÒN DE REPORTES.Designer.cs
            groupBox2.Controls.Add(lblFechaInicial);
            groupBox2.Location = new Point(136, 267);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(586, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
<<<<<<< HEAD:BibliotecaML.UI/FormGESTIÓN DE REPORTES.Designer.cs
=======
            // txtTipoReporte
            // 
            txtTipoReporte.BackColor = SystemColors.ScrollBar;
            txtTipoReporte.Location = new Point(163, 79);
            txtTipoReporte.Name = "txtTipoReporte";
            txtTipoReporte.Size = new Size(255, 23);
            txtTipoReporte.TabIndex = 5;
            // 
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormGESTIÒN DE REPORTES.Designer.cs
            // lblTipoDeReporte
            // 
            lblTipoDeReporte.AutoSize = true;
            lblTipoDeReporte.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD:BibliotecaML.UI/FormGESTIÓN DE REPORTES.Designer.cs
            lblTipoDeReporte.Location = new Point(74, 109);
            lblTipoDeReporte.Name = "lblTipoDeReporte";
            lblTipoDeReporte.Size = new Size(118, 18);
            lblTipoDeReporte.TabIndex = 4;
            lblTipoDeReporte.Text = "Tip de reporte :";
            // 
            // FechaInicial
            // 
            FechaInicial.AutoSize = true;
            FechaInicial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaInicial.Location = new Point(74, 68);
            FechaInicial.Name = "FechaInicial";
            FechaInicial.Size = new Size(97, 18);
            FechaInicial.TabIndex = 2;
            FechaInicial.Text = "Fecha Final :";
            FechaInicial.Click += FechaInicial_Click;
=======
            lblTipoDeReporte.Location = new Point(65, 82);
            lblTipoDeReporte.Name = "lblTipoDeReporte";
            lblTipoDeReporte.Size = new Size(92, 15);
            lblTipoDeReporte.TabIndex = 4;
            lblTipoDeReporte.Text = "Tip de reporte :";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.BackColor = SystemColors.ScrollBar;
            txtFechaFinal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaFinal.Location = new Point(160, 48);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(258, 21);
            txtFechaFinal.TabIndex = 3;
            txtFechaFinal.Text = "Mièrcoles, 12 de agosto del 2026";
            // 
            // FechaFinal
            // 
            FechaFinal.AutoSize = true;
            FechaFinal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaFinal.Location = new Point(65, 51);
            FechaFinal.Name = "FechaFinal";
            FechaFinal.Size = new Size(79, 15);
            FechaFinal.TabIndex = 2;
            FechaFinal.Text = "Fecha Final  :";
            // 
            // txtFechaInicial
            // 
            txtFechaInicial.BackColor = SystemColors.ScrollBar;
            txtFechaInicial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaInicial.Location = new Point(160, 16);
            txtFechaInicial.Name = "txtFechaInicial";
            txtFechaInicial.Size = new Size(258, 21);
            txtFechaInicial.TabIndex = 1;
            txtFechaInicial.Text = "Mièrcoles, 12 de agosto del 2026";
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormGESTIÒN DE REPORTES.Designer.cs
            // 
            // lblFechaInicial
            // 
            lblFechaInicial.AutoSize = true;
            lblFechaInicial.BackColor = SystemColors.ControlLight;
            lblFechaInicial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInicial.Location = new Point(74, 25);
            lblFechaInicial.Name = "lblFechaInicial";
            lblFechaInicial.Size = new Size(104, 18);
            lblFechaInicial.TabIndex = 0;
            lblFechaInicial.Text = "Fecha Inicial :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnExportarPDF);
            groupBox3.Controls.Add(btnImprimir);
            groupBox3.Location = new Point(136, 415);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(586, 52);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnLimpiar
<<<<<<< HEAD:BibliotecaML.UI/FormGESTIÓN DE REPORTES.Designer.cs
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(410, 13);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 31);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
=======
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(359, 10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = SystemColors.ScrollBar;
            btnExportarPDF.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPDF.Location = new Point(203, 10);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(102, 23);
            btnExportarPDF.TabIndex = 1;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.ScrollBar;
            btnImprimir.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.Location = new Point(56, 10);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(92, 23);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir PDF";
            btnImprimir.UseVisualStyleBackColor = false;
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormGESTIÒN DE REPORTES.Designer.cs
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = SystemColors.ScrollBar;
            btnExportarPDF.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPDF.Location = new Point(232, 13);
            btnExportarPDF.Margin = new Padding(3, 4, 3, 4);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(117, 31);
            btnExportarPDF.TabIndex = 1;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.ScrollBar;
            btnImprimir.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.Location = new Point(64, 13);
            btnImprimir.Margin = new Padding(3, 4, 3, 4);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(105, 31);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir PDF";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(136, 475);
            dgvReportes.Margin = new Padding(3, 4, 3, 4);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(586, 109);
            dgvReportes.TabIndex = 3;
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Location = new Point(183, 18);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(250, 27);
            dtpFechaInicial.TabIndex = 6;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(183, 59);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(250, 27);
            dtpFechaFinal.TabIndex = 7;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(198, 99);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(235, 28);
            cmbTipoReporte.TabIndex = 8;
            // 
            // FormGESTIÓN_DE_REPORTES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_204251;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvReportes);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGESTIÓN_DE_REPORTES";
            Text = "GESTIÓN DE REPORTES";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
<<<<<<< HEAD:BibliotecaML.UI/FormGESTIÓN DE REPORTES.Designer.cs
        private Label FechaInicial;
        private Label lblFechaInicial;
        private Label lblTipoDeReporte;
=======
        private Label FechaFinal;
        private TextBox txtFechaInicial;
        private Label lblFechaInicial;
        private Label lblTipoDeReporte;
        private TextBox txtFechaFinal;
        private TextBox txtTipoReporte;
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormGESTIÒN DE REPORTES.Designer.cs
        private GroupBox groupBox3;
        private Button btnImprimir;
        private Button btnLimpiar;
        private Button btnExportarPDF;
        private DataGridView dgvReportes;
        private ComboBox cmbTipoReporte;
        private DateTimePicker dtpFechaFinal;
        private DateTimePicker dtpFechaInicial;
    }
}