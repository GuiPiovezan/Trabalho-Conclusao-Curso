using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfaceAgendaAluno
{
    public partial class frmInterfacePrincipal : Form
    {
        string email = "", senha = ""; int idUsuario = 0;
        
        public frmInterfacePrincipal()
        {
            InitializeComponent();
        }
        public frmInterfacePrincipal(string emailRecebido, string senhaRecebida, int idRecebido)
        {

            InitializeComponent();
            email = emailRecebido;
            senha = senhaRecebida;
            idUsuario = idRecebido;
        }

        private void frmInterfacePrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfil new_perfil = new frmPerfil(idUsuario);
            new_perfil.ShowDialog();
        }
        private void tESTEDECONEXÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTesteConexao new_conn = new frmTesteConexao();
            new_conn.ShowDialog();
        }

        private void uNIDADEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroUnidade new_unidade = new frmCadastroUnidade();
            new_unidade.ShowDialog();
        }

        private void tURMASECURSOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroCurso new_turma = new frmCadastroCurso();
            new_turma.ShowDialog();
        }

        private void aULASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroAula new_aula = new frmCadastroAula();
            new_aula.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja sair do sistema", "Finalizando...", MessageBoxButtons.YesNo);
            if (dialogo.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else if(dialogo.Equals(DialogResult.No))
            {
                
            }
            
        }

        private void dISCIPLINASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplina cadDisciplina = new frmCadastroDisciplina();
            cadDisciplina.ShowDialog();
        }

        private void tURMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTurma cadTurma = new frmCadastroTurma();
            cadTurma.ShowDialog();
        }

    }
}
