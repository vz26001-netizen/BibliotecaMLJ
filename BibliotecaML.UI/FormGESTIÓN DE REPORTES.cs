using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BibliotecaML.LN; 

namespace BibliotecaML.UI
{
    public partial class FormGESTIÓN_DE_REPORTES : Form
    {
        public FormGESTIÓN_DE_REPORTES()
        {
            InitializeComponent();
        }

        private void FormGESTIÒN_DE_REPORTES_Load(object sender, EventArgs e)
        {
            // Cargar tipos de reportes en el ComboBox
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.Add("Préstamos Realizados");
            cmbTipoReporte.Items.Add("Devoluciones Registradas");
            cmbTipoReporte.Items.Add("Libros Más Solicitados");
            cmbTipoReporte.SelectedIndex = 0;

            dtpFechaInicial.Value = DateTime.Now.AddDays(-30);
            dtpFechaFinal.Value = DateTime.Now;
        }

        // Botón Imprimir (Genera vista previa o impresión)
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvReportes.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados para imprimir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirPagina);
            PrintPreviewDialog preview = new PrintPreviewDialog { Document = pd };
            preview.ShowDialog();
        }

        // Evento encargado del diseño de impresión de la tabla
        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvReportes.Width, this.dgvReportes.Height);
            dgvReportes.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvReportes.Width, this.dgvReportes.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        // Botón Exportar PDF / Generar consulta
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Ejemplo de consulta según el filtro
                DateTime fechaInicio = dtpFechaInicial.Value;
                DateTime fechaFin = dtpFechaFinal.Value;
                string tipo = cmbTipoReporte.SelectedItem?.ToString();


                MessageBox.Show($"Reporte '{tipo}' generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaInicial.Value = DateTime.Now.AddDays(-30);
            dtpFechaFinal.Value = DateTime.Now;
            if (cmbTipoReporte.Items.Count > 0) cmbTipoReporte.SelectedIndex = 0;

            if (dgvReportes.DataSource != null)
            {
                dgvReportes.DataSource = null;
            }
            else
            {
                dgvReportes.Rows.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaInicial_Click(object sender, EventArgs e)
        {

        }
    }
}