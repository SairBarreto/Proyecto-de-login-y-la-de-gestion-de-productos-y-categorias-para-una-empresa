namespace PresentacionAdministradorDeProductos
{
    partial class FormRegistros
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
            btnSalir = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            dgvRegistrosLog = new DataGridView();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrosLog).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(81, 86, 118);
            panelPrincipal.Controls.Add(btnSalir);
            panelPrincipal.Controls.Add(btnActualizar);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(dgvRegistrosLog);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(823, 275);
            panelPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(429, 215);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 43);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 86, 118);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 43, 98);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(310, 215);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 43);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 16);
            label1.Name = "label1";
            label1.Size = new Size(355, 40);
            label1.TabIndex = 5;
            label1.Text = "Operaciones Registradas";
            // 
            // dgvRegistrosLog
            // 
            dgvRegistrosLog.AllowUserToAddRows = false;
            dgvRegistrosLog.AllowUserToDeleteRows = false;
            dgvRegistrosLog.AllowUserToResizeColumns = false;
            dgvRegistrosLog.AllowUserToResizeRows = false;
            dgvRegistrosLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistrosLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistrosLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistrosLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistrosLog.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistrosLog.Location = new Point(12, 59);
            dgvRegistrosLog.Name = "dgvRegistrosLog";
            dgvRegistrosLog.ReadOnly = true;
            dgvRegistrosLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistrosLog.Size = new Size(799, 150);
            dgvRegistrosLog.TabIndex = 4;
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 275);
            Controls.Add(panelPrincipal);
            MinimumSize = new Size(839, 314);
            Name = "FormRegistros";
            Text = "FormRegistros";
            Load += FormRegistros_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrosLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button btnSalir;
        private Button btnActualizar;
        private Label label1;
        private DataGridView dgvRegistrosLog;
    }
}