using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfaceAgendaAluno
{
    public partial class frmPerfil : Form
    {
        
        int idUsuario=0, turma=0, tipoUsuario=0;
        CtrlUsuario objCtrlUsuario = new CtrlUsuario();
        Usuario objUsuario = new Usuario();
        MySqlConnection conn = new MySqlConnection();
        public frmPerfil()
        {
            InitializeComponent();
        }

        public frmPerfil (int idRecebido)
        {
            InitializeComponent();
            idUsuario = idRecebido;
        }

        private void pctNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario new_usuario = new frmCadastroUsuario();
            new_usuario.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                objUsuario.idUsuario = Convert.ToInt32(idUsuario);
                objUsuario.codTipoUsuario = Convert.ToInt32(tipoUsuario);
                objUsuario.nome = txtNome.Text;
                objUsuario.email = txtEmail.Text;
                objUsuario.telefone = txtTelefone.Text;
                objUsuario.dataNascimento = txtDataNascimento.Text;
                objUsuario.senha = txtSenha.Text;
                DialogResult dialogo = MessageBox.Show("Deseja alterar seus dados", "ALTERAÇÃO", MessageBoxButtons.YesNo);
                if (dialogo.Equals(DialogResult.Yes))
                {
                    if (objCtrlUsuario.Alterar(objUsuario, idUsuario))
                    {
                        MessageBox.Show("Alterado com sucesso!");
                        MessageBox.Show("Para alterar suas informações o sistema será reiniciado");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao alterar seus dados!");
                    }
                }
                else
                {
                    txtNome.Enabled = false;
                    txtTelefone.Enabled = false;
                    txtDataNascimento.Enabled = false;
                    pctImagePerfil.Visible = false;
                    txtSenha.Enabled =false;
                    btnSalvar.Visible = false;
                    btnEditar.Visible = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.TabIndex = 1;
            txtTelefone.TabIndex = 2;
            txtDataNascimento.TabIndex = 3;
            txtSenha.TabIndex = 4;
            btnSalvar.TabIndex = 5;
            btnCancelar.TabIndex = 6;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtDataNascimento.Enabled = true;
            lblSenha.Visible = true;
            txtSenha.Visible = true;
            txtSenha.Enabled = true;
            pctImagePerfil.Visible = false;
            btnSalvar.Visible = true;
            btnEditar.Visible = false;
   
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente excluir sua conta", "ATENÇÃO", MessageBoxButtons.YesNo);
            if (dialogo.Equals(DialogResult.Yes))
            {
                Usuario objUsuario = new Usuario();
                CtrlUsuario objCtrlUsuario = new CtrlUsuario();
                objUsuario.idUsuario = idUsuario;
                if(objCtrlUsuario.Excluir(objUsuario, idUsuario))
                {
                    MessageBox.Show("Sua conta será excluída permanentemente! Agradecemos pelo uso de nossos serviços.");
                    Application.Exit();
                }
                
            }
            else if (dialogo.Equals(DialogResult.No))
            {

            }

        }

        private void pctImagePerfil_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario new_users = new frmCadastroUsuario();
            new_users.ShowDialog();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
                conn = Conexao.Conectar();
                objUsuario = objCtrlUsuario.selecionarUsuario(idUsuario);
                 idUsuario =  Convert.ToInt32(objUsuario.idUsuario);         
                 tipoUsuario = Convert.ToInt32(objUsuario.codTipoUsuario);
                txtNome.Text = objUsuario.nome;
                txtEmail.Text = objUsuario.email;
                txtTelefone.Text = objUsuario.telefone;
                txtDataNascimento.Text = objUsuario.dataNascimento;
                txtSenha.Text = Convert.ToString(objUsuario.senha);
        }
    }
}
