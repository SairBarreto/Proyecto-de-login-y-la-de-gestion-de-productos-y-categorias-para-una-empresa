namespace PresentacionAdministradorDeProductos
{
    partial class FormUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelPrincipal = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtPassword = new TextBox();
            btnAltaUsuario = new Button();
            label5 = new Label();
            cbSeleccionTipo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            dgvUsuariosBloqueados = new DataGridView();
            btnDesbloquearUsuario = new Button();
            btnLogout = new Button();
            panelPrincipal.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosBloqueados).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(81, 86, 118);
            panelPrincipal.Controls.Add(groupBox1);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(dgvUsuariosBloqueados);
            panelPrincipal.Controls.Add(btnDesbloquearUsuario);
            panelPrincipal.Controls.Add(btnLogout);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1041, 451);
            panelPrincipal.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnAltaUsuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbSeleccionTipo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 234);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 156);
            label6.Name = "label6";
            label6.Size = new Size(77, 17);
            label6.TabIndex = 23;
            label6.Text = "Contraseña";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(86, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(195, 25);
            txtPassword.TabIndex = 22;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Anchor = AnchorStyles.Left;
            btnAltaUsuario.BackColor = Color.FromArgb(81, 86, 118);
            btnAltaUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnAltaUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnAltaUsuario.FlatStyle = FlatStyle.Flat;
            btnAltaUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltaUsuario.ForeColor = Color.White;
            btnAltaUsuario.Location = new Point(40, 190);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(189, 36);
            btnAltaUsuario.TabIndex = 21;
            btnAltaUsuario.Text = "Dar Alta";
            btnAltaUsuario.UseVisualStyleBackColor = false;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 125);
            label5.Name = "label5";
            label5.Size = new Size(36, 17);
            label5.TabIndex = 7;
            label5.Text = "Tipo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbSeleccionTipo
            // 
            cbSeleccionTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSeleccionTipo.FormattingEnabled = true;
            cbSeleccionTipo.Items.AddRange(new object[] { "Usuario", "Admin" });
            cbSeleccionTipo.Location = new Point(86, 122);
            cbSeleccionTipo.Name = "cbSeleccionTipo";
            cbSeleccionTipo.Size = new Size(195, 25);
            cbSeleccionTipo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 94);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 5;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 63);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 32);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "nombre@ejemplo.com";
            txtEmail.Size = new Size(193, 25);
            txtEmail.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(88, 60);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Garcia";
            txtApellido.Size = new Size(193, 25);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Juan";
            txtNombre.Size = new Size(193, 25);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(527, 4);
            label1.Name = "label1";
            label1.Size = new Size(286, 37);
            label1.TabIndex = 19;
            label1.Text = "Usuarios Bloqueados";
            // 
            // dgvUsuariosBloqueados
            // 
            dgvUsuariosBloqueados.AllowUserToAddRows = false;
            dgvUsuariosBloqueados.AllowUserToDeleteRows = false;
            dgvUsuariosBloqueados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuariosBloqueados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuariosBloqueados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuariosBloqueados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuariosBloqueados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuariosBloqueados.Location = new Point(346, 44);
            dgvUsuariosBloqueados.Name = "dgvUsuariosBloqueados";
            dgvUsuariosBloqueados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuariosBloqueados.Size = new Size(683, 392);
            dgvUsuariosBloqueados.TabIndex = 18;
            // 
            // btnDesbloquearUsuario
            // 
            btnDesbloquearUsuario.BackColor = Color.FromArgb(81, 86, 118);
            btnDesbloquearUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnDesbloquearUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnDesbloquearUsuario.FlatStyle = FlatStyle.Flat;
            btnDesbloquearUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesbloquearUsuario.ForeColor = Color.White;
            btnDesbloquearUsuario.Location = new Point(52, 252);
            btnDesbloquearUsuario.Name = "btnDesbloquearUsuario";
            btnDesbloquearUsuario.Size = new Size(189, 36);
            btnDesbloquearUsuario.TabIndex = 17;
            btnDesbloquearUsuario.Text = "Desbloquear Usuario";
            btnDesbloquearUsuario.UseVisualStyleBackColor = false;
            btnDesbloquearUsuario.Click += btnDesbloquearUsuario_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(81, 86, 118);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(52, 294);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(189, 36);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Cerrar";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 451);
            Controls.Add(panelPrincipal);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosBloqueados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label label1;
        private DataGridView dgvUsuariosBloqueados;
        private Button btnDesbloquearUsuario;
        private Button btnLogout;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnAltaUsuario;
        private Label label5;
        private ComboBox cbSeleccionTipo;
        private Label label6;
        private TextBox txtPassword;
    }
}