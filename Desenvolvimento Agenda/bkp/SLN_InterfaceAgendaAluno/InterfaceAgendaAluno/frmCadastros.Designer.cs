namespace InterfaceAgendaAluno
{
    partial class frmCadastros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeDeConexãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeDeConexãoToolStripMenuItem,
            this.unidadeToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.aulaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeDeConexãoToolStripMenuItem
            // 
            this.testeDeConexãoToolStripMenuItem.Name = "testeDeConexãoToolStripMenuItem";
            this.testeDeConexãoToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.testeDeConexãoToolStripMenuItem.Text = "Teste de Conexão";
            this.testeDeConexãoToolStripMenuItem.Click += new System.EventHandler(this.testeDeConexãoToolStripMenuItem_Click);
            // 
            // unidadeToolStripMenuItem
            // 
            this.unidadeToolStripMenuItem.Name = "unidadeToolStripMenuItem";
            this.unidadeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.unidadeToolStripMenuItem.Text = "Unidade";
            this.unidadeToolStripMenuItem.Click += new System.EventHandler(this.unidadeToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.turmaToolStripMenuItem.Text = " Turma e Curso";
            this.turmaToolStripMenuItem.Click += new System.EventHandler(this.turmaToolStripMenuItem_Click);
            // 
            // aulaToolStripMenuItem
            // 
            this.aulaToolStripMenuItem.Name = "aulaToolStripMenuItem";
            this.aulaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aulaToolStripMenuItem.Text = "Aula";
            this.aulaToolStripMenuItem.Click += new System.EventHandler(this.aulaToolStripMenuItem_Click);
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 269);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastros";
            this.Text = "Cadastros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeDeConexãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulaToolStripMenuItem;
    }
}