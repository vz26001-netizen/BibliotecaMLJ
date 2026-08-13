namespace BibliotecaML.UI
{
    partial class FormREGISTRO_DE_USUARIOS
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
            lblNombre = new Label();
            textBox1 = new TextBox();
            lblCorreo = new Label();
            textBox2 = new TextBox();
            lblTipoDeUsuario = new Label();
            textBox3 = new TextBox();
            lblContraseña = new Label();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            btnRegistrar = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736216;
            groupBox1.Location = new Point(286, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(lblContraseña);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(lblTipoDeUsuario);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(lblCorreo);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Location = new Point(86, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(594, 143);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.InactiveBorder;
            lblNombre.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(54, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(119, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 1;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = SystemColors.InactiveBorder;
            lblCorreo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(60, 63);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(52, 15);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo :";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(119, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 3;
            // 
            // lblTipoDeUsuario
            // 
            lblTipoDeUsuario.AutoSize = true;
            lblTipoDeUsuario.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDeUsuario.Location = new Point(12, 105);
            lblTipoDeUsuario.Name = "lblTipoDeUsuario";
            lblTipoDeUsuario.Size = new Size(100, 15);
            lblTipoDeUsuario.TabIndex = 4;
            lblTipoDeUsuario.Text = "Tipo de usuario :";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(119, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 5;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = SystemColors.InactiveBorder;
            lblContraseña.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(390, 19);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(79, 15);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña :";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(475, 16);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(113, 23);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 60);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 8;
            label1.Text = "Confirmar Contraseña :";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(475, 55);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(113, 23);
            textBox5.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ScrollBar;
            btnRegistrar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(330, 371);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(136, 33);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // FormREGISTRO_DE_USUARIOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_214337;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormREGISTRO_DE_USUARIOS";
            Text = "FormREGISTRO_DE_USUARIOS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label lblTipoDeUsuario;
        private TextBox textBox2;
        private Label lblCorreo;
        private TextBox textBox1;
        private Label lblNombre;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox4;
        private Label lblContraseña;
        private Button btnRegistrar;
    }
}