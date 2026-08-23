using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    partial class FormREGISTRO_DE_USUARIOS : Form
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
            cmbTipoUsuario = new ComboBox();
            txtConfirmarContraseña = new TextBox();
            label1 = new Label();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            lblTipoDeUsuario = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736216;
            groupBox1.Location = new Point(327, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(191, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbTipoUsuario);
            groupBox2.Controls.Add(txtConfirmarContraseña);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtContraseña);
            groupBox2.Controls.Add(lblContraseña);
            groupBox2.Controls.Add(lblTipoDeUsuario);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(lblCorreo);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Location = new Point(98, 260);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(679, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(136, 130);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(195, 28);
            cmbTipoUsuario.TabIndex = 10;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.BackColor = SystemColors.ScrollBar;
            txtConfirmarContraseña.Location = new Point(543, 73);
            txtConfirmarContraseña.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(129, 27);
            txtConfirmarContraseña.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 80);
            label1.Name = "label1";
            label1.Size = new Size(172, 18);
            label1.TabIndex = 8;
            label1.Text = "Confirmar Contraseña :";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.ScrollBar;
            txtContraseña.Location = new Point(543, 21);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(129, 27);
            txtContraseña.TabIndex = 7;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = SystemColors.InactiveBorder;
            lblContraseña.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(446, 25);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(98, 18);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña :";
            // 
            // lblTipoDeUsuario
            // 
            lblTipoDeUsuario.AutoSize = true;
            lblTipoDeUsuario.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDeUsuario.Location = new Point(14, 140);
            lblTipoDeUsuario.Name = "lblTipoDeUsuario";
            lblTipoDeUsuario.Size = new Size(127, 18);
            lblTipoDeUsuario.TabIndex = 4;
            lblTipoDeUsuario.Text = "Tipo de usuario :";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.ScrollBar;
            txtCorreo.Location = new Point(136, 80);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(195, 27);
            txtCorreo.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = SystemColors.InactiveBorder;
            lblCorreo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(69, 84);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(66, 18);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo :";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ScrollBar;
            txtNombre.Location = new Point(136, 21);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.InactiveBorder;
            lblNombre.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(62, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(72, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ScrollBar;
            btnRegistrar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(186, 484);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(155, 44);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnLimpiar.Location = new Point(475, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 44);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FormREGISTRO_DE_USUARIOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_214337;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormREGISTRO_DE_USUARIOS";
            Text = "REGISTRO DE USUARIOS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblTipoDeUsuario;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtConfirmarContraseña;
        private Label label1;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Button btnRegistrar;
        private ComboBox cmbTipoUsuario;
        private Button btnLimpiar;
    }
}