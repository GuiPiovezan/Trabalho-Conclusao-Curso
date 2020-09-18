using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceAgendaAluno
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objUsuario = new Usuario();
                CtrlUsuario objCtrlUsuario = new CtrlUsuario();
                objUsuario.codTipoUsuario = 2;

                objUsuario.nome = Convert.ToString(txtNomeUsuario.Text);
                objUsuario.email = Convert.ToString(txtEmailUsuario.Text);
                objUsuario.telefone = Convert.ToString(txtTelefone.Text);
                objUsuario.dataNascimento = Convert.ToString(txtDataNascimento.Text);
                objUsuario.senha = Convert.ToString(txtSenhaUsuario.Text);
                if (objCtrlUsuario.Inserir(objUsuario))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário!");
                }



                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado ao cadastrar um novo usuário, problemas com o banco de dados!\n" + ex);
            }
        }
            
    }
}
