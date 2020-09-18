namespace InterfaceAgendaAluno
{
    partial class frmInterfacePrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterfacePrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTEDECONEXÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tURMASECURSOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aULASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tURMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISCIPLINASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURAÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERFILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTEDECONEXÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tURMASECURSOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aULASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROSToolStripMenuItem,
            this.cONFIGURAÇÕESToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(811, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTEDECONEXÃOToolStripMenuItem1,
            this.uNIDADEToolStripMenuItem1,
            this.tURMASECURSOSToolStripMenuItem1,
            this.aULASToolStripMenuItem1,
            this.tURMASToolStripMenuItem,
            this.dISCIPLINASToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS";
            // 
            // tESTEDECONEXÃOToolStripMenuItem1
            // 
            this.tESTEDECONEXÃOToolStripMenuItem1.Name = "tESTEDECONEXÃOToolStripMenuItem1";
            this.tESTEDECONEXÃOToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.tESTEDECONEXÃOToolStripMenuItem1.Text = "TESTE DE CONEXÃO";
            this.tESTEDECONEXÃOToolStripMenuItem1.Click += new System.EventHandler(this.tESTEDECONEXÃOToolStripMenuItem1_Click);
            // 
            // uNIDADEToolStripMenuItem1
            // 
            this.uNIDADEToolStripMenuItem1.Name = "uNIDADEToolStripMenuItem1";
            this.uNIDADEToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.uNIDADEToolStripMenuItem1.Text = "UNIDADE";
            this.uNIDADEToolStripMenuItem1.Click += new System.EventHandler(this.uNIDADEToolStripMenuItem1_Click);
            // 
            // tURMASECURSOSToolStripMenuItem1
            // 
            this.tURMASECURSOSToolStripMenuItem1.Name = "tURMASECURSOSToolStripMenuItem1";
            this.tURMASECURSOSToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.tURMASECURSOSToolStripMenuItem1.Text = "CURSOS";
            this.tURMASECURSOSToolStripMenuItem1.Click += new System.EventHandler(this.tURMASECURSOSToolStripMenuItem1_Click);
            // 
            // aULASToolStripMenuItem1
            // 
            this.aULASToolStripMenuItem1.Name = "aULASToolStripMenuItem1";
            this.aULASToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.aULASToolStripMenuItem1.Text = "AULAS";
            this.aULASToolStripMenuItem1.Click += new System.EventHandler(this.aULASToolStripMenuItem1_Click);
            // 
            // tURMASToolStripMenuItem
            // 
            this.tURMASToolStripMenuItem.Name = "tURMASToolStripMenuItem";
            this.tURMASToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tURMASToolStripMenuItem.Text = "TURMAS";
            this.tURMASToolStripMenuItem.Click += new System.EventHandler(this.tURMASToolStripMenuItem_Click);
            // 
            // dISCIPLINASToolStripMenuItem
            // 
            this.dISCIPLINASToolStripMenuItem.Name = "dISCIPLINASToolStripMenuItem";
            this.dISCIPLINASToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dISCIPLINASToolStripMenuItem.Text = "DISCIPLINAS";
            this.dISCIPLINASToolStripMenuItem.Click += new System.EventHandler(this.dISCIPLINASToolStripMenuItem_Click);
            // 
            // cONFIGURAÇÕESToolStripMenuItem
            // 
            this.cONFIGURAÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERFILToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.cONFIGURAÇÕESToolStripMenuItem.Name = "cONFIGURAÇÕESToolStripMenuItem";
            this.cONFIGURAÇÕESToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.cONFIGURAÇÕESToolStripMenuItem.Text = "CONFIGURAÇÕES";
            // 
            // pERFILToolStripMenuItem
            // 
            this.pERFILToolStripMenuItem.Name = "pERFILToolStripMenuItem";
            this.pERFILToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.pERFILToolStripMenuItem.Text = "PERFIL";
            this.pERFILToolStripMenuItem.Click += new System.EventHandler(this.pERFILToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // tESTEDECONEXÃOToolStripMenuItem
            // 
            this.tESTEDECONEXÃOToolStripMenuItem.Name = "tESTEDECONEXÃOToolStripMenuItem";
            this.tESTEDECONEXÃOToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tESTEDECONEXÃOToolStripMenuItem.Text = "TESTE DE CONEXÃO";
            // 
            // tURMASECURSOSToolStripMenuItem
            // 
            this.tURMASECURSOSToolStripMenuItem.Name = "tURMASECURSOSToolStripMenuItem";
            this.tURMASECURSOSToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tURMASECURSOSToolStripMenuItem.Text = "TURMAS E CURSOS";
            // 
            // aULASToolStripMenuItem
            // 
            this.aULASToolStripMenuItem.Name = "aULASToolStripMenuItem";
            this.aULASToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aULASToolStripMenuItem.Text = "AULAS";
            // 
            // uNIDADEToolStripMenuItem
            // 
            this.uNIDADEToolStripMenuItem.Name = "uNIDADEToolStripMenuItem";
            this.uNIDADEToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.uNIDADEToolStripMenuItem.Text = "UNIDADE";
            // 
            // frmInterfacePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceAgendaAluno.Properties.Resources.backgroudAgendaDesktop;
            this.ClientSize = new System.Drawing.Size(811, 469);
            this.ControlBox = false;
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInterfacePrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Principal - Agenda Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInterfacePrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURAÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERFILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTEDECONEXÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNIDADEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tURMASECURSOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aULASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTEDECONEXÃOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uNIDADEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tURMASECURSOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aULASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tURMASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISCIPLINASToolStripMenuItem;
    }
}

