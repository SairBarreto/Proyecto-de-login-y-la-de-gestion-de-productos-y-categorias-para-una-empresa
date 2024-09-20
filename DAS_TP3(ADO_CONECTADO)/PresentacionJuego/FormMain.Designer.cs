namespace PresentacionJuego
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            bandoToolStripMenuItem = new ToolStripMenuItem();
            jugadoresToolStripMenuItem = new ToolStripMenuItem();
            juegoToolStripMenuItem = new ToolStripMenuItem();
            juegoBandoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { bandoToolStripMenuItem, jugadoresToolStripMenuItem, juegoToolStripMenuItem, juegoBandoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // bandoToolStripMenuItem
            // 
            bandoToolStripMenuItem.Name = "bandoToolStripMenuItem";
            bandoToolStripMenuItem.Size = new Size(53, 20);
            bandoToolStripMenuItem.Text = "Bando";
            bandoToolStripMenuItem.Click += bandoToolStripMenuItem_Click;
            // 
            // jugadoresToolStripMenuItem
            // 
            jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            jugadoresToolStripMenuItem.Size = new Size(72, 20);
            jugadoresToolStripMenuItem.Text = "Jugadores";
            jugadoresToolStripMenuItem.Click += jugadoresToolStripMenuItem_Click;
            // 
            // juegoToolStripMenuItem
            // 
            juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            juegoToolStripMenuItem.Size = new Size(50, 20);
            juegoToolStripMenuItem.Text = "Juego";
            juegoToolStripMenuItem.Click += juegoToolStripMenuItem_Click;
            // 
            // juegoBandoToolStripMenuItem
            // 
            juegoBandoToolStripMenuItem.Name = "juegoBandoToolStripMenuItem";
            juegoBandoToolStripMenuItem.Size = new Size(89, 20);
            juegoBandoToolStripMenuItem.Text = "Juego_Bando";
            juegoBandoToolStripMenuItem.Click += juegoBandoToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "FormMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bandoToolStripMenuItem;
        private ToolStripMenuItem jugadoresToolStripMenuItem;
        private ToolStripMenuItem juegoToolStripMenuItem;
        private ToolStripMenuItem juegoBandoToolStripMenuItem;
    }
}
