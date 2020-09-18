namespace InterfaceAgendaAluno
{
    partial class frmCadastroUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO DE USUÁRIO";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOME:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(102, 59);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(325, 20);
            this.txtNomeUsuario.TabIndex = 3;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(102, 97);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(325, 20);
            this.txtEmailUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-MAIL:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "SENHA:";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(187, 243);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(240, 20);
            this.txtSenhaUsuario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "CONFIRME A SENHA:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(187, 277);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(240, 20);
            this.txtConfirmaSenha.TabIndex = 8;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(262, 313);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(83, 23);
            this.btnCadastrarUsuario.TabIndex = 9;
            this.btnCadastrarUsuario.Text = "CADASTRAR";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "DATA DE NASCIMENTO";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "TELEFONE:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTelefone.Location = new System.Drawing.Point(102, 173);
            this.txtTelefone.Mask = "(99)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(97, 23);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDataNascimento.Location = new System.Drawing.Point(205, 202);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(76, 23);
            this.txtDataNascimento.TabIndex = 6;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 30);
            this.label8.TabIndex = 25;
            this.label8.Text = "CONFIRME EMAIL:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 24;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceAgendaAluno.Properties.Resources.backgroudAgendaDesktop;
            this.ClientSize = new System.Drawing.Size(439, 346);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}