namespace DAS_TP3
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            sociosToolStripMenuItem = new ToolStripMenuItem();
            paisToolStripMenuItem = new ToolStripMenuItem();
            provinciaToolStripMenuItem = new ToolStripMenuItem();
            btnConectarBD = new Button();
            btnDesconectarBD = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sociosToolStripMenuItem, paisToolStripMenuItem, provinciaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            sociosToolStripMenuItem.Size = new Size(53, 20);
            sociosToolStripMenuItem.Text = "Socios";
            sociosToolStripMenuItem.Click += sociosToolStripMenuItem_Click;
            // 
            // paisToolStripMenuItem
            // 
            paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            paisToolStripMenuItem.Size = new Size(40, 20);
            paisToolStripMenuItem.Text = "Pais";
            paisToolStripMenuItem.Click += paisToolStripMenuItem_Click;
            // 
            // provinciaToolStripMenuItem
            // 
            provinciaToolStripMenuItem.Name = "provinciaToolStripMenuItem";
            provinciaToolStripMenuItem.Size = new Size(68, 20);
            provinciaToolStripMenuItem.Text = "Provincia";
            provinciaToolStripMenuItem.Click += provinciaToolStripMenuItem_Click;
            // 
            // btnConectarBD
            // 
            btnConectarBD.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConectarBD.Location = new Point(12, 46);
            btnConectarBD.Name = "btnConectarBD";
            btnConectarBD.Size = new Size(151, 36);
            btnConectarBD.TabIndex = 3;
            btnConectarBD.Text = "Conectar a la BD";
            btnConectarBD.UseVisualStyleBackColor = true;
            btnConectarBD.Click += btnConectarBD_Click;
            // 
            // btnDesconectarBD
            // 
            btnDesconectarBD.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesconectarBD.Location = new Point(12, 97);
            btnDesconectarBD.Name = "btnDesconectarBD";
            btnDesconectarBD.Size = new Size(151, 36);
            btnDesconectarBD.TabIndex = 4;
            btnDesconectarBD.Text = "Desconectar de la BD";
            btnDesconectarBD.UseVisualStyleBackColor = true;
            btnDesconectarBD.Click += btnDesconectarBD_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDesconectarBD);
            Controls.Add(btnConectarBD);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sociosToolStripMenuItem;
        private ToolStripMenuItem paisToolStripMenuItem;
        private ToolStripMenuItem provinciaToolStripMenuItem;
        private Button btnConectarBD;
        private Button btnDesconectarBD;
    }
}