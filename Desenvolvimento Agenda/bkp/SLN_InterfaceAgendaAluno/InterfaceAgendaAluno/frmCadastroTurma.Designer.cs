namespace InterfaceAgendaAluno
{
    partial class frmCadastroTurma
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
            this.txtDescricaoTurma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelecCurso = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.dataConsultaTurma = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricaoTurma
            // 
            this.txtDescricaoTurma.Location = new System.Drawing.Point(179, 83);
            this.txtDescricaoTurma.Name = "txtDescricaoTurma";
            this.txtDescricaoTurma.Size = new System.Drawing.Size(277, 20);
            this.txtDescricaoTurma.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Descrição da Turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "TURMA";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "SELECIONE O CURSO";
            // 
            // cmbSelecCurso
            // 
            this.cmbSelecCurso.FormattingEnabled = true;
            this.cmbSelecCurso.Location = new System.Drawing.Point(213, 47);
            this.cmbSelecCurso.Name = "cmbSelecCurso";
            this.cmbSelecCurso.Size = new System.Drawing.Size(243, 21);
            this.cmbSelecCurso.TabIndex = 40;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(287, 154);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(82, 23);
            this.btnCadastrar.TabIndex = 41;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Período:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "MANHÃ",
            "TARDE",
            "NOITE"});
            this.cmbPeriodo.Location = new System.Drawing.Point(95, 121);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodo.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Digite o código da turma:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(213, 193);
            this.txtPesquisa.MaxLength = 6;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(121, 20);
            this.txtPesquisa.TabIndex = 46;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(352, 193);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(34, 23);
            this.btnOk.TabIndex = 47;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dataConsultaTurma
            // 
            this.dataConsultaTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultaTurma.Location = new System.Drawing.Point(22, 231);
            this.dataConsultaTurma.Name = "dataConsultaTurma";
            this.dataConsultaTurma.Size = new System.Drawing.Size(434, 172);
            this.dataConsultaTurma.TabIndex = 48;
            this.dataConsultaTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConsultaTurma_CellClick);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(381, 154);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 49;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // frmCadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceAgendaAluno.Properties.Resources.backgroudAgendaDesktop;
            this.ClientSize = new System.Drawing.Size(475, 458);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dataConsultaTurma);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbSelecCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricaoTurma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroTurma";
            this.Text = "Cadastro de Turmas";
            this.Load += new System.EventHandler(this.frmCadastroTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricaoTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelecCurso;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dataConsultaTurma;
        private System.Windows.Forms.Button btnDeletar;
    }
}