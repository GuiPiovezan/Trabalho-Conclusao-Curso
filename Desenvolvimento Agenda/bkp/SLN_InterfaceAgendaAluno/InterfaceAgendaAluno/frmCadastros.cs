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
    public partial class frmCadastros : Form
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTurmaCurso turma_curso = new frmCadastroTurmaCurso();
            turma_curso.ShowDialog();
        }

        private void unidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidade unidade = new frmCadastroUnidade();
            unidade.ShowDialog();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAula aula = new frmCadastroAula();
            aula.ShowDialog();
        }

        private void testeDeConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTesteConexao teste = new frmTesteConexao();
            teste.ShowDialog();
        }
    }
}
