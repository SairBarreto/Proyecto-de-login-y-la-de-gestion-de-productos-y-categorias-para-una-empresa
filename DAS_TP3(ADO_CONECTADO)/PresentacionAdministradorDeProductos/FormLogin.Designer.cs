namespace PresentacionAdministradorDeProductos
{
    partial class FormLogin
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
            panelPrincipal = new Panel();
            label1 = new Label();
            btnLogin = new Button();
            txtContrasenia = new TextBox();
            txtNombreLogin = new TextBox();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(81, 86, 118);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(btnLogin);
            panelPrincipal.Controls.Add(txtContrasenia);
            panelPrincipal.Controls.Add(txtNombreLogin);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(656, 262);
            panelPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 29);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 11;
            label1.Text = "Inicio de Sesion";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(81, 86, 118);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(180, 196);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(297, 38);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.None;
            txtContrasenia.BackColor = Color.White;
            txtContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtContrasenia.ForeColor = Color.Black;
            txtContrasenia.Location = new Point(180, 139);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.Size = new Size(297, 33);
            txtContrasenia.TabIndex = 9;
            // 
            // txtNombreLogin
            // 
            txtNombreLogin.Anchor = AnchorStyles.None;
            txtNombreLogin.BackColor = Color.White;
            txtNombreLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtNombreLogin.ForeColor = Color.Black;
            txtNombreLogin.Location = new Point(180, 81);
            txtNombreLogin.Name = "txtNombreLogin";
            txtNombreLogin.PlaceholderText = "Usuario";
            txtNombreLogin.Size = new Size(297, 33);
            txtNombreLogin.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 262);
            Controls.Add(panelPrincipal);
            MaximumSize = new Size(672, 301);
            MinimumSize = new Size(672, 301);
            Name = "FormLogin";
            Text = "FormLogin";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label label1;
        private Button btnLogin;
        private TextBox txtContrasenia;
        private TextBox txtNombreLogin;
    }
}