namespace PresentacionAdministradorDeProductos
{
    partial class FormPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelPrincipal = new Panel();
            btnUsuariosBloqueados = new Button();
            btnVerOperaciones = new Button();
            btnLogout = new Button();
            lbCategoria = new Label();
            dgvCategorias = new DataGridView();
            lbProducto = new Label();
            dgvProductos = new DataGridView();
            gbCategoria = new GroupBox();
            btnModificarCategoria = new Button();
            btnBorrarCategoria = new Button();
            btnAgregarCategoria = new Button();
            gbProducto = new GroupBox();
            btnModificarProducto = new Button();
            btnBorrarProducto = new Button();
            btnAgregarProducto = new Button();
            gbDatosUsuario = new GroupBox();
            lbEmailUsuario = new Label();
            lbNombreUsuario = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gbCategoria.SuspendLayout();
            gbProducto.SuspendLayout();
            gbDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(81, 86, 118);
            panelPrincipal.Controls.Add(btnUsuariosBloqueados);
            panelPrincipal.Controls.Add(btnVerOperaciones);
            panelPrincipal.Controls.Add(btnLogout);
            panelPrincipal.Controls.Add(lbCategoria);
            panelPrincipal.Controls.Add(dgvCategorias);
            panelPrincipal.Controls.Add(lbProducto);
            panelPrincipal.Controls.Add(dgvProductos);
            panelPrincipal.Controls.Add(gbCategoria);
            panelPrincipal.Controls.Add(gbProducto);
            panelPrincipal.Controls.Add(gbDatosUsuario);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(630, 559);
            panelPrincipal.TabIndex = 0;
            // 
            // btnUsuariosBloqueados
            // 
            btnUsuariosBloqueados.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUsuariosBloqueados.BackColor = Color.FromArgb(81, 86, 118);
            btnUsuariosBloqueados.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnUsuariosBloqueados.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnUsuariosBloqueados.FlatStyle = FlatStyle.Flat;
            btnUsuariosBloqueados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuariosBloqueados.ForeColor = Color.White;
            btnUsuariosBloqueados.Location = new Point(436, 434);
            btnUsuariosBloqueados.Name = "btnUsuariosBloqueados";
            btnUsuariosBloqueados.Size = new Size(181, 30);
            btnUsuariosBloqueados.TabIndex = 19;
            btnUsuariosBloqueados.Text = "Usuarios Bloqueados";
            btnUsuariosBloqueados.UseVisualStyleBackColor = false;
            btnUsuariosBloqueados.Click += btnUsuariosBloqueados_Click;
            // 
            // btnVerOperaciones
            // 
            btnVerOperaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerOperaciones.BackColor = Color.FromArgb(81, 86, 118);
            btnVerOperaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnVerOperaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnVerOperaciones.FlatStyle = FlatStyle.Flat;
            btnVerOperaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerOperaciones.ForeColor = Color.White;
            btnVerOperaciones.Location = new Point(436, 470);
            btnVerOperaciones.Name = "btnVerOperaciones";
            btnVerOperaciones.Size = new Size(181, 30);
            btnVerOperaciones.TabIndex = 18;
            btnVerOperaciones.Text = "Ver Operaciones";
            btnVerOperaciones.UseVisualStyleBackColor = false;
            btnVerOperaciones.Click += btnVerOperaciones_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(81, 86, 118);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(436, 506);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 30);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbCategoria
            // 
            lbCategoria.Anchor = AnchorStyles.Bottom;
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCategoria.ForeColor = Color.White;
            lbCategoria.Location = new Point(117, 334);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(106, 25);
            lbCategoria.TabIndex = 17;
            lbCategoria.Text = "Categorias";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeColumns = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.Location = new Point(14, 362);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(312, 181);
            dgvCategorias.TabIndex = 16;
            // 
            // lbProducto
            // 
            lbProducto.Anchor = AnchorStyles.Top;
            lbProducto.AutoSize = true;
            lbProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProducto.ForeColor = Color.White;
            lbProducto.Location = new Point(240, 129);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(104, 25);
            lbProducto.TabIndex = 15;
            lbProducto.Text = "Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.Location = new Point(14, 157);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(507, 163);
            dgvProductos.TabIndex = 14;
            // 
            // gbCategoria
            // 
            gbCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gbCategoria.Controls.Add(btnModificarCategoria);
            gbCategoria.Controls.Add(btnBorrarCategoria);
            gbCategoria.Controls.Add(btnAgregarCategoria);
            gbCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCategoria.ForeColor = Color.White;
            gbCategoria.Location = new Point(332, 365);
            gbCategoria.Name = "gbCategoria";
            gbCategoria.Size = new Size(91, 134);
            gbCategoria.TabIndex = 13;
            gbCategoria.TabStop = false;
            gbCategoria.Text = "Categoria";
            // 
            // btnModificarCategoria
            // 
            btnModificarCategoria.BackColor = Color.FromArgb(81, 86, 118);
            btnModificarCategoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnModificarCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnModificarCategoria.FlatStyle = FlatStyle.Flat;
            btnModificarCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarCategoria.Location = new Point(6, 96);
            btnModificarCategoria.Name = "btnModificarCategoria";
            btnModificarCategoria.Size = new Size(78, 30);
            btnModificarCategoria.TabIndex = 3;
            btnModificarCategoria.Text = "Modificar";
            btnModificarCategoria.UseVisualStyleBackColor = false;
            btnModificarCategoria.Click += btnModificarCategoria_Click;
            // 
            // btnBorrarCategoria
            // 
            btnBorrarCategoria.BackColor = Color.FromArgb(81, 86, 118);
            btnBorrarCategoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnBorrarCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnBorrarCategoria.FlatStyle = FlatStyle.Flat;
            btnBorrarCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarCategoria.Location = new Point(6, 60);
            btnBorrarCategoria.Name = "btnBorrarCategoria";
            btnBorrarCategoria.Size = new Size(78, 30);
            btnBorrarCategoria.TabIndex = 2;
            btnBorrarCategoria.Text = "Borrar";
            btnBorrarCategoria.UseVisualStyleBackColor = false;
            btnBorrarCategoria.Click += btnBorrarCategoria_Click;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.BackColor = Color.FromArgb(81, 86, 118);
            btnAgregarCategoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnAgregarCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnAgregarCategoria.FlatStyle = FlatStyle.Flat;
            btnAgregarCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCategoria.Location = new Point(6, 24);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(78, 30);
            btnAgregarCategoria.TabIndex = 1;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = false;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // gbProducto
            // 
            gbProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbProducto.Controls.Add(btnModificarProducto);
            gbProducto.Controls.Add(btnBorrarProducto);
            gbProducto.Controls.Add(btnAgregarProducto);
            gbProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProducto.ForeColor = Color.White;
            gbProducto.Location = new Point(526, 157);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(91, 134);
            gbProducto.TabIndex = 11;
            gbProducto.TabStop = false;
            gbProducto.Text = "Producto";
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.FromArgb(81, 86, 118);
            btnModificarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnModificarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnModificarProducto.FlatStyle = FlatStyle.Flat;
            btnModificarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarProducto.Location = new Point(6, 96);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(78, 30);
            btnModificarProducto.TabIndex = 3;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.BackColor = Color.FromArgb(81, 86, 118);
            btnBorrarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnBorrarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnBorrarProducto.FlatStyle = FlatStyle.Flat;
            btnBorrarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarProducto.Location = new Point(6, 60);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(78, 30);
            btnBorrarProducto.TabIndex = 2;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.UseVisualStyleBackColor = false;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(81, 86, 118);
            btnAgregarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnAgregarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.Location = new Point(6, 24);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(78, 30);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // gbDatosUsuario
            // 
            gbDatosUsuario.Controls.Add(lbEmailUsuario);
            gbDatosUsuario.Controls.Add(lbNombreUsuario);
            gbDatosUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDatosUsuario.ForeColor = Color.White;
            gbDatosUsuario.Location = new Point(14, 16);
            gbDatosUsuario.Name = "gbDatosUsuario";
            gbDatosUsuario.Size = new Size(245, 100);
            gbDatosUsuario.TabIndex = 10;
            gbDatosUsuario.TabStop = false;
            gbDatosUsuario.Text = "Datos de Usuario";
            // 
            // lbEmailUsuario
            // 
            lbEmailUsuario.AutoSize = true;
            lbEmailUsuario.Location = new Point(6, 66);
            lbEmailUsuario.Name = "lbEmailUsuario";
            lbEmailUsuario.Size = new Size(112, 21);
            lbEmailUsuario.TabIndex = 1;
            lbEmailUsuario.Text = "EmailUsuario";
            // 
            // lbNombreUsuario
            // 
            lbNombreUsuario.AutoSize = true;
            lbNombreUsuario.Location = new Point(6, 34);
            lbNombreUsuario.Name = "lbNombreUsuario";
            lbNombreUsuario.Size = new Size(132, 21);
            lbNombreUsuario.TabIndex = 0;
            lbNombreUsuario.Text = "NombreUsuario";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 559);
            Controls.Add(panelPrincipal);
            MinimumSize = new Size(646, 598);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gbCategoria.ResumeLayout(false);
            gbProducto.ResumeLayout(false);
            gbDatosUsuario.ResumeLayout(false);
            gbDatosUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button btnVerOperaciones;
        private Button btnLogout;
        private Label lbCategoria;
        private DataGridView dgvCategorias;
        private Label lbProducto;
        private DataGridView dgvProductos;
        private GroupBox gbCategoria;
        private Button btnModificarCategoria;
        private Button btnBorrarCategoria;
        private Button btnAgregarCategoria;
        private GroupBox gbProducto;
        private Button btnModificarProducto;
        private Button btnBorrarProducto;
        private Button btnAgregarProducto;
        private GroupBox gbDatosUsuario;
        private Label lbEmailUsuario;
        private Label lbNombreUsuario;
        private Button btnUsuariosBloqueados;
    }
}
