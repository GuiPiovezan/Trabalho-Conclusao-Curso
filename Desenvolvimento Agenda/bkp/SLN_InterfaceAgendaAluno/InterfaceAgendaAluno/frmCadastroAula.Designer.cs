namespace InterfaceAgendaAluno
{
    partial class frmCadastroAula
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
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSelectTurma = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtTermino = new System.Windows.Forms.MaskedTextBox();
            this.dataConsultaAula = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSelectDisciplina = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcuir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaAula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(86, 139);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(315, 20);
            this.txtLocal.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "Local:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "CADASTRO DE AULAS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Início";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(487, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(83, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(672, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "Término";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "SELECIONE A TURMA:";
            // 
            // cmbSelectTurma
            // 
            this.cmbSelectTurma.FormattingEnabled = true;
            this.cmbSelectTurma.Location = new System.Drawing.Point(189, 53);
            this.cmbSelectTurma.Name = "cmbSelectTurma";
            this.cmbSelectTurma.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectTurma.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(200, 95);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(93, 26);
            this.txtData.TabIndex = 3;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(441, 95);
            this.txtInicio.Mask = "90:00";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(49, 26);
            this.txtInicio.TabIndex = 4;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtTermino
            // 
            this.txtTermino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermino.Location = new System.Drawing.Point(592, 95);
            this.txtTermino.Mask = "90:00";
            this.txtTermino.Name = "txtTermino";
            this.txtTermino.Size = new System.Drawing.Size(48, 26);
            this.txtTermino.TabIndex = 5;
            this.txtTermino.ValidatingType = typeof(System.DateTime);
            // 
            // dataConsultaAula
            // 
            this.dataConsultaAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultaAula.Location = new System.Drawing.Point(15, 172);
            this.dataConsultaAula.Name = "dataConsultaAula";
            this.dataConsultaAula.Size = new System.Drawing.Size(740, 212);
            this.dataConsultaAula.TabIndex = 10;
            this.dataConsultaAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConsultaAula_CellClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 68;
            this.label7.Text = "DISCIPLINA:";
            // 
            // cmbSelectDisciplina
            // 
            this.cmbSelectDisciplina.FormattingEnabled = true;
            this.cmbSelectDisciplina.Location = new System.Drawing.Point(506, 53);
            this.cmbSelectDisciplina.Name = "cmbSelectDisciplina";
            this.cmbSelectDisciplina.Size = new System.Drawing.Size(145, 21);
            this.cmbSelectDisciplina.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(584, 140);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(83, 23);
            this.btnAtualizar.TabIndex = 69;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcuir
            // 
            this.btnExcuir.Location = new System.Drawing.Point(682, 140);
            this.btnExcuir.Name = "btnExcuir";
            this.btnExcuir.Size = new System.Drawing.Size(66, 23);
            this.btnExcuir.TabIndex = 70;
            this.btnExcuir.Text = "DELETAR";
            this.btnExcuir.UseVisualStyleBackColor = true;
            this.btnExcuir.Click += new System.EventHandler(this.btnExcuir_Click);
            // 
            // frmCadastroAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceAgendaAluno.Properties.Resources.backgroudAgendaDesktop;
            this.ClientSize = new System.Drawing.Size(760, 431);
            this.Controls.Add(this.btnExcuir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cmbSelectDisciplina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataConsultaAula);
            this.Controls.Add(this.txtTermino);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmbSelectTurma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aulas";
            this.Load += new System.EventHandler(this.frmCadastroAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSelectTurma;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.MaskedTextBox txtTermino;
        private System.Windows.Forms.DataGridView dataConsultaAula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSelectDisciplina;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcuir;
    }
}