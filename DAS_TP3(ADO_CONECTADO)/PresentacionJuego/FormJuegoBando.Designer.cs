namespace PresentacionJuego
{
    partial class FormJuegoBando
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnAgregar = new Button();
            dgvJuegosBandos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegosBandos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 7;
            label1.Text = "Juegos Bandos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(453, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(132, 143);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Juego Bandos";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(6, 104);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 32);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(6, 66);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(120, 32);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 28);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 32);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvJuegosBandos
            // 
            dgvJuegosBandos.AllowUserToAddRows = false;
            dgvJuegosBandos.AllowUserToDeleteRows = false;
            dgvJuegosBandos.AllowUserToResizeColumns = false;
            dgvJuegosBandos.AllowUserToResizeRows = false;
            dgvJuegosBandos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJuegosBandos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJuegosBandos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvJuegosBandos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvJuegosBandos.Location = new Point(12, 45);
            dgvJuegosBandos.Name = "dgvJuegosBandos";
            dgvJuegosBandos.ReadOnly = true;
            dgvJuegosBandos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJuegosBandos.Size = new Size(418, 248);
            dgvJuegosBandos.TabIndex = 5;
            // 
            // FormJuegoBando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 310);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvJuegosBandos);
            Name = "FormJuegoBando";
            Text = "FormJuegoBando";
            Load += FormJuegoBando_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJuegosBandos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnAgregar;
        private DataGridView dgvJuegosBandos;
    }
}