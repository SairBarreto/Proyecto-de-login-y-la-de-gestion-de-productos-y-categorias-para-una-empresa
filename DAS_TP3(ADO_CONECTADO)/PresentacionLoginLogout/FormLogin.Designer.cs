namespace PresentacionLoginLogout
{
    partial class FormLogin
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
            panelPadre = new Panel();
            panelImagen = new Panel();
            label1 = new Label();
            btnLogin = new Button();
            txtContrasenia = new TextBox();
            txtNombreLogin = new TextBox();
            panelPadre.SuspendLayout();
            SuspendLayout();
            // 
            // panelPadre
            // 
            panelPadre.BackColor = Color.FromArgb(8, 37, 54);
            panelPadre.Controls.Add(panelImagen);
            panelPadre.Controls.Add(label1);
            panelPadre.Controls.Add(btnLogin);
            panelPadre.Controls.Add(txtContrasenia);
            panelPadre.Controls.Add(txtNombreLogin);
            panelPadre.Dock = DockStyle.Fill;
            panelPadre.Location = new Point(0, 0);
            panelPadre.Name = "panelPadre";
            panelPadre.Size = new Size(662, 285);
            panelPadre.TabIndex = 0;
            // 
            // panelImagen
            // 
            panelImagen.Dock = DockStyle.Left;
            panelImagen.Location = new Point(0, 0);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(347, 285);
            panelImagen.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(404, 45);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 7;
            label1.Text = "Inicio de Sesion";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(8, 37, 54);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 37, 54);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 38, 70);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(353, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(297, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.Right;
            txtContrasenia.BackColor = Color.FromArgb(8, 37, 54);
            txtContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasenia.ForeColor = Color.White;
            txtContrasenia.Location = new Point(353, 155);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.Size = new Size(297, 33);
            txtContrasenia.TabIndex = 5;
            // 
            // txtNombreLogin
            // 
            txtNombreLogin.Anchor = AnchorStyles.Right;
            txtNombreLogin.BackColor = Color.FromArgb(8, 37, 54);
            txtNombreLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreLogin.ForeColor = Color.White;
            txtNombreLogin.Location = new Point(353, 97);
            txtNombreLogin.Name = "txtNombreLogin";
            txtNombreLogin.PlaceholderText = "Usuario";
            txtNombreLogin.Size = new Size(297, 33);
            txtNombreLogin.TabIndex = 4;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 285);
            Controls.Add(panelPadre);
            MaximumSize = new Size(678, 324);
            MinimumSize = new Size(678, 324);
            Name = "FormLogin";
            Text = "Form1";
            panelPadre.ResumeLayout(false);
            panelPadre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPadre;
        private Label label1;
        private Button btnLogin;
        private TextBox txtContrasenia;
        private TextBox txtNombreLogin;
        private Panel panelImagen;
    }
}
