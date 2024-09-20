namespace DAS_TP3
{
    partial class PaisForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgregarEnBD = new Button();
            btnBorrarEnBD = new Button();
            btnModificarEnBD = new Button();
            dgvInfoPaises = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInfoPaises).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarEnBD
            // 
            btnAgregarEnBD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEnBD.Location = new Point(12, 48);
            btnAgregarEnBD.Name = "btnAgregarEnBD";
            btnAgregarEnBD.Size = new Size(112, 30);
            btnAgregarEnBD.TabIndex = 0;
            btnAgregarEnBD.Text = "Agregar en BD";
            btnAgregarEnBD.UseVisualStyleBackColor = true;
            btnAgregarEnBD.Click += btnAgregarEnBD_Click;
            // 
            // btnBorrarEnBD
            // 
            btnBorrarEnBD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarEnBD.Location = new Point(12, 84);
            btnBorrarEnBD.Name = "btnBorrarEnBD";
            btnBorrarEnBD.Size = new Size(112, 30);
            btnBorrarEnBD.TabIndex = 1;
            btnBorrarEnBD.Text = "Borrar en BD";
            btnBorrarEnBD.UseVisualStyleBackColor = true;
            btnBorrarEnBD.Click += btnBorrarEnBD_Click;
            // 
            // btnModificarEnBD
            // 
            btnModificarEnBD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarEnBD.Location = new Point(12, 120);
            btnModificarEnBD.Name = "btnModificarEnBD";
            btnModificarEnBD.Size = new Size(112, 30);
            btnModificarEnBD.TabIndex = 2;
            btnModificarEnBD.Text = "Modificar en BD";
            btnModificarEnBD.UseVisualStyleBackColor = true;
            btnModificarEnBD.Click += btnModificarEnBD_Click;
            // 
            // dgvInfoPaises
            // 
            dgvInfoPaises.AllowUserToAddRows = false;
            dgvInfoPaises.AllowUserToDeleteRows = false;
            dgvInfoPaises.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInfoPaises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInfoPaises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInfoPaises.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInfoPaises.Location = new Point(130, 48);
            dgvInfoPaises.Name = "dgvInfoPaises";
            dgvInfoPaises.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInfoPaises.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInfoPaises.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfoPaises.Size = new Size(658, 150);
            dgvInfoPaises.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 24);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 4;
            label1.Text = "Información Paises";
            // 
            // PaisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 351);
            Controls.Add(label1);
            Controls.Add(dgvInfoPaises);
            Controls.Add(btnModificarEnBD);
            Controls.Add(btnBorrarEnBD);
            Controls.Add(btnAgregarEnBD);
            Name = "PaisForm";
            Text = "Form1";
            FormClosed += PaisForm_FormClosed;
            Load += PaisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInfoPaises).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarEnBD;
        private Button btnBorrarEnBD;
        private Button btnModificarEnBD;
        private DataGridView dgvInfoPaises;
        private Label label1;
    }
}