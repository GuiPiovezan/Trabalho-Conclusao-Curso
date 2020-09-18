namespace InterfaceAgendaAluno
{
    partial class frmCadastroCurso
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
            this.cmbSelecioneUnidade = new System.Windows.Forms.ComboBox();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.cmbTipoCurso = new System.Windows.Forms.ComboBox();
            this.lblTipoCurso = new System.Windows.Forms.Label();
            this.txtNomeCoordenador = new System.Windows.Forms.TextBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtDescricaoCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescricaoCurso = new System.Windows.Forms.Label();
            this.lblSelecioneUnidade = new System.Windows.Forms.Label();
            this.lblNomeInterface = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataConsultaCurso = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelecioneUnidade
            // 
            this.cmbSelecioneUnidade.FormattingEnabled = true;
            this.cmbSelecioneUnidade.Location = new System.Drawing.Point(239, 72);
            this.cmbSelecioneUnidade.Name = "cmbSelecioneUnidade";
            this.cmbSelecioneUnidade.Size = new System.Drawing.Size(208, 21);
            this.cmbSelecioneUnidade.TabIndex = 1;
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.Location = new System.Drawing.Point(491, 161);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(81, 23);
            this.btnCadastrarCurso.TabIndex = 7;
            this.btnCadastrarCurso.Text = "CADASTRAR";
            this.btnCadastrarCurso.UseVisualStyleBackColor = true;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // cmbTipoCurso
            // 
            this.cmbTipoCurso.FormattingEnabled = true;
            this.cmbTipoCurso.Items.AddRange(new object[] {
            "ETIM",
            "MEDTEC",
            "TECNICO"});
            this.cmbTipoCurso.Location = new System.Drawing.Point(601, 117);
            this.cmbTipoCurso.Name = "cmbTipoCurso";
            this.cmbTipoCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCurso.TabIndex = 6;
            // 
            // lblTipoCurso
            // 
            this.lblTipoCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCurso.Location = new System.Drawing.Point(488, 116);
            this.lblTipoCurso.Name = "lblTipoCurso";
            this.lblTipoCurso.Size = new System.Drawing.Size(122, 23);
            this.lblTipoCurso.TabIndex = 30;
            this.lblTipoCurso.Text = "Tipo de Curso";
            // 
            // txtNomeCoordenador
            // 
            this.txtNomeCoordenador.Location = new System.Drawing.Point(203, 150);
            this.txtNomeCoordenador.Name = "txtNomeCoordenador";
            this.txtNomeCoordenador.Size = new System.Drawing.Size(277, 20);
            this.txtNomeCoordenador.TabIndex = 5;
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cmbAno.Location = new System.Drawing.Point(550, 74);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(121, 21);
            this.cmbAno.TabIndex = 3;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(495, 73);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(49, 22);
            this.lblAno.TabIndex = 27;
            this.lblAno.Text = "Ano:";
            // 
            // txtDescricaoCurso
            // 
            this.txtDescricaoCurso.Location = new System.Drawing.Point(203, 117);
            this.txtDescricaoCurso.Name = "txtDescricaoCurso";
            this.txtDescricaoCurso.Size = new System.Drawing.Size(277, 20);
            this.txtDescricaoCurso.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Coordenador do Curso:";
            // 
            // lblDescricaoCurso
            // 
            this.lblDescricaoCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCurso.Location = new System.Drawing.Point(14, 114);
            this.lblDescricaoCurso.Name = "lblDescricaoCurso";
            this.lblDescricaoCurso.Size = new System.Drawing.Size(163, 23);
            this.lblDescricaoCurso.TabIndex = 22;
            this.lblDescricaoCurso.Text = "Descrição do Curso:";
            // 
            // lblSelecioneUnidade
            // 
            this.lblSelecioneUnidade.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneUnidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneUnidade.Location = new System.Drawing.Point(14, 72);
            this.lblSelecioneUnidade.Name = "lblSelecioneUnidade";
            this.lblSelecioneUnidade.Size = new System.Drawing.Size(219, 23);
            this.lblSelecioneUnidade.TabIndex = 21;
            this.lblSelecioneUnidade.Text = "Selecione a Unidade Escolar";
            // 
            // lblNomeInterface
            // 
            this.lblNomeInterface.AutoSize = true;
            this.lblNomeInterface.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeInterface.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeInterface.Location = new System.Drawing.Point(12, 25);
            this.lblNomeInterface.Name = "lblNomeInterface";
            this.lblNomeInterface.Size = new System.Drawing.Size(238, 24);
            this.lblNomeInterface.TabIndex = 20;
            this.lblNomeInterface.Text = "CADASTRO DE CURSO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(641, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataConsultaCurso
            // 
            this.dataConsultaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultaCurso.Location = new System.Drawing.Point(45, 190);
            this.dataConsultaCurso.Name = "dataConsultaCurso";
            this.dataConsultaCurso.Size = new System.Drawing.Size(642, 205);
            this.dataConsultaCurso.TabIndex = 31;
            this.dataConsultaCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConsultaCurso_CellClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(578, 161);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 23);
            this.btnAtualizar.TabIndex = 32;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(665, 161);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(66, 23);
            this.btnDeletar.TabIndex = 33;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // frmCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceAgendaAluno.Properties.Resources.backgroudAgendaDesktop;
            this.ClientSize = new System.Drawing.Size(734, 451);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataConsultaCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbSelecioneUnidade);
            this.Controls.Add(this.btnCadastrarCurso);
            this.Controls.Add(this.cmbTipoCurso);
            this.Controls.Add(this.lblTipoCurso);
            this.Controls.Add(this.txtNomeCoordenador);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtDescricaoCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescricaoCurso);
            this.Controls.Add(this.lblSelecioneUnidade);
            this.Controls.Add(this.lblNomeInterface);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Turmas e Cursos";
            this.Load += new System.EventHandler(this.frmCadastroCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelecioneUnidade;
        private System.Windows.Forms.Button btnCadastrarCurso;
        private System.Windows.Forms.ComboBox cmbTipoCurso;
        private System.Windows.Forms.Label lblTipoCurso;
        private System.Windows.Forms.TextBox txtNomeCoordenador;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtDescricaoCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescricaoCurso;
        private System.Windows.Forms.Label lblSelecioneUnidade;
        private System.Windows.Forms.Label lblNomeInterface;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataConsultaCurso;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
    }
}