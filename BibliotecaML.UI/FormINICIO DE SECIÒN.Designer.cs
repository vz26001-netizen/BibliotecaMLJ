namespace BibliotecaML.UI
{
    partial class FormINICIO_DE_SECIÒN
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
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            lblCorreoElectronico = new Label();
            txtCorreoElectrnico = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            btnGoogle = new Button();
            btnFacebook = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_173621;
            groupBox1.Location = new Point(287, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtContraseña);
            groupBox2.Controls.Add(lblContraseña);
            groupBox2.Controls.Add(txtCorreoElectrnico);
            groupBox2.Controls.Add(lblCorreoElectronico);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(126, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 91);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFacebook);
            groupBox3.Controls.Add(btnGoogle);
            groupBox3.Controls.Add(btnIniciarSesion);
            groupBox3.Location = new Point(126, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 53);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(199, 370);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(364, 26);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreoElectronico.Location = new Point(30, 19);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(119, 15);
            lblCorreoElectronico.TabIndex = 0;
            lblCorreoElectronico.Text = "Correo electrònico :";
            // 
            // txtCorreoElectrnico
            // 
            txtCorreoElectrnico.Location = new Point(155, 16);
            txtCorreoElectrnico.Name = "txtCorreoElectrnico";
            txtCorreoElectrnico.Size = new Size(216, 23);
            txtCorreoElectrnico.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(70, 51);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(79, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña :";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(155, 51);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(216, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.ScrollBar;
            btnIniciarSesion.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(30, 13);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(94, 23);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesiòn";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // btnGoogle
            // 
            btnGoogle.BackColor = SystemColors.ScrollBar;
            btnGoogle.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoogle.Location = new Point(197, 13);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(75, 23);
            btnGoogle.TabIndex = 1;
            btnGoogle.Text = "Google";
            btnGoogle.UseVisualStyleBackColor = false;
            // 
            // btnFacebook
            // 
            btnFacebook.BackColor = SystemColors.ScrollBar;
            btnFacebook.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacebook.Location = new Point(346, 13);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Size = new Size(75, 23);
            btnFacebook.TabIndex = 2;
            btnFacebook.Text = "Facebook";
            btnFacebook.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(82, 8);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Olvidaste tu contraseña?";
            // 
            // FormINICIO_DE_SECIÒN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_171855;
            ClientSize = new Size(809, 432);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormINICIO_DE_SECIÒN";
            Text = "FormINICIO_DE_SECIÒN";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtCorreoElectrnico;
        private Label lblCorreoElectronico;
        private Button btnIniciarSesion;
        private Button btnGoogle;
        private Button btnFacebook;
        private Label label1;
    }
}