namespace InterfaceAgendaAluno
{
    partial class frmAlteracoes
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
            this.rdbCurso = new System.Windows.Forms.RadioButton();
            this.grbConsultaTabela = new System.Windows.Forms.GroupBox();
            this.rdbAula = new System.Windows.Forms.RadioButton();
            this.rdbTurma = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtDataAula = new System.Windows.Forms.MaskedTextBox();
            this.cmbPeriodoCurso = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtLocalAula = new System.Windows.Forms.TextBox();
            this.txtCoordenador = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoCurso = new System.Windows.Forms.ComboBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbAnoCurso = new System.Windows.Forms.ComboBox();
            this.pctSetaDireita = new System.Windows.Forms.PictureBox();
            this.pctSetaEsquerda = new System.Windows.Forms.PictureBox();
            this.grbConsultaTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSetaDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSetaEsquerda)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbCurso
            // 
            this.rdbCurso.AutoSize = true;
            this.rdbCurso.Location = new System.Drawing.Point(6, 28);
            this.rdbCurso.Name = "rdbCurso";
            this.rdbCurso.Size = new System.Drawing.Size(63, 17);
            this.rdbCurso.TabIndex = 0;
            this.rdbCurso.TabStop = true;
            this.rdbCurso.Text = "CURSO";
            this.rdbCurso.UseVisualStyleBackColor = true;
            this.rdbCurso.CheckedChanged += new System.EventHandler(this.rdbCurso_CheckedChanged);
            // 
            // grbConsultaTabela
            // 
            this.grbConsultaTabela.Controls.Add(this.rdbAula);
            this.grbConsultaTabela.Controls.Add(this.rdbTurma);
            this.grbConsultaTabela.Controls.Add(this.rdbCurso);
            this.grbConsultaTabela.Location = new System.Drawing.Point(12, 12);
            this.grbConsultaTabela.Name = "grbConsultaTabela";
            this.grbConsultaTabela.Size = new System.Drawing.Size(92, 108);
            this.grbConsultaTabela.TabIndex = 1;
            this.grbConsultaTabela.TabStop = false;
            this.grbConsultaTabela.Text = "TABELAS ";
            // 
            // rdbAula
            // 
            this.rdbAula.AutoSize = true;
            this.rdbAula.Location = new System.Drawing.Point(6, 74);
            this.rdbAula.Name = "rdbAula";
            this.rdbAula.Size = new System.Drawing.Size(53, 17);
            this.rdbAula.TabIndex = 2;
            this.rdbAula.TabStop = true;
            this.rdbAula.Text = "AULA";
            this.rdbAula.UseVisualStyleBackColor = true;
            this.rdbAula.CheckedChanged += new System.EventHandler(this.rdbAula_CheckedChanged);
            // 
            // rdbTurma
            // 
            this.rdbTurma.AutoSize = true;
            this.rdbTurma.Location = new System.Drawing.Point(6, 51);
            this.rdbTurma.Name = "rdbTurma";
            this.rdbTurma.Size = new System.Drawing.Size(64, 17);
            this.rdbTurma.TabIndex = 1;
            this.rdbTurma.TabStop = true;
            this.rdbTurma.Text = "TURMA";
            this.rdbTurma.UseVisualStyleBackColor = true;
            this.rdbTurma.CheckedChanged += new System.EventHandler(this.rdbTurma_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(144, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(286, 23);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "lbl1";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(144, 40);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(112, 23);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "DESCRIÇÃO";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(144, 80);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(137, 23);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "lbl3";
            // 
            // txtDataAula
            // 
            this.txtDataAula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAula.Location = new System.Drawing.Point(299, 80);
            this.txtDataAula.Mask = "00/00/0000";
            this.txtDataAula.Name = "txtDataAula";
            this.txtDataAula.Size = new System.Drawing.Size(83, 25);
            this.txtDataAula.TabIndex = 5;
            this.txtDataAula.ValidatingType = typeof(System.DateTime);
            // 
            // cmbPeriodoCurso
            // 
            this.cmbPeriodoCurso.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriodoCurso.FormattingEnabled = true;
            this.cmbPeriodoCurso.Location = new System.Drawing.Point(299, 80);
            this.cmbPeriodoCurso.Name = "cmbPeriodoCurso";
            this.cmbPeriodoCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbPeriodoCurso.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(144, 126);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(137, 23);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "lbl4";
            // 
            // txtLocalAula
            // 
            this.txtLocalAula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalAula.Location = new System.Drawing.Point(299, 127);
            this.txtLocalAula.Name = "txtLocalAula";
            this.txtLocalAula.Size = new System.Drawing.Size(177, 22);
            this.txtLocalAula.TabIndex = 8;
            // 
            // txtCoordenador
            // 
            this.txtCoordenador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoordenador.Location = new System.Drawing.Point(299, 127);
            this.txtCoordenador.Name = "txtCoordenador";
            this.txtCoordenador.Size = new System.Drawing.Size(177, 22);
            this.txtCoordenador.TabIndex = 9;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(144, 164);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(137, 23);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "lbl5";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicio.Location = new System.Drawing.Point(299, 162);
            this.txtHoraInicio.Mask = "90:00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(54, 25);
            this.txtHoraInicio.TabIndex = 11;
            this.txtHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // cmbTipoCurso
            // 
            this.cmbTipoCurso.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCurso.FormattingEnabled = true;
            this.cmbTipoCurso.Location = new System.Drawing.Point(299, 206);
            this.cmbTipoCurso.Name = "cmbTipoCurso";
            this.cmbTipoCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoCurso.TabIndex = 12;
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(144, 207);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(137, 23);
            this.lbl6.TabIndex = 13;
            this.lbl6.Text = "lbl6";
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraTermino.Location = new System.Drawing.Point(299, 205);
            this.txtHoraTermino.Mask = "90:00";
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.Size = new System.Drawing.Size(54, 25);
            this.txtHoraTermino.TabIndex = 15;
            this.txtHoraTermino.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(299, 41);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(198, 22);
            this.txtDescricao.TabIndex = 16;
            // 
            // cmbAnoCurso
            // 
            this.cmbAnoCurso.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnoCurso.FormattingEnabled = true;
            this.cmbAnoCurso.Location = new System.Drawing.Point(299, 162);
            this.cmbAnoCurso.Name = "cmbAnoCurso";
            this.cmbAnoCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbAnoCurso.TabIndex = 17;
            // 
            // pctSetaDireita
            // 
            this.pctSetaDireita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctSetaDireita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSetaDireita.Image = global::InterfaceAgendaAluno.Properties.Resources.setaDireita;
            this.pctSetaDireita.Location = new System.Drawing.Point(621, 13);
            this.pctSetaDireita.Name = "pctSetaDireita";
            this.pctSetaDireita.Size = new System.Drawing.Size(79, 67);
            this.pctSetaDireita.TabIndex = 19;
            this.pctSetaDireita.TabStop = false;
            // 
            // pctSetaEsquerda
            // 
            this.pctSetaEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctSetaEsquerda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSetaEsquerda.Image = global::InterfaceAgendaAluno.Properties.Resources.setaEsquerda;
            this.pctSetaEsquerda.Location = new System.Drawing.Point(550, 13);
            this.pctSetaEsquerda.Name = "pctSetaEsquerda";
            this.pctSetaEsquerda.Size = new System.Drawing.Size(75, 67);
            this.pctSetaEsquerda.TabIndex = 18;
            this.pctSetaEsquerda.TabStop = false;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 304);
            this.Controls.Add(this.pctSetaDireita);
            this.Controls.Add(this.pctSetaEsquerda);
            this.Controls.Add(this.cmbAnoCurso);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtHoraTermino);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.cmbTipoCurso);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtCoordenador);
            this.Controls.Add(this.txtLocalAula);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cmbPeriodoCurso);
            this.Controls.Add(this.txtDataAula);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.grbConsultaTabela);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.Text = "CONSULTAS";
            this.grbConsultaTabela.ResumeLayout(false);
            this.grbConsultaTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSetaDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSetaEsquerda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCurso;
        private System.Windows.Forms.GroupBox grbConsultaTabela;
        private System.Windows.Forms.RadioButton rdbAula;
        private System.Windows.Forms.RadioButton rdbTurma;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.MaskedTextBox txtDataAula;
        private System.Windows.Forms.ComboBox cmbPeriodoCurso;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtLocalAula;
        private System.Windows.Forms.TextBox txtCoordenador;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.MaskedTextBox txtHoraInicio;
        private System.Windows.Forms.ComboBox cmbTipoCurso;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.MaskedTextBox txtHoraTermino;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbAnoCurso;
        private System.Windows.Forms.PictureBox pctSetaEsquerda;
        private System.Windows.Forms.PictureBox pctSetaDireita;
    }
}