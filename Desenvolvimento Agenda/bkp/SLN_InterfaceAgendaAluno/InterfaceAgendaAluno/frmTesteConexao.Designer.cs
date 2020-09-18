namespace InterfaceAgendaAluno
{
    partial class frmTesteConexao
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 54);
            this.label5.TabIndex = 48;
            this.label5.Text = "Para testar a conexão com o banco de dados, prima o botão abaixo!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(125, 137);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(75, 35);
            this.btnTestarConexao.TabIndex = 49;
            this.btnTestarConexao.Text = "TESTAR CONEXÃO";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(221, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTesteConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 184);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnTestarConexao);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTesteConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Conexão";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Button btnCancelar;
    }
}