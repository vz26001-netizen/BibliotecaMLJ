namespace BibliotecaML.UI
{
    partial class FormMENÙ_PRINCIPAL
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
            label1 = new Label();
            btnDevoluciones = new GroupBox();
            btnLibros = new Button();
            button1 = new Button();
            btnPrèstamos = new Button();
            Devoluciones = new Button();
            btnReportes = new Button();
            groupBox2.SuspendLayout();
            btnDevoluciones.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736215;
            groupBox1.Location = new Point(279, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(169, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 41);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 16);
            label1.Name = "label1";
            label1.Size = new Size(367, 22);
            label1.TabIndex = 0;
            label1.Text = "HOLA, BIENVENIDO/ A LA LIBRERIA ML";
            label1.Click += label1_Click;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.Controls.Add(btnReportes);
            btnDevoluciones.Controls.Add(Devoluciones);
            btnDevoluciones.Controls.Add(btnPrèstamos);
            btnDevoluciones.Controls.Add(button1);
            btnDevoluciones.Controls.Add(btnLibros);
            btnDevoluciones.Location = new Point(169, 265);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(428, 104);
            btnDevoluciones.TabIndex = 2;
            btnDevoluciones.TabStop = false;
            btnDevoluciones.Text = "Devoluciones";
            // 
            // btnLibros
            // 
            btnLibros.BackColor = SystemColors.ScrollBar;
            btnLibros.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.Location = new Point(19, 22);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(75, 23);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros ";
            btnLibros.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(124, 22);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 1;
            button1.Text = "Usuarios / Estudiantes";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnPrèstamos
            // 
            btnPrèstamos.BackColor = SystemColors.ScrollBar;
            btnPrèstamos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrèstamos.Location = new Point(315, 22);
            btnPrèstamos.Name = "btnPrèstamos";
            btnPrèstamos.Size = new Size(75, 23);
            btnPrèstamos.TabIndex = 2;
            btnPrèstamos.Text = "Prèstamos";
            btnPrèstamos.UseVisualStyleBackColor = false;
            // 
            // Devoluciones
            // 
            Devoluciones.BackColor = SystemColors.ScrollBar;
            Devoluciones.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Devoluciones.Location = new Point(69, 68);
            Devoluciones.Name = "Devoluciones";
            Devoluciones.Size = new Size(75, 23);
            Devoluciones.TabIndex = 3;
            Devoluciones.Text = "Devoluciones";
            Devoluciones.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.ScrollBar;
            btnReportes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(255, 68);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(75, 23);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // FormMENÙ_PRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_212945;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDevoluciones);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMENÙ_PRINCIPAL";
            Text = "FormMENÙ_PRINCIPAL";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            btnDevoluciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox btnDevoluciones;
        private Button button1;
        private Button btnLibros;
        private Button Devoluciones;
        private Button btnPrèstamos;
        private Button btnReportes;
    }
}