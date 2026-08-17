namespace BibliotecaML.UI
{
    partial class FormGESTIÒN_DE_REPORTES
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
            txtTipoReporte = new TextBox();
            lblTipoDeReporte = new Label();
            txtFechaFinal = new TextBox();
            FechaFinal = new Label();
            txtFechaInicial = new TextBox();
            lblFechaInicial = new Label();
            groupBox3 = new GroupBox();
            btnLimpiar = new Button();
            btnExportarPDF = new Button();
            btnImprimir = new Button();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736213;
            groupBox1.Location = new Point(279, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTipoReporte);
            groupBox2.Controls.Add(lblTipoDeReporte);
            groupBox2.Controls.Add(txtFechaFinal);
            groupBox2.Controls.Add(FechaFinal);
            groupBox2.Controls.Add(txtFechaInicial);
            groupBox2.Controls.Add(lblFechaInicial);
            groupBox2.Location = new Point(119, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtTipoReporte
            // 
            txtTipoReporte.BackColor = SystemColors.ScrollBar;
            txtTipoReporte.Location = new Point(163, 79);
            txtTipoReporte.Name = "txtTipoReporte";
            txtTipoReporte.Size = new Size(255, 23);
            txtTipoReporte.TabIndex = 5;
            // 
            // lblTipoDeReporte
            // 
            lblTipoDeReporte.AutoSize = true;
            lblTipoDeReporte.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // 
            // lblFechaInicial
            // 
            lblFechaInicial.AutoSize = true;
            lblFechaInicial.BackColor = SystemColors.ControlLight;
            lblFechaInicial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInicial.Location = new Point(65, 19);
            lblFechaInicial.Name = "lblFechaInicial";
            lblFechaInicial.Size = new Size(83, 15);
            lblFechaInicial.TabIndex = 0;
            lblFechaInicial.Text = "Fecha Inicial :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnExportarPDF);
            groupBox3.Controls.Add(btnImprimir);
            groupBox3.Location = new Point(119, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 39);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnLimpiar
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(119, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 82);
            dataGridView1.TabIndex = 3;
            // 
            // FormGESTIÒN_DE_REPORTES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_204251;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormGESTIÒN_DE_REPORTES";
            Text = "FormGESTIÒN_DE_REPORTES";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label FechaFinal;
        private TextBox txtFechaInicial;
        private Label lblFechaInicial;
        private Label lblTipoDeReporte;
        private TextBox txtFechaFinal;
        private TextBox txtTipoReporte;
        private GroupBox groupBox3;
        private Button btnImprimir;
        private Button btnLimpiar;
        private Button btnExportarPDF;
        private DataGridView dataGridView1;
    }
}