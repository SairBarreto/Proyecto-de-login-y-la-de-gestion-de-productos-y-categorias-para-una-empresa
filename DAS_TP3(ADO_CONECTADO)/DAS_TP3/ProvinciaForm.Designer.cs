namespace DAS_TP3
{
    partial class ProvinciaForm
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
            dgvInfoProvincias = new DataGridView();
            btnModificarEnBD = new Button();
            btnBorrarEnBD = new Button();
            btnAgregarEnBD = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInfoProvincias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 21);
            label1.TabIndex = 6;
            label1.Text = "Información Provincias";
            // 
            // dgvInfoProvincias
            // 
            dgvInfoProvincias.AllowUserToAddRows = false;
            dgvInfoProvincias.AllowUserToDeleteRows = false;
            dgvInfoProvincias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInfoProvincias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInfoProvincias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInfoProvincias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInfoProvincias.Location = new Point(130, 33);
            dgvInfoProvincias.Name = "dgvInfoProvincias";
            dgvInfoProvincias.ReadOnly = true;
            dgvInfoProvincias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfoProvincias.Size = new Size(658, 150);
            dgvInfoProvincias.TabIndex = 5;
            // 
            // btnModificarEnBD
            // 
            btnModificarEnBD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarEnBD.Location = new Point(12, 105);
            btnModificarEnBD.Name = "btnModificarEnBD";
            btnModificarEnBD.Size = new Size(112, 30);
            btnModificarEnBD.TabIndex = 9;
            btnModificarEnBD.Text = "Modificar en BD";
            btnModificarEnBD.UseVisualStyleBackColor = true;
            btnModificarEnBD.Click += btnModificarEnBD_Click;
            // 
            // btnBorrarEnBD
            // 
            btnBorrarEnBD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarEnBD.Location = new Point(12, 69);
            btnBorrarEnBD.Name = "btnBorrarEnBD";
            btnBorrarEnBD.Size = new Size(112, 30);
            btnBorrarEnBD.TabIndex = 8;
            btnBorrarEnBD.Text = "Borrar en BD";
            btnBorrarEnBD.UseVisualStyleBackColor = true;
            btnBorrarEnBD.Click += btnBorrarEnBD_Click;
            // 
            // btnAgregarEnBD
            // 
            btnAgregarEnBD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEnBD.Location = new Point(12, 33);
            btnAgregarEnBD.Name = "btnAgregarEnBD";
            btnAgregarEnBD.Size = new Size(112, 30);
            btnAgregarEnBD.TabIndex = 7;
            btnAgregarEnBD.Text = "Agregar en BD";
            btnAgregarEnBD.UseVisualStyleBackColor = true;
            btnAgregarEnBD.Click += btnAgregarEnBD_Click;
            // 
            // ProvinciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarEnBD);
            Controls.Add(btnBorrarEnBD);
            Controls.Add(btnAgregarEnBD);
            Controls.Add(label1);
            Controls.Add(dgvInfoProvincias);
            Name = "ProvinciaForm";
            Text = "ProvinciaForm";
            FormClosed += ProvinciaForm_FormClosed;
            Load += ProvinciaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInfoProvincias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvInfoProvincias;
        private Button btnModificarEnBD;
        private Button btnBorrarEnBD;
        private Button btnAgregarEnBD;
    }
}