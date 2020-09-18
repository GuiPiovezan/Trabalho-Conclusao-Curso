namespace InterfaceAgendaAluno
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.pctImagePerfil = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERFIL DO USUÁRIO";
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME:";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(337, 192);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 24);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(13, 133);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(98, 23);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(13, 170);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(187, 23);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "DATA DE NASCIMENTO:";
            // 
            // pctImagePerfil
            // 
            this.pctImagePerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctImagePerfil.Image = ((System.Drawing.Image)(resources.GetObject("pctImagePerfil.Image")));
            this.pctImagePerfil.Location = new System.Drawing.Point(449, 12);
            this.pctImagePerfil.Name = "pctImagePerfil";
            this.pctImagePerfil.Size = new System.Drawing.Size(45, 45);
            this.pctImagePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctImagePerfil.TabIndex = 10;
            this.pctImagePerfil.TabStop = false;
            this.pctImagePerfil.Click += new System.EventHandler(this.pctImagePerfil_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(80, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(80, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Enabled = false;
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(206, 169);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(75, 22);
            this.txtDataNascimento.TabIndex = 4;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(107, 132);
            this.txtTelefone.Mask = "(99)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(101, 22);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(13, 207);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 23);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "SENHA:";
            this.lblSenha.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(337, 192);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 24);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(80, 206);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(210, 22);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(360, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "DELETE SUA CONTA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceAgendaAluno.Properties.Resources.backgroudAgendaDesktop;
            this.ClientSize = new System.Drawing.Size(505, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pctImagePerfil);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagePerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.PictureBox pctImagePerfil;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
    }
}