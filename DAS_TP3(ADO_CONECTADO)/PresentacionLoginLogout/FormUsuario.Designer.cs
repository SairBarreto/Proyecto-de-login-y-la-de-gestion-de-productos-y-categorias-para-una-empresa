namespace PresentacionLoginLogout
{
    partial class FormUsuario
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
            panel1 = new Panel();
            lbEmailUsuario = new Label();
            lbBienvidenido = new Label();
            btnLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 127, 155);
            panel1.Controls.Add(lbEmailUsuario);
            panel1.Controls.Add(lbBienvidenido);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // lbEmailUsuario
            // 
            lbEmailUsuario.Anchor = AnchorStyles.None;
            lbEmailUsuario.AutoSize = true;
            lbEmailUsuario.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmailUsuario.Location = new Point(219, 205);
            lbEmailUsuario.Name = "lbEmailUsuario";
            lbEmailUsuario.Size = new Size(235, 47);
            lbEmailUsuario.TabIndex = 6;
            lbEmailUsuario.Text = "EmailUsuario";
            // 
            // lbBienvidenido
            // 
            lbBienvidenido.Anchor = AnchorStyles.None;
            lbBienvidenido.AutoSize = true;
            lbBienvidenido.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBienvidenido.Location = new Point(46, 119);
            lbBienvidenido.Name = "lbBienvidenido";
            lbBienvidenido.Size = new Size(375, 86);
            lbBienvidenido.TabIndex = 5;
            lbBienvidenido.Text = "Bienvenido";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(22, 127, 155);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(46, 378);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(124, 36);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbEmailUsuario;
        private Label lbBienvidenido;
        private Button btnLogout;
    }
}