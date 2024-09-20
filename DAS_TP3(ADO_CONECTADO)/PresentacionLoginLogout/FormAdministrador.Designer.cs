namespace PresentacionLoginLogout
{
    partial class FormAdministrador
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
            panel1 = new Panel();
            label1 = new Label();
            dgvUsuariosBloqueados = new DataGridView();
            btnDesbloquearUsuario = new Button();
            groupBox1 = new GroupBox();
            lbNombreAdmin = new Label();
            lbEmailUsuario = new Label();
            btnLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosBloqueados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 127, 155);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvUsuariosBloqueados);
            panel1.Controls.Add(btnDesbloquearUsuario);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 118);
            label1.Name = "label1";
            label1.Size = new Size(286, 37);
            label1.TabIndex = 15;
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
            dgvUsuariosBloqueados.Location = new Point(207, 158);
            dgvUsuariosBloqueados.Name = "dgvUsuariosBloqueados";
            dgvUsuariosBloqueados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuariosBloqueados.Size = new Size(581, 280);
            dgvUsuariosBloqueados.TabIndex = 14;
            // 
            // btnDesbloquearUsuario
            // 
            btnDesbloquearUsuario.Anchor = AnchorStyles.Left;
            btnDesbloquearUsuario.BackColor = Color.FromArgb(22, 127, 155);
            btnDesbloquearUsuario.FlatStyle = FlatStyle.Flat;
            btnDesbloquearUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesbloquearUsuario.Location = new Point(12, 207);
            btnDesbloquearUsuario.Name = "btnDesbloquearUsuario";
            btnDesbloquearUsuario.Size = new Size(189, 36);
            btnDesbloquearUsuario.TabIndex = 13;
            btnDesbloquearUsuario.Text = "Desbloquear Usuario";
            btnDesbloquearUsuario.UseVisualStyleBackColor = false;
            btnDesbloquearUsuario.Click += btnDesbloquearUsuario_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbNombreAdmin);
            groupBox1.Controls.Add(lbEmailUsuario);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 117);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bienvenido";
            // 
            // lbNombreAdmin
            // 
            lbNombreAdmin.AutoSize = true;
            lbNombreAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbNombreAdmin.Location = new Point(6, 39);
            lbNombreAdmin.Name = "lbNombreAdmin";
            lbNombreAdmin.Size = new Size(184, 32);
            lbNombreAdmin.TabIndex = 5;
            lbNombreAdmin.Text = "NombreAdmin";
            // 
            // lbEmailUsuario
            // 
            lbEmailUsuario.AutoSize = true;
            lbEmailUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbEmailUsuario.Location = new Point(6, 76);
            lbEmailUsuario.Name = "lbEmailUsuario";
            lbEmailUsuario.Size = new Size(164, 32);
            lbEmailUsuario.TabIndex = 6;
            lbEmailUsuario.Text = "EmailUsuario";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(22, 127, 155);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(45, 249);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(124, 36);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            Load += FormAdministrador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosBloqueados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvUsuariosBloqueados;
        private Button btnDesbloquearUsuario;
        private GroupBox groupBox1;
        private Label lbNombreAdmin;
        private Label lbEmailUsuario;
        private Button btnLogout;
    }
}