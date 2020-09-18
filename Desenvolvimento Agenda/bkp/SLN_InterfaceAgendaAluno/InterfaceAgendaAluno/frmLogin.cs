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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string emailRecebido = "", senhaRecebido = "", email = "", senha="";
            int idRecebido = 0, idUsuario = 0;
            Usuario objUsuario = new Usuario();
            CtrlUsuario objCtrlUsuario = new CtrlUsuario();
            emailRecebido = txtLoginEmail.Text;
            senhaRecebido = txtLoginSenha.Text;

            try
            {
                objUsuario = objCtrlUsuario.Logar(objUsuario, idRecebido, emailRecebido, senhaRecebido);
                
                if (objUsuario == null)
                {
                    MessageBox.Show("Usuário não cadastrado!");
                }
                else
                {
                    email = objUsuario.email; senha = objUsuario.senha; idRecebido = idUsuario;
                    if (emailRecebido.Equals(email) && senhaRecebido.Equals(senha))
                    {
                        this.Hide();
                        frmInterfacePrincipal new_fase = new frmInterfacePrincipal(objUsuario.email, objUsuario.senha, Convert.ToInt32(objUsuario.idUsuario));
                        new_fase.ShowDialog();
                        this.Visible = false;
                    }
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
         }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario new_users = new frmCadastroUsuario();
            new_users.ShowDialog();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
