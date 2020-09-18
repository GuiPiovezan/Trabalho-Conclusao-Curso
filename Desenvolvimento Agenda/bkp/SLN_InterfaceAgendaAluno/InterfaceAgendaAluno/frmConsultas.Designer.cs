namespace InterfaceAgendaAluno
{
    partial class frmConsultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.rdbTurma = new System.Windows.Forms.RadioButton();
            this.rdbCurso = new System.Windows.Forms.RadioButton();
            this.rdbAulas = new System.Windows.Forms.RadioButton();
            this.dataConsultas = new System.Windows.Forms.DataGridView();
            this.grpConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE A OPÇÃO QUE DESEJA REALIZAR A CONSULTA";
            // 
            // grpConsultas
            // 
            this.grpConsultas.Controls.Add(this.rdbTurma);
            this.grpConsultas.Controls.Add(this.rdbCurso);
            this.grpConsultas.Controls.Add(this.rdbAulas);
            this.grpConsultas.Location = new System.Drawing.Point(479, 9);
            this.grpConsultas.Name = "grpConsultas";
            this.grpConsultas.Size = new System.Drawing.Size(309, 41);
            this.grpConsultas.TabIndex = 1;
            this.grpConsultas.TabStop = false;
            this.grpConsultas.Text = "OPÇÕES";
            // 
            // rdbTurma
            // 
            this.rdbTurma.AutoSize = true;
            this.rdbTurma.Location = new System.Drawing.Point(174, 15);
            this.rdbTurma.Name = "rdbTurma";
            this.rdbTurma.Size = new System.Drawing.Size(71, 17);
            this.rdbTurma.TabIndex = 2;
            this.rdbTurma.TabStop = true;
            this.rdbTurma.Text = "TURMAS";
            this.rdbTurma.UseVisualStyleBackColor = true;
            this.rdbTurma.CheckedChanged += new System.EventHandler(this.rdbTurma_CheckedChanged);
            // 
            // rdbCurso
            // 
            this.rdbCurso.AutoSize = true;
            this.rdbCurso.Location = new System.Drawing.Point(85, 15);
            this.rdbCurso.Name = "rdbCurso";
            this.rdbCurso.Size = new System.Drawing.Size(70, 17);
            this.rdbCurso.TabIndex = 1;
            this.rdbCurso.TabStop = true;
            this.rdbCurso.Text = "CURSOS";
            this.rdbCurso.UseVisualStyleBackColor = true;
            this.rdbCurso.CheckedChanged += new System.EventHandler(this.rdbCurso_CheckedChanged);
            // 
            // rdbAulas
            // 
            this.rdbAulas.AutoSize = true;
            this.rdbAulas.Location = new System.Drawing.Point(6, 15);
            this.rdbAulas.Name = "rdbAulas";
            this.rdbAulas.Size = new System.Drawing.Size(60, 17);
            this.rdbAulas.TabIndex = 0;
            this.rdbAulas.TabStop = true;
            this.rdbAulas.Text = "AULAS";
            this.rdbAulas.UseVisualStyleBackColor = true;
            this.rdbAulas.CheckedChanged += new System.EventHandler(this.rdbAulas_CheckedChanged);
            // 
            // dataConsultas
            // 
            this.dataConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultas.Location = new System.Drawing.Point(80, 70);
            this.dataConsultas.Name = "dataConsultas";
            this.dataConsultas.Size = new System.Drawing.Size(644, 233);
            this.dataConsultas.TabIndex = 2;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.dataConsultas);
            this.Controls.Add(this.grpConsultas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.Text = "CONSULTAS";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.grpConsultas.ResumeLayout(false);
            this.grpConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpConsultas;
        private System.Windows.Forms.RadioButton rdbTurma;
        private System.Windows.Forms.RadioButton rdbCurso;
        private System.Windows.Forms.RadioButton rdbAulas;
        private System.Windows.Forms.DataGridView dataConsultas;
    }
}